using DevExpress.Utils;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos.Modules.WinExplorerView
{
    partial class WinExplorerViewModule {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinExplorerViewModule));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.winExplorerView1 = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.popupDetails = new DevExpress.Utils.Html.HtmlTemplate();
            this.htmlTemplate1 = new DevExpress.Utils.Html.HtmlTemplate();
            this.codeViewerPanel = new DevExpress.XtraEditors.SidePanel();
            this.templateViewer = new DevExpress.HTML.Demos.WinExplorerViewTemplateCodeViewer();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.codeViewerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.winExplorerView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(8);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1248, 1041);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView1});
            // 
            // winExplorerView1
            // 
            this.winExplorerView1.Appearance.EmptySpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.winExplorerView1.Appearance.EmptySpace.Options.UseBackColor = true;
            this.winExplorerView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.winExplorerView1.GridControl = this.gridControl1;
            this.winExplorerView1.HtmlImages = this.svgImageCollection1;
            this.winExplorerView1.HtmlTemplates.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.popupDetails});
            this.winExplorerView1.Name = "winExplorerView1";
            this.winExplorerView1.OptionsSelection.ItemSelectionMode = DevExpress.XtraGrid.Views.WinExplorer.IconItemSelectionMode.Press;
            this.winExplorerView1.OptionsView.ContentHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.ExtraLarge;
            this.winExplorerView1.OptionsViewStyles.ExtraLarge.HorizontalIndent = 0;
            // 
            // 
            // 
            this.winExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Styles = resources.GetString("winExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Styles");
            this.winExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Tag = "Card";
            this.winExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Template = resources.GetString("winExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Template");
            this.winExplorerView1.OptionsViewStyles.ExtraLarge.VerticalIndent = 0;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("close", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.close"))));
            // 
            // popupDetails
            // 
            this.popupDetails.Name = "popupDetails";
            this.popupDetails.Styles = resources.GetString("popupDetails.Styles");
            this.popupDetails.Tag = "Popup Details";
            this.popupDetails.Template = resources.GetString("popupDetails.Template");
            // 
            // htmlTemplate1
            // 
            this.htmlTemplate1.Name = "htmlTemplate1";
            this.htmlTemplate1.Styles = resources.GetString("htmlTemplate1.Styles");
            this.htmlTemplate1.Template = resources.GetString("htmlTemplate1.Template");
            // 
            // codeViewerPanel
            // 
            this.codeViewerPanel.Controls.Add(this.templateViewer);
            this.codeViewerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.codeViewerPanel.Location = new System.Drawing.Point(1248, 0);
            this.codeViewerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.codeViewerPanel.Name = "codeViewerPanel";
            this.codeViewerPanel.Size = new System.Drawing.Size(554, 1041);
            this.codeViewerPanel.TabIndex = 1;
            this.codeViewerPanel.Text = "sidePanel1";
            // 
            // templateViewer
            // 
            this.templateViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateViewer.Location = new System.Drawing.Point(2, 0);
            this.templateViewer.Margin = new System.Windows.Forms.Padding(12);
            this.templateViewer.Name = "templateViewer";
            this.templateViewer.Size = new System.Drawing.Size(552, 1041);
            this.templateViewer.TabIndex = 0;
            // 
            // WinExplorerViewModule
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.codeViewerPanel);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "WinExplorerViewModule";
            this.Size = new System.Drawing.Size(1802, 1041);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.codeViewerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView1;
        private DevExpress.XtraEditors.SidePanel codeViewerPanel;
        private WinExplorerViewTemplateCodeViewer templateViewer;
        private HtmlTemplate popupDetails;
        private HtmlTemplate htmlTemplate1;
        private SvgImageCollection svgImageCollection1;
    }
}

