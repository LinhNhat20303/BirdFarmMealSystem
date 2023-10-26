using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Helpers;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos.CodeExamples {
    [CodeExampleClass("Colors & Shadows", "Css.cs")]
    public static class HtmlColorsAndShadows {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            SvgImageCollection images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("color")]
        [CssFile("Css.Color"), HtmlFile("Css.Color")]
        public static void Color(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("Color.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("Color.css");
        }
        [CodeExampleCase("background-color")]
        [CssFile("Css.BackgroundColor"), HtmlFile("Css.BackgroundColor")]
        public static void BackgroundColor(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BackgroundColor.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BackgroundColor.css");
        }
        [CodeExampleCase("opacity")]
        [CssFile("Css.Opacity"), HtmlFile("Css.Opacity")]
        public static void Opacity(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("Opacity.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("Opacity.css");
        }
        [CodeExampleCase("box-shadow")]
        [CssFile("Css.BoxShadow"), HtmlFile("Css.BoxShadow")]
        public static void BoxShadow(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BoxShadow.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BoxShadow.css");
        }
    }
    [CodeExampleClass("Margin", "Css.cs")]
    public static class HtmlMargin {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            SvgImageCollection images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("margin")]
        [CssFile("Css.Margin"), HtmlFile("Css.Margin")]
        public static void Margin(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("Margin.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("Margin.css");
        }
        [CodeExampleCase("margin-top")]
        [CssFile("Css.MarginTop"), HtmlFile("Css.MarginTop")]
        public static void MarginTop(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("MarginTop.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("MarginTop.css");
        }
        [CodeExampleCase("margin-bottom")]
        [CssFile("Css.MarginBottom"), HtmlFile("Css.MarginBottom")]
        public static void MarginBottom(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("MarginBottom.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("MarginBottom.css");
        }
        [CodeExampleCase("margin-left")]
        [CssFile("Css.MarginLeft"), HtmlFile("Css.MarginLeft")]
        public static void MarginLeft(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("MarginLeft.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("MarginLeft.css");
        }
        [CodeExampleCase("margin-right")]
        [CssFile("Css.MarginRight"), HtmlFile("Css.MarginRight")]
        public static void MarginRight(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("MarginRight.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("MarginRight.css");
        }
    }
    [CodeExampleClass("Padding", "Css.cs")]
    public static class HtmlPadding {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            SvgImageCollection images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("padding")]
        [CssFile("Css.Paddings"), HtmlFile("Css.Padding")]
        public static void Padding(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("Padding.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("Paddings.css");
        }
        [CodeExampleCase("padding-left")]
        [CssFile("Css.PaddingLeft"), HtmlFile("Css.PaddingLeft")]
        public static void PaddingLeft(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("PaddingLeft.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("PaddingLeft.css");
        }
        [CodeExampleCase("padding-right")]
        [CssFile("Css.PaddingRight"), HtmlFile("Css.PaddingRight")]
        public static void PaddingRight(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("PaddingRight.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("PaddingRight.css");
        }
        [CodeExampleCase("padding-top")]
        [CssFile("Css.PaddingTop"), HtmlFile("Css.PaddingTop")]
        public static void PaddingTop(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("PaddingTop.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("PaddingTop.css");
        }
        [CodeExampleCase("padding-bottom")]
        [CssFile("Css.PaddingBottom"), HtmlFile("Css.PaddingBottom")]
        public static void PaddingBottom(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("PaddingBottom.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("PaddingBottom.css");
        }
    }
    [CodeExampleClass("Border", "Css.cs")]
    public static class HtmlBorder {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            SvgImageCollection images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("border")]
        [CssFile("Css.Borders"), HtmlFile("Css.Borders")]
        public static void Border(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("Borders.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("Borders.css");
        }
        [CodeExampleCase("border-color")]
        [CssFile("Css.BorderColor"), HtmlFile("Css.BorderColor")]
        public static void BorderColor(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderColor.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderColor.css");
        }
        [CodeExampleCase("border-style")]
        [CssFile("Css.BorderStyle"), HtmlFile("Css.BorderStyle")]
        public static void BorderStyle(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderStyle.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderStyle.css");
        }
        [CodeExampleCase("border-width")]
        [CssFile("Css.BorderWidth"), HtmlFile("Css.BorderWidth")]
        public static void BorderWidth(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderWidth.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderWidth.css");
        }
        [CodeExampleCase("border-radius")]
        [CssFile("Css.BorderRadius"), HtmlFile("Css.BorderRadius")]
        public static void BorderRadius(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderRadius.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderRadius.css");
        }
        [CodeExampleCase("border-spacing")]
        [CssFile("Css.BorderSpacing"), HtmlFile("Css.BorderSpacing")]
        public static void BorderSpacing(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderSpacing.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderSpacing.css");
        }
        [CodeExampleCase("border-top")]
        [CssFile("Css.BorderTop"), HtmlFile("Css.BorderTop")]
        public static void BorderTop(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderTop.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderTop.css");
        }
        [CodeExampleCase("border-top-color")]
        [CssFile("Css.BorderTopColor"), HtmlFile("Css.BorderTopColor")]
        public static void BorderTopColor(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderTopColor.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderTopColor.css");
        }
        [CodeExampleCase("border-top-style")]
        [CssFile("Css.BorderTopStyle"), HtmlFile("Css.BorderTopStyle")]
        public static void BorderTopStyle(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderTopStyle.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderTopStyle.css");
        }
        [CodeExampleCase("border-top-width")]
        [CssFile("Css.BorderTopWidth"), HtmlFile("Css.BorderTopWidth")]
        public static void BorderTopWidth(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderTopWidth.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderTopWidth.css");
        }
        [CodeExampleCase("border-bottom")]
        [CssFile("Css.BorderBottom"), HtmlFile("Css.BorderBottom")]
        public static void BorderBottom(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderBottom.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderBottom.css");
        }
        [CodeExampleCase("border-bottom-color")]
        [CssFile("Css.BorderBottomColor"), HtmlFile("Css.BorderBottomColor")]
        public static void BorderBottomColor(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderBottomColor.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderBottomColor.css");
        }
        [CodeExampleCase("border-bottom-style")]
        [CssFile("Css.BorderBottomStyle"), HtmlFile("Css.BorderBottomStyle")]
        public static void BorderBottomStyle(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderBottomStyle.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderBottomStyle.css");
        }
        [CodeExampleCase("border-bottom-width")]
        [CssFile("Css.BorderBottomWidth"), HtmlFile("Css.BorderBottomWidth")]
        public static void BorderBottomWidth(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderBottomWidth.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderBottomWidth.css");
        }
        [CodeExampleCase("border-left")]
        [CssFile("Css.BorderLeft"), HtmlFile("Css.BorderLeft")]
        public static void BorderLeft(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderLeft.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderLeft.css");
        }
        [CodeExampleCase("border-left-color")]
        [CssFile("Css.BorderLeftColor"), HtmlFile("Css.BorderLeftColor")]
        public static void BorderLeftColor(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderLeftColor.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderLeftColor.css");
        }
        [CodeExampleCase("border-left-style")]
        [CssFile("Css.BorderLeftStyle"), HtmlFile("Css.BorderLeftStyle")]
        public static void BorderLeftStyle(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderLeftStyle.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderLeftStyle.css");
        }
        [CodeExampleCase("border-left-width")]
        [CssFile("Css.BorderLeftWidth"), HtmlFile("Css.BorderLeftWidth")]
        public static void BorderLeftWidth(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderLeftWidth.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderLeftWidth.css");
        }
        [CodeExampleCase("border-right")]
        [CssFile("Css.BorderRight"), HtmlFile("Css.BorderRight")]
        public static void BorderRight(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderRight.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderRight.css");
        }
        [CodeExampleCase("border-right-color")]
        [CssFile("Css.BorderRightColor"), HtmlFile("Css.BorderRightColor")]
        public static void BorderRightColor(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderRightColor.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderRightColor.css");
        }
        [CodeExampleCase("border-right-style")]
        [CssFile("Css.BorderRightStyle"), HtmlFile("Css.BorderRightStyle")]
        public static void BorderRightStyle(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderRightStyle.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderRightStyle.css");
        }
        [CodeExampleCase("border-right-width")]
        [CssFile("Css.BorderRightWidth"), HtmlFile("Css.BorderRightWidth")]
        public static void BorderRightWidth(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderRightWidth.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderRightWidth.css");
        }
        [CodeExampleCase("border-top-left-radius")]
        [CssFile("Css.BorderTopLeftRadius"), HtmlFile("Css.BorderTopLeftRadius")]
        public static void BorderTopLeftRadius(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderTopLeftRadius.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderTopLeftRadius.css");
        }
        [CodeExampleCase("border-top-right-radius")]
        [CssFile("Css.BorderTopRightRadius"), HtmlFile("Css.BorderTopRightRadius")]
        public static void BorderTopRightRadius(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderTopRightRadius.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderTopRightRadius.css");
        }
        [CodeExampleCase("border-bottom-left-radius")]
        [CssFile("Css.BorderBottomLeftRadius"), HtmlFile("Css.BorderBottomLeftRadius")]
        public static void BorderBottomLeftRadius(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderBottomLeftRadius.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderBottomLeftRadius.css");
        }
        [CodeExampleCase("border-bottom-right-radius")]
        [CssFile("Css.BorderBottomRightRadius"), HtmlFile("Css.BorderBottomRightRadius")]
        public static void BorderBottomRightRadius(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("BorderBottomRightRadius.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("BorderBottomRightRadius.css");
        }
    }

    [CodeExampleClass("Size", "Css.cs")]
    public static class HtmlSize {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            SvgImageCollection images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("width")]
        [CssFile("Css.Width"), HtmlFile("Css.Width")]
        public static void Width(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("Width.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("Width.css");
        }
        [CodeExampleCase("height")]
        [CssFile("Css.Height"), HtmlFile("Css.Height")]
        public static void Height(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("Height.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("Height.css");
        }
        [CodeExampleCase("max-width")]
        [CssFile("Css.MaxWidth"), HtmlFile("Css.MaxWidth")]
        public static void MaxWidth(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("MaxWidth.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("MaxWidth.css");
        }
        [CodeExampleCase("max-height")]
        [CssFile("Css.MaxHeight"), HtmlFile("Css.MaxHeight")]
        public static void MaxHeight(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("MaxHeight.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("MaxHeight.css");
        }
        [CodeExampleCase("min-height")]
        [CssFile("Css.MinHeight"), HtmlFile("Css.MinHeight")]
        public static void MinHeight(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("MinHeight.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("MinHeight.css");
        }
        [CodeExampleCase("min-width")]
        [CssFile("Css.MinWidth"), HtmlFile("Css.MinWidth")]
        public static void MinWidth(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("MinWidth.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("MinWidth.css");
        }
        [CodeExampleCase("overflow")]
        [CssFile("Css.Overflow"), HtmlFile("Css.Overflow")]
        public static void Overflow(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("Overflow.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("Overflow.css");
        }
    }
    [CodeExampleClass("Font", "Css.cs")]
    public static class HtmlFont {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            SvgImageCollection images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("font")]
        [CssFile("Css.Font"), HtmlFile("Css.Font")]
        public static void Font(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("Font.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("Font.css");
        }
        [CodeExampleCase("font-family")]
        [CssFile("Css.FontFamily"), HtmlFile("Css.FontFamily")]
        public static void FontFamily(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("FontFamily.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("FontFamily.css");
        }
        [CodeExampleCase("font-size")]
        [CssFile("Css.FontSize"), HtmlFile("Css.FontSize")]
        public static void FontSize(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("FontSize.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("FontSize.css");
        }
        [CodeExampleCase("font-style")]
        [CssFile("Css.FontStyle"), HtmlFile("Css.FontStyle")]
        public static void FontStyle(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("FontStyle.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("FontStyle.css");
        }
        [CodeExampleCase("font-weight")]
        [CssFile("Css.FontWeight"), HtmlFile("Css.FontWeight")]
        public static void FontWeight(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("FontWeight.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("FontWeight.css");
        }
    }
    [CodeExampleClass("Text", "Css.cs")]
    public static class HtmlText {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            SvgImageCollection images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("text-align")]
        [CssFile("Css.TextAlign"), HtmlFile("Css.TextAlign")]
        public static void TextAlign(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("TextAlign.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("TextAlign.css");
        }
        [CodeExampleCase("white-space")]
        [CssFile("Css.WhiteSpace"), HtmlFile("Css.WhiteSpace")]
        public static void WhiteSpace(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("WhiteSpace.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("WhiteSpace.css");
        }
        [CodeExampleCase("text-decoration-line")]
        [CssFile("Css.TextDecorationLine"), HtmlFile("Css.TextDecorationLine")]
        public static void TextDecorationLine(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("TextDecorationLine.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("TextDecorationLine.css");
        }
        [CodeExampleCase("text-overflow")]
        [CssFile("Css.TextOverflow"), HtmlFile("Css.TextOverflow")]
        public static void TextOverflow(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("TextOverflow.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("TextOverflow.css");
        }
    }
    [CodeExampleClass("List", "Css.cs")]
    public static class HtmlLists {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            SvgImageCollection images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("list-style-position")]
        [CssFile("Css.ListStylePosition"), HtmlFile("Css.ListStylePosition")]
        public static void ListStylePosition(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("ListStylePosition.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("ListStylePosition.css");
        }
        [CodeExampleCase("list-style-type")]
        [CssFile("Css.ListStyleType"), HtmlFile("Css.ListStyleType")]
        public static void ListStyleType(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("ListStyleType.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("ListStyleType.css");
        }
    }
    [CodeExampleClass("Image", "Css.cs")]
    public static class HtmlImage {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            ImageCollection images = new ImageCollection();
            var assembly = typeof(DevExpress.HTML.Demos.CodeExamples.HtmlImage).Assembly;
            var imageResName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.EndsWith("auto.png"));
            var stream = assembly.GetManifestResourceStream(imageResName);
            var image = System.Drawing.Image.FromStream(stream);
            images.ImageSize = new System.Drawing.Size(image.Width,image.Height);
            images.AddImage(image, "image");
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("object-fit")]
        [CssFile("Css.ObjectFit"), HtmlFile("Css.ObjectFit")]
        public static void ObjectFit(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("ObjectFit.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("ObjectFit.css");
        }
    }
    [CodeExampleClass("Layout", "Css.cs")]
    public static class HtmlLayout {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            SvgImageCollection images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("display")]
        [CssFile("Css.Display"), HtmlFile("Css.Display")]
        public static void Display(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("Display.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("Display.css");
        }
        [CodeExampleCase("visibility")]
        [CssFile("Css.Visibility"), HtmlFile("Css.Visibility")]
        public static void Visibility(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("Visibility.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("Visibility.css");
        }
    }
    [CodeExampleClass("Flex", "Css.cs")]
    public static class HtmlFlex {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            SvgImageCollection images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleGroupName("Container")]
        [CodeExampleCase("flex-direction")]
        [CssFile("Css.FlexDirection"), HtmlFile("Css.FlexDirection")]
        public static void FlexDirection(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("FlexDirection.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("FlexDirection.css");
        }
        [CodeExampleGroupName("Container")]
        [CodeExampleCase("flex-wrap")]
        [CssFile("Css.FlexWrap"), HtmlFile("Css.FlexWrap")]
        public static void FlexWrap(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("FlexWrap.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("FlexWrap.css");
        }
        [CodeExampleGroupName("Container")]
        [CodeExampleCase("justify-content")]
        [CssFile("Css.JustifyContent"), HtmlFile("Css.JustifyContent")]
        public static void JustifyContent(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("JustifyContent.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("JustifyContent.css");
        }
        [CodeExampleGroupName("Container")]
        [CodeExampleCase("align-items")]
        [CssFile("Css.AlignItems"), HtmlFile("Css.AlignItems")]
        public static void AlignItems(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("AlignItems.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("AlignItems.css");
        }
        [CodeExampleGroupName("Container")]
        [CodeExampleCase("align-content")]
        [CssFile("Css.AlignContent"), HtmlFile("Css.AlignContent")]
        public static void AlignContent(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("AlignContent.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("AlignContent.css");
        }
        [CodeExampleGroupName("Items")]
        [CodeExampleCase("order")]
        [CssFile("Css.Order"), HtmlFile("Css.Order")]
        public static void Order(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("Order.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("Order.css");
        }
        [CodeExampleGroupName("Items")]
        [CodeExampleCase("flex-grow")]
        [CssFile("Css.FlexGrow"), HtmlFile("Css.FlexGrow")]
        public static void FlexGrow(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("FlexGrow.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("FlexGrow.css");
        }
        [CodeExampleGroupName("Items")]
        [CodeExampleCase("flex-shrink")]
        [CssFile("Css.FlexShrink"), HtmlFile("Css.FlexShrink")]
        public static void FlexShrink(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("FlexShrink.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("FlexShrink.css");
        }
        [CodeExampleGroupName("Items")]
        [CodeExampleCase("flex-basis")]
        [CssFile("Css.FlexBasis"), HtmlFile("Css.FlexBasis")]
        public static void FlexBasis(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("FlexBasis.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("FlexBasis.css");
        }
        [CodeExampleGroupName("Items")]
        [CodeExampleCase("align-self")]
        [CssFile("Css.AlignSelf"), HtmlFile("Css.AlignSelf")]
        public static void AlignSelf(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Template = Loader.Load("AlignSelf.html");
            htmlContentControl.HtmlTemplate.Styles = Loader.Load("AlignSelf.css");
        }
    }
}
