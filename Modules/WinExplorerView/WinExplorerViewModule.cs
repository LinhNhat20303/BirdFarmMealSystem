﻿using System;
using System.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.HTML.Demos.Helpers.Data;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.WinExplorer;

namespace DevExpress.HTML.Demos.Modules.WinExplorerView
{
    public partial class WinExplorerViewModule : TutorialControlBase {
        HtmlContentPopup detailsPopup;
        public WinExplorerViewModule() {
            InitializeComponent();
            VehiclesData.InitVehiclesData(this.gridControl1);
            templateViewer.Fill(this.winExplorerView1);
            //
            detailsPopup = new HtmlContentPopup();
            detailsPopup.ElementMouseClick += OnPopupElementMouseClick;
            detailsPopup.HtmlImages = svgImageCollection1;
            detailsPopup.HtmlTemplate.Assign(winExplorerView1.HtmlTemplates[0]);
        }
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            UpdateBackground();
        }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateBackground();
        }
        Color BlendColor(Color bg, Color c) {
            float a = 0.1f;
            return Color.FromArgb((int)(a * c.R + (1 - a) * bg.R), (int)(a * c.G + (1 - a) * bg.G), (int)(a * c.B + (1 - a) * bg.B));
        }
        void UpdateBackground() {
            Color bg = LookAndFeelHelper.GetSystemColor(UserLookAndFeel.Default, SystemColors.Window);
            Color fg = LookAndFeelHelper.GetSystemColor(UserLookAndFeel.Default, SystemColors.WindowText);
            this.winExplorerView1.Appearance.EmptySpace.BackColor = BlendColor(bg, fg);
        }
        void onDetailButtonClick(object sender, WinExplorerViewHtmlElementEventArgs e) {
            detailsPopup.DataContext = e.DataItem;
            Rectangle gridBounds = this.gridControl1.RectangleToScreen(gridControl1.ClientRectangle);
            detailsPopup.UseDirectXPaint = DefaultBoolean.True;
            detailsPopup.HtmlTemplate.Assign(winExplorerView1.HtmlTemplates[0]);
            detailsPopup.Show(gridControl1, gridBounds);
        }
        void OnPopupElementMouseClick(object sender, Utils.Html.DxHtmlElementMouseEventArgs e) {
            if(e.ElementId == "close") 
                detailsPopup.Hide();
        }
    }
}
