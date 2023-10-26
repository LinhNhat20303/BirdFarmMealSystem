using System.Collections.Generic;
using System.Linq;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.HTML.Demos.CodeExamples {
    public class CssFile : CodeExampleResourceFile {
        public CssFile(string fileName, bool allowModify=true)
            : base(typeof(CssFile).Assembly.FullName, GetResourceName(fileName)) {
            this.allowModify = allowModify;
            Name = "[CSS]";
        }
        protected override bool AllowModify {
            get {
                return allowModify;
            }
        }
        public CssFile(params string[] fileNames) : base(typeof(CssFile).Assembly.FullName, string.Empty) {
            List<string> res = new List<string>();
            foreach(var item in fileNames) {
                res.Add(GetResourceName(item));
            }
            this.ResourceNames = res.ToArray();
        }
        const string resourcePath = "DevExpress.HTML.Demos.CodeExamples.css.";
        private readonly bool allowModify;
        static string GetResourceName(string fileName) {
            if(DemoHelper.IsCSharp)
                return resourcePath + fileName + ".css";
            return fileName.Split('.').Last() + ".css";
        }
    }
}
