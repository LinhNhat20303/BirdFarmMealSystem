using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.HTML.Demos {
    public partial class Overview : TutorialControl {
        public Overview() {
            InitializeComponent();
        }

        private void htmlContentControl_ElementMouseClick(object sender, Utils.Html.DxHtmlElementMouseEventArgs e) {
            if(string.IsNullOrEmpty(e.ElementId))
                return;
            XtraMessageBox.Show($"Html Element ({e.ElementId}) clicked!");
        }

        private void htmlOverviewDescription_ElementMouseClick(object sender, Utils.Html.DxHtmlElementMouseEventArgs e) {
            if(e.HitInfo.InLink && e.ElementId == "hRefLink") {
                Data.Utils.SafeProcess.Start($"{e.HitInfo.Href}");
            }
        }
    }
}
