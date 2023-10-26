using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGantt;
using DevExpress.XtraGrid.Views.WinExplorer;
using DevExpress.XtraGrid.Views.Tile;

namespace DevExpress.HTML.Demos {
    public partial class TemplateCodeViewer: UserControl {
        
        HtmlTemplate currentTemplate = new HtmlTemplate();
        public TemplateCodeViewer() {
            InitializeComponent();
            this.htmlViewer.ReadOnly = false;
            this.htmlViewer.BorderStyle = BorderStyles.NoBorder;
            this.htmlViewer.ScrollBars = ScrollBars.Both;
            this.cssViewer.ReadOnly = false;
            this.cssViewer.BorderStyle = BorderStyles.NoBorder;
            this.cssViewer.ScrollBars = ScrollBars.Both;
        }
        
        protected void FillEditors(HtmlTemplate template) {
            htmlViewer.Template = template.Template;
            cssViewer.Styles = template.Styles;
        }
        void htmlViewer_CodeChanged(object sender, EventArgs e) {
            UpdateTemplate();
            LayoutChanged();
        }
        protected virtual void UpdateTemplate(int templateIndex, string htmlTemplate, string cssStyles) {
            Templates[templateIndex].Template = htmlTemplate;
            Templates[templateIndex].Styles = cssStyles;
        }
        void UpdateTemplate() {
            UpdateTemplate(this.iceTemplates.SelectedIndex, htmlViewer.Template, cssViewer.Styles);
        }
        void cssViewer_CodeChanged(object sender, EventArgs e) {
            UpdateTemplate();
            LayoutChanged();
        }
        void iceTemplates_SelectedIndexChanged(object sender, EventArgs e) {
            currentTemplate.Assign((HtmlTemplate)iceTemplates.EditValue);
            FillEditors(currentTemplate);
        }
        void resetButton_Click(object sender, EventArgs e) {
            switch(this.tabControl.SelectedTabPageIndex) {
                case 0:
                    UpdateHtmlTemplate(this.iceTemplates.SelectedIndex, currentTemplate.Template);
                    htmlViewer.Template = currentTemplate.Template;
                    break;
                case 1:
                    UpdateCssStyle(this.iceTemplates.SelectedIndex, currentTemplate.Styles);
                    cssViewer.Styles = currentTemplate.Styles;
                    break;
            }
            LayoutChanged();
        }
        protected virtual void UpdateHtmlTemplate(int templateIndex, string htmlTemplate) {
            Templates[templateIndex].Template = htmlTemplate;
        }
        protected virtual void UpdateCssStyle(int templateIndex, string cssStyle) {
            Templates[templateIndex].Styles = cssStyle;
        }
        protected virtual void LayoutChanged() { 
        }
        protected void AddTemplate(HtmlTemplate template) {
            this.iceTemplates.Properties.Items.Add(new ImageComboBoxItem((string)template.Tag, template, -1));
        }
        protected List<HtmlTemplate> Templates { get; set; }
        protected void FillTemplates(IEnumerable<HtmlTemplate> templates) {
            Templates = new List<HtmlTemplate>();
            foreach(HtmlTemplate template in templates) {
                Templates.Add(template);
                AddTemplate(template);
            }
            if(this.iceTemplates.Properties.Items.Count > 0) {
                this.iceTemplates.EditValue = (HtmlTemplate)this.iceTemplates.Properties.Items[0].Value;
                this.currentTemplate.Assign((HtmlTemplate)this.iceTemplates.EditValue);
                FillEditors(this.currentTemplate);
            }
        }
        public HtmlTemplate ActiveTemplate {
            get {
                return (HtmlTemplate)iceTemplates.EditValue;
            }
        }
    }

    public class GanttTemplateCodeViewer : TemplateCodeViewer {
        GanttControl owner;
        public void Fill(GanttControl owner) {
            this.owner = owner;
            FillTemplates(owner.HtmlTemplates);
        }
        protected override void LayoutChanged() {
            this.owner.LayoutChanged();
        }
    }

    public class WinExplorerViewTemplateCodeViewer : TemplateCodeViewer {
        WinExplorerView view;
        public void Fill(WinExplorerView view) {
            this.view = view;
            List<HtmlTemplate> templates = new List<HtmlTemplate>();
            templates.Add(view.OptionsViewStyles.ExtraLarge.HtmlTemplate);
            templates.AddRange(view.HtmlTemplates);
            FillTemplates(templates);
        }
        protected override void LayoutChanged() {
            this.view.LayoutChanged();
        }
    }

    public class TileViewTemplateCodeViewer : TemplateCodeViewer {
        TileView view;
        public void Fill(TileView view) {
            this.view = view;
            List<HtmlTemplate> templates = new List<HtmlTemplate>();
            templates.Add(view.TileHtmlTemplate);
            FillTemplates(templates);
        }
        protected override void LayoutChanged() {
            this.view.LayoutChanged();
        }
    }
}
