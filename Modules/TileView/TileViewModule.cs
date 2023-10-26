using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.HTML.Demos.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;

namespace DevExpress.HTML.Demos {
    public partial class TileViewModule : TutorialControlBase {
        public TileViewModule() {
            InitializeComponent();
            tileViewTemplateCodeViewer1.Fill(tileView1);
            gridControl1.DataSource = DataHelper.Messages;
            this.colDate.SortOrder = Data.ColumnSortOrder.Descending;

            if(MainFormHelper.TakeScreens) tileView1.AnimateArrival = false;
            tileView1.FocusedRowHandle = 2;

            tileView1.CustomItemTemplate += TileView1_CustomItemTemplate;
            tileView1.ItemCustomize += TileView1_ItemCustomize;
        }

        void OnReply(object sender, TileViewHtmlElementMouseEventArgs e) {
            ShowPopup(popupReply, e.Row);
        }
        void OnDelete(object sender, TileViewHtmlElementMouseEventArgs e) {
            ShowPopup(popupDelete, e.Row);
        }
        void OnFlag(object sender, TileViewHtmlElementMouseEventArgs e) {
            var msg = e.Row as EmailMessage;
            if(msg != null)
                msg.Flagged = !msg.Flagged;
        }

        void TileView1_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e) {
            var msg = tileView1.GetRow(e.RowHandle) as Helpers.EmailMessage;
            if(msg == null || e.HtmlElementInfo == null) return;
            bool unread = msg.Read != 1;
            if(msg.Photo != null) {
                var initials = e.HtmlElementInfo.FindElementById("initials");
                if(initials != null) initials.Hidden = true;
            } else {
                var photo = e.HtmlElementInfo.FindElementById("photo");
                if(photo != null) photo.Hidden = true;
            }

            var root = e.HtmlElementInfo.FindElementById("root");
            if(root != null) root.Style.SetProperty("border-left-color", unread ? "@Primary" : "@Window");

            var from = e.HtmlElementInfo.FindElementById("from");
            if(from != null) from.Style.SetProperty("font-weight", unread ? "bold" : "normal");

            var subj = e.HtmlElementInfo.FindElementById("subject");
            if(subj != null) {
                subj.Style.SetProperty("font-weight", unread ? "bold" : "normal");
                subj.Style.SetForeColor(unread ? "@Primary" : "@WindowText");
            }

            var date = e.HtmlElementInfo.FindElementById("date");
            if(date != null) date.Style.SetProperty("color", unread ? "@Primary" : "@WindowText");

            var important = e.HtmlElementInfo.FindElementById("important");
            if(important != null) important.Hidden = msg.Priority != 2;
        }

        void TileView1_CustomItemTemplate(object sender, TileViewCustomItemTemplateEventArgs e) {
            var msg = tileView1.GetRow(e.RowHandle) as EmailMessage;
            if(msg == null) return;
            string result = e.HtmlTemplate.Styles;
            if(msg.Flagged) {
                result = result.Replace("<FlagDefaultOpacity>", "1").Replace("<FlagHoverOpacity>", "1");
            } else {
                result = result.Replace("<FlagDefaultOpacity>", "0").Replace("<FlagHoverOpacity>", "0.5");
            }
            e.HtmlTemplate.Styles = result;
        }

        void ShowPopup(HtmlContentPopup popup, object msg) {
            popup.DataContext = msg;
            var size = popup.CalcBestSize(gridControl1, 1000);
            var rect = gridControl1.RectangleToScreen(gridControl1.ClientRectangle);
            var pt = new Point(rect.X + (rect.Width - size.Width) / 2, rect.Y + (rect.Height - size.Height) / 2);
            popup.Show(gridControl1, new Rectangle(pt, size));
        }
    }
}
