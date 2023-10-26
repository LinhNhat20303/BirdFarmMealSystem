using System.Collections.Generic;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.HTML.Demos {
    public class CodeTutorialControl : CodeTutorialControlBase {
        protected override ExampleLanguage CurrentExampleLanguage {
            get { return DemoHelper.GetExampleLanguage(); }
        }
        protected override bool UseSameTutorialControlNameForGenerateExample {
            get { return true; }
        }
        protected override List<string> InitializeHighlightTokens() {
            var list = base.InitializeHighlightTokens();
            list.Add("XtraForm");
            list.Add("XtraUserControl");
            list.Add("Loader");
            list.Add("DxHtmlElementMouseEventArgs");
            return list;
        }
    }
}
