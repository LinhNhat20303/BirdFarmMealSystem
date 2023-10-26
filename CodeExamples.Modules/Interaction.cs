using System.Collections.Generic;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.HTML.Demos {
    public partial class Interaction : CodeTutorialControl {
        public Interaction() {
            InitializeComponent();
        }
        protected override List<string> InitializeHighlightTokens() {
            var list = base.InitializeHighlightTokens();
            list.Add("MVVMContext");
            list.Add("ISupportParameter");
            list.Add("IDocumentContent");
            list.Add("IMessageBoxService");
            list.Add("IWindowService");
            return list;
        }
        protected override string PreprocessCodeBeforeCompilation(string code, ExampleLanguage language) {
            if(code.Contains("MainView"))
                code = code.Replace("XtraUserControl mainView = null", "MainView mainView = new MainView()");
            if(code.Contains("MainMenuView"))
                code = code.Replace("XtraUserControl mainMenuView = null", "MainMenuView mainMenuView = new MainMenuView()");
            if(code.Contains("TooltipView"))
                code = code.Replace("XtraUserControl tooltipView = null", "TooltipView tooltipView = new TooltipView()");
            if(code.Contains("DialogView"))
                code = code.Replace("XtraUserControl dialogView = null", "DialogView dialogView = new DialogView()");
            if(code.Contains("PopupView"))
                code = code.Replace("XtraUserControl popupView = null", "PopupView popupView = new PopupView()");
            // VB Converter
            if(language == ExampleLanguage.VB) {
                code = code.Replace(" Utils.DefaultBoolean.", " DevExpress.Utils.DefaultBoolean.");
                code = code.Replace(" Utils.PlacementHelper.", " DevExpress.Utils.PlacementHelper.");
            }
            return base.PreprocessCodeBeforeCompilation(code, language);
        }
        protected override string PreprocessCodeBeforeOpen(string code, ExampleLanguage language) {
            if(code.Contains("MainView"))
                code = code.Replace("XtraUserControl mainView = null", "MainView mainView = new MainView()");
            if(code.Contains("MainMenuView"))
                code = code.Replace("XtraUserControl mainMenuView = null", "MainMenuView mainMenuView = new MainMenuView()");
            if(code.Contains("TooltipView"))
                code = code.Replace("XtraUserControl tooltipView = null", "TooltipView tooltipView = new TooltipView()");
            if(code.Contains("DialogView"))
                code = code.Replace("XtraUserControl dialogView = null", "DialogView dialogView = new DialogView()");
            if(code.Contains("PopupView"))
                code = code.Replace("XtraUserControl popupView = null", "PopupView popupView = new PopupView()");
            // VB Converter
            if(language == ExampleLanguage.VB) {
                code = code.Replace(" Utils.DefaultBoolean.", " DevExpress.Utils.DefaultBoolean.");
                code = code.Replace(" Utils.PlacementHelper.", " DevExpress.Utils.PlacementHelper.");
            }
            return base.PreprocessCodeBeforeOpen(code, language);
        }
    }
}
