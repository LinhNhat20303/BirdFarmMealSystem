using System.Collections.Generic;
using System.Linq;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.HTML.Demos.CodeExamples {
    public class HtmlFile : CodeExampleResourceFile {
        public HtmlFile(string fileName, bool allowModify = true)
            : base(typeof(HtmlFile).Assembly.FullName, GetResourceName(fileName)) {
            this.allowModify = allowModify;
            Name = "[HTML]";
        }
        protected override bool AllowModify {
            get {
                return allowModify;
            }
        }
        public HtmlFile(params string[] fileNames) : base(typeof(HtmlFile).Assembly.FullName, string.Empty) {
            List<string> res = new List<string>();
            foreach(var item in fileNames)
                res.Add(GetResourceName(item));
            this.ResourceNames = res.ToArray();
        }
        const string resourcePath = "DevExpress.HTML.Demos.CodeExamples.html.";
        private readonly bool allowModify;
        static string GetResourceName(string fileName) {
            if(DemoHelper.IsCSharp)
                return resourcePath + fileName + ".html";
            return fileName.Split('.').Last() + ".html";
        }
    }
}
