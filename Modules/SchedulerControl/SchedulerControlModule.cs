using DevExpress.DevAV;
using DevExpress.DXperience.Demos;
using DevExpress.HTML.Demos.Helpers;
using DevExpress.Utils;
using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.Drawing;


namespace DevExpress.HTML.Demos {
    public partial class SchedulerControlModule : TutorialControlBase {
        public SchedulerControlModule() {
            InitializeComponent();
            this.schedulerControl1.Start = DateTime.Today;
            SchedulerData schedulerData = new SchedulerData();
            schedulerData.AttachToScheduler(this.schedulerControl1);
            LoadImages(schedulerData.Employees);
            this.schedulerTemplateCodeViewer1.Fill(this.schedulerControl1);
        }
        void LoadImages(Dictionary<string, Employee> employees) {
            ImageCollection images = new ImageCollection();
            images.ImageSize = new Size(32, 32);
            images.AddImage(global::DevExpress.HTML.Demos.Properties.Resources.Location, "location");
            this.schedulerControl1.HtmlImages = images;
        }
    }
}
