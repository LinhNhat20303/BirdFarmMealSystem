using DevExpress.DevAV;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit;
using DevExpress.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
#if !DXCORE3
using System.Data.Entity;
#else
using Microsoft.EntityFrameworkCore;
#endif
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.HTML.Demos.Helpers {
    [Flags]
    public enum MailFolder { All = 0, Announcements = 1, General = 2, Management = 4, IT = 8, Sales = 16, Support = 32, Engineering = 64, Deleted = 128, Custom = 1024 };
    public enum MailCategories { General = 1, Management = 2, IT = 3, Sales = 4, Support = 5, Engineering = 6, HR = 7, Design = 8 };
    public enum MailType { Inbox, Deleted, Sent, Draft };

    public class DataHelper {
        static BindingList<Employee> employeesCore = null;
        static BindingList<EmailMessage> messagesCore = null;
        internal static DataTable MailTable {
            get {
                string table = "Messages";
                return CreateDataTable(table);
            }
        }
        public static System.Threading.Tasks.Task LoadMessagesAsync() {
            if(MainFormHelper.TakeScreens) {
                LoadMessages();
                PostUpdateMessaged(null);
                return null;
            }
            var context = DevExpress.Data.Helpers.SyncHelper.TryCaptureSynchronizationContext();
            return System.Threading.Tasks.Task.Run(() => {
                if(LoadMessages() && context != null)
                    context.Post(new System.Threading.SendOrPostCallback(PostUpdateMessaged), null);
            });
        }
        static void PostUpdateMessaged(object state) {
            messagesCore.ResetBindings();
        }
        public static bool LoadMessages() {
            try {
                if(messagesCore == null) {
                    messagesCore = new BindingList<EmailMessage>();
                    DataTable tbl = MailTable;
                    if(tbl != null) {
                        messagesCore.RaiseListChangedEvents = false;
                        foreach(DataRow row in tbl.Rows)
                            messagesCore.Add(new EmailMessage(row));
                        messagesCore.RaiseListChangedEvents = true;
                        return true;
                    }
                }
            }
            catch(Exception e) {
                XtraMessageBox.Show(e.Message, e.Source);
                messagesCore = new BindingList<EmailMessage>();
            }
            return messagesCore.Count > 0;
        }
        public static BindingList<EmailMessage> Messages {
            get {
                LoadMessages();
                return messagesCore;
            }
        }
        internal static BindingList<Employee> Employees {
            get {
                if(employeesCore == null) {
#if !DXCORE3
                    DevAVDb devAvDb = new DevAVDb();
#else
                    DevAVDb devAvDb = new DevAVDb($"Data Source={DevAVDataDirectoryHelper.GetFile("devav.sqlite3", DevAVDataDirectoryHelper.DataFolderName)}");
#endif
                    devAvDb.Employees.Load();
                    employeesCore = devAvDb.Employees.Local.ToBindingList();
                }
                return employeesCore;
            }
        }
        public static Employee GetEmployeeByEmail(string email) {
            return Employees.FirstOrDefault(p => p.Email == email);
        }
        private static DataTable CreateDataTable(string table) {
            DataSet dataSet = new DataSet();
            string dataFile = FilesHelper.FindingFileName(Application.StartupPath, "Data\\MailDevAv.xml");
            if(dataFile != string.Empty) {
                FileInfo fi = new FileInfo(dataFile);
                dataSet.ReadXml(fi.FullName);
                return dataSet.Tables[table];
            }
            return null;
        }
    }
    public class EmailMessage : INotifyPropertyChanged {
        DataRow row;
        DateTime dateCore;
        bool readCore, deletedCore, hasAttachment;
        int priorityCore = 1;
        MailType mailTypeCore;
        int mailFolderCore;
        string fromCore = String.Empty, subjectCore = String.Empty, textCore = String.Empty, plainTextCore = string.Empty, emailCore = String.Empty;

        public EmailMessage() {
            dateCore = TutorialConstants.Now;
        }
        static int counter = 0;
        public EmailMessage(DataRow row) {
            this.row = row;
            var rnd = GetRandomInstance();
            dateCore = TutorialConstants.Now.AddDays((int)row["Day"]).AddSeconds(-rnd.Next(10000));
            emailCore = string.Format("{0}", row["From"]);
            subjectCore = string.Format("{0}", row["Subject"]);
            readCore = Delay > TimeSpan.FromHours(48);
            textCore = string.Format("{0}", row["Text"]);
            deletedCore = false;
            mailTypeCore = MailType.Inbox;
            mailFolderCore = (int)GetFolder(row);
            plainTextCore = GetPlainText();
            var employee = DataHelper.GetEmployeeByEmail(emailCore);
            if(employee != null) {
                fromCore = employee.FullName;
                Photo = employee.Picture != null ? employee.Photo : null;
                FromInitials = CreateInitials(employee.FullName);
            }
            DataTweaking();
        }

        string CreateInitials(string fullName) {
            var split = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;
            if(split.Length > 0) result = split[0][0].ToString().ToUpper();
            if(split.Length > 1) result += split[1][0].ToString().ToUpper();
            return result;
        }

        static Random GetRandomInstance() {
            if(MainFormHelper.TakeScreens) {
                counter++;
                return new Random(counter);
            }
            return TutorialConstants.Random;
        }
        public string FullName {
            get {
                if(string.IsNullOrEmpty(emailCore)) return fromCore;
                return string.Format("{0} ({1})", fromCore, emailCore);
            }
        }
        public DateTime Date { get { return dateCore; } set { dateCore = value; } }
        public string From { get { return fromCore; } set { fromCore = value; } }
        public string FromInitials { get; }
        public string Email { get { return emailCore; } set { emailCore = value; } }
        public string Subject { get { return subjectCore; } set { subjectCore = value; } }
        public string SubjectDisplayText { get { return Subject; } }
        public int Attachment { get { return hasAttachment ? 1 : 0; } }
        public int Read { get { return readCore ? 1 : 0; } }
        public int Priority { get { return priorityCore; } set { priorityCore = value; } }
        public bool IsUnread { get { return !readCore; } }
        internal string Folder { get { return string.Format("{0}", mailFolderCore); } }
        public string Text { get { return textCore; } set { textCore = value; } }
        public string PlainText { get { return GetPlainText(); } }
        public Image Photo { get; }
        

        string GetPlainText() {
            if(string.IsNullOrEmpty(plainTextCore)) {
                plainTextCore = ObjectHelper.GetPlainTextFromMHT(textCore).Replace("\r\n", " ");
            }
            return plainTextCore;
        }
        public MailType MailType { get { return mailTypeCore; } set { mailTypeCore = value; } }
        public int MailFolder {
            get { return mailFolderCore; }
            set {
                if(MailFolder == value) return;
                mailFolderCore = value;
                OnPropertyChanged("MailFolder");
            }
        }
        bool flagged;
        public bool Flagged {
            get { return flagged; }
            set {
                if(flagged == value)
                    return;
                flagged = value;
                OnPropertyChanged(nameof(Flagged));
            }
        }
        public bool Deleted {
            get { return deletedCore; }
            set { deletedCore = value; }
        }
        internal TimeSpan Delay { get { return TutorialConstants.Now - dateCore; } }

        public void ToggleRead() {
            readCore = !readCore;
        }
        void DataTweaking() {
            if(Delay > TimeSpan.FromHours(50) && Delay < TimeSpan.FromHours(100)) readCore = false;
            if(subjectCore.IndexOf("RE:") >= 0 || subjectCore.IndexOf("FW:") >= 0) readCore = false;
            this.hasAttachment = textCore.Length > 20000;
            if(subjectCore.IndexOf("Review") >= 0 || subjectCore.IndexOf("Important") >= 0) priorityCore = 2;
            if(subjectCore.IndexOf("FW:") >= 0 && Delay > TimeSpan.FromHours(48)) priorityCore = 0;
            if(subjectCore.IndexOf("New") >= 0 || subjectCore.IndexOf("Meeting") >= 0)
                mailFolderCore += 1;
        }
        MailFolder GetFolder(DataRow row) {
            object category = row["CategoryID"];
            string ret = string.Format("{0}", (MailCategories)(category == DBNull.Value ? 1 : (int)category));
            if(string.IsNullOrEmpty(ret)) return DevExpress.HTML.Demos.Helpers.MailFolder.All;
            return (MailFolder)Enum.Parse(typeof(MailFolder), ret.Replace(" ", ""));
        }
        public void SetPlainText(string text) { plainTextCore = text; }

        #region INotifyPropertyChanged Members
        event PropertyChangedEventHandler _propertyChangedEventHandler;
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged {
            add { _propertyChangedEventHandler += value; }
            remove { _propertyChangedEventHandler -= value; }
        }
        protected void OnPropertyChanged(string name) {
            if(_propertyChangedEventHandler != null) _propertyChangedEventHandler(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
    public class ObjectHelper {
        static RichEditDocumentServer rich = new RichEditDocumentServer();
        public static string GetPlainTextFromMHT(string mhtText) {
            rich.MhtText = mhtText;
            return rich.Text.TrimStart();
        }
        public static void GetChildDataRowHandles(GridView view, int rowHandle, List<EmailMessage> list) {
            for(int i = 0; i < view.GetChildRowCount(rowHandle); i++) {
                int row = view.GetChildRowHandle(rowHandle, i);
                if(row >= 0)
                    list.Add(view.GetRow(row) as EmailMessage);
                else
                    GetChildDataRowHandles(view, row, list);
            }
        }
    }
}
