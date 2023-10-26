using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm  {
        public frmMain()
            : base() {
            Helpers.DataHelper.LoadMessagesAsync();
        }
        protected override void SetFormParam() {
            Icon = Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.HTML.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override string ProductName {
            get { return "HTML"; }
        }
        protected override string DemoName {
            get { return "HTML Demo (C# code)"; }
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        protected override void ShowModule(string name, XtraEditors.GroupControl group, LookAndFeel.DefaultLookAndFeel lookAndFeel) {
            DemosInfo.ShowModule(name, group, RibbonMenuManager);
        }
        protected override void FillNavBar() {
            DXperience.Demos.ModulesInfo.FillAccordionControl(accordionControl1, XtraNavBar.NavBarGroupStyle.SmallIconsList, true, XtraNavBar.NavBarImage.Large);
        }
        protected override bool CanUseEmptyRootPadding(string name) {
            return true;
        }
        protected override void ShowAbout() {
            BaseEdit.About();
        }
        protected override bool AllowHtmlDebugger => true;
    }
}
