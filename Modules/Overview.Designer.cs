
namespace DevExpress.HTML.Demos {
    partial class Overview {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            this.htmlContentControl = new DevExpress.XtraEditors.HtmlContentControl();
            this.textEditPhone = new DevExpress.XtraEditors.TextEdit();
            this.textEditEmail = new DevExpress.XtraEditors.TextEdit();
            this.textEditFullName = new DevExpress.XtraEditors.TextEdit();
            this.textEditDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.htmlOverviewDescription = new DevExpress.XtraEditors.HtmlContentControl();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl)).BeginInit();
            this.htmlContentControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htmlOverviewDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlContentControl
            // 
            this.tablePanel1.SetColumn(this.htmlContentControl, 1);
            this.htmlContentControl.Controls.Add(this.textEditPhone);
            this.htmlContentControl.Controls.Add(this.textEditEmail);
            this.htmlContentControl.Controls.Add(this.textEditFullName);
            this.htmlContentControl.Controls.Add(this.textEditDisplayName);
            this.htmlContentControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl.HtmlImages = this.svgImageCollection1;
            // 
            // 
            // 
            this.htmlContentControl.HtmlTemplate.Styles = resources.GetString("htmlContentControl.HtmlTemplate.Styles");
            this.htmlContentControl.HtmlTemplate.Template = resources.GetString("htmlContentControl.HtmlTemplate.Template");
            this.htmlContentControl.Location = new System.Drawing.Point(61, 28);
            this.htmlContentControl.Margin = new System.Windows.Forms.Padding(0);
            this.htmlContentControl.MinimumSize = new System.Drawing.Size(620, 628);
            this.htmlContentControl.Name = "htmlContentControl";
            this.tablePanel1.SetRow(this.htmlContentControl, 1);
            this.htmlContentControl.Size = new System.Drawing.Size(620, 628);
            this.htmlContentControl.TabIndex = 0;
            this.htmlContentControl.ElementMouseClick += new DevExpress.Utils.Html.DxHtmlElementMouseEventHandler(this.htmlContentControl_ElementMouseClick);
            // 
            // textEditPhone
            // 
            this.textEditPhone.EditValue = "(562) 559-5830";
            this.textEditPhone.Location = new System.Drawing.Point(331, 277);
            this.textEditPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditPhone.Name = "textEditPhone";
            this.textEditPhone.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditPhone.Properties.Appearance.Options.UseFont = true;
            this.textEditPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEditPhone.Size = new System.Drawing.Size(232, 18);
            this.textEditPhone.TabIndex = 3;
            // 
            // textEditEmail
            // 
            this.textEditEmail.EditValue = "leahs@dx-email.com";
            this.textEditEmail.Location = new System.Drawing.Point(47, 277);
            this.textEditEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditEmail.Name = "textEditEmail";
            this.textEditEmail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditEmail.Properties.Appearance.Options.UseFont = true;
            this.textEditEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEditEmail.Size = new System.Drawing.Size(242, 18);
            this.textEditEmail.TabIndex = 2;
            // 
            // textEditFullName
            // 
            this.textEditFullName.EditValue = "Leah Simpson";
            this.textEditFullName.Location = new System.Drawing.Point(331, 181);
            this.textEditFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditFullName.Name = "textEditFullName";
            this.textEditFullName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditFullName.Properties.Appearance.Options.UseFont = true;
            this.textEditFullName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEditFullName.Size = new System.Drawing.Size(232, 18);
            this.textEditFullName.TabIndex = 1;
            // 
            // textEditDisplayName
            // 
            this.textEditDisplayName.EditValue = "Leah Test Coordinator";
            this.textEditDisplayName.Location = new System.Drawing.Point(47, 181);
            this.textEditDisplayName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditDisplayName.Name = "textEditDisplayName";
            this.textEditDisplayName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditDisplayName.Properties.Appearance.Options.UseFont = true;
            this.textEditDisplayName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEditDisplayName.Size = new System.Drawing.Size(242, 18);
            this.textEditDisplayName.TabIndex = 0;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("employee", "image://svgimages/business objects/bo_lead.svg");
            this.svgImageCollection1.Add("phone", "image://svgimages/outlook inspired/glyph_phone.svg");
            this.svgImageCollection1.Add("contact", "image://svgimages/business objects/bo_contact.svg");
            this.svgImageCollection1.Add("message", "image://svgimages/outlook inspired/glyph_message.svg");
            this.svgImageCollection1.Add("signin", "image://svgimages/scheduling/timezones.svg");
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F)});
            this.tablePanel1.Controls.Add(this.htmlOverviewDescription);
            this.tablePanel1.Controls.Add(this.htmlContentControl);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(5, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Size = new System.Drawing.Size(1122, 676);
            this.tablePanel1.TabIndex = 1;
            // 
            // htmlOverviewDescription
            // 
            this.tablePanel1.SetColumn(this.htmlOverviewDescription, 3);
            this.htmlOverviewDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlOverviewDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlOverviewDescription.HtmlImages = this.svgImageCollection1;
            // 
            // 
            // 
            this.htmlOverviewDescription.HtmlTemplate.Styles = ".container{\r\ndisplay:flex;\r\nflex-direction: column;\r\njustify-content: space-betwe" +
    "en;\r\npadding:20px;\r\ncolor:@WindowText;\r\n}\r\n.text{\r\n\tword-wrap: normal;\r\n\tfont-si" +
    "ze:10pt;\r\n}";
            this.htmlOverviewDescription.HtmlTemplate.Template = resources.GetString("htmlOverviewDescription.HtmlTemplate.Template");
            this.htmlOverviewDescription.Location = new System.Drawing.Point(737, 28);
            this.htmlOverviewDescription.Margin = new System.Windows.Forms.Padding(0);
            this.htmlOverviewDescription.MaximumSize = new System.Drawing.Size(380, 0);
            this.htmlOverviewDescription.MinimumSize = new System.Drawing.Size(380, 0);
            this.htmlOverviewDescription.Name = "htmlOverviewDescription";
            this.tablePanel1.SetRow(this.htmlOverviewDescription, 1);
            this.htmlOverviewDescription.Size = new System.Drawing.Size(380, 620);
            this.htmlOverviewDescription.TabIndex = 1;
            this.htmlOverviewDescription.ElementMouseClick += new DevExpress.Utils.Html.DxHtmlElementMouseEventHandler(this.htmlOverviewDescription_ElementMouseClick);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(1127, 681);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl)).EndInit();
            this.htmlContentControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.htmlOverviewDescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.HtmlContentControl htmlContentControl;
        private Utils.SvgImageCollection svgImageCollection1;
        private XtraEditors.TextEdit textEditPhone;
        private XtraEditors.TextEdit textEditEmail;
        private XtraEditors.TextEdit textEditFullName;
        private XtraEditors.TextEdit textEditDisplayName;
        private Utils.Layout.TablePanel tablePanel1;
        private XtraEditors.HtmlContentControl htmlOverviewDescription;
    }
}
