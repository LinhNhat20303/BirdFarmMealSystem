﻿namespace DevExpress.DentalClinic
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem7 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.navigationGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.myProfileViewItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.schedulerViewItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.patientsViewItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.dashboardViewItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.usersViewItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.darkThemeBBI = new DevExpress.XtraBars.BarButtonItem();
            this.loginButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.breadCrumbEdit1 = new DevExpress.XtraEditors.BreadCrumbEdit();
            this.pnlNavigationBar = new DevExpress.XtraEditors.PanelControl();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadCrumbEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNavigationBar)).BeginInit();
            this.pnlNavigationBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationFrame
            // 
            this.navigationFrame.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 44);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.SelectedPage = null;
            this.navigationFrame.Size = new System.Drawing.Size(1666, 1016);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // accordionControl
            // 
            this.accordionControl.AllowItemSelection = true;
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.navigationGroup});
            this.accordionControl.Location = new System.Drawing.Point(0, 41);
            this.accordionControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            this.accordionControl.OptionsMinimizing.FooterHeight = 60;
            this.accordionControl.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl.Size = new System.Drawing.Size(88, 1060);
            this.accordionControl.TabIndex = 1;
            this.accordionControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // navigationGroup
            // 
            this.navigationGroup.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.myProfileViewItem,
            this.schedulerViewItem,
            this.patientsViewItem,
            this.dashboardViewItem,
            this.usersViewItem});
            this.navigationGroup.Expanded = true;
            this.navigationGroup.Name = "navigationGroup";
            this.navigationGroup.Text = "Navigation";
            this.navigationGroup.VisibleInFooter = false;
            // 
            // myProfileViewItem
            // 
            this.myProfileViewItem.Height = 60;
            this.myProfileViewItem.ImageOptions.SvgImage = global::DevExpress.DentalClinic.Properties.Resources.Login;
            this.myProfileViewItem.Name = "myProfileViewItem";
            this.myProfileViewItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            toolTipItem1.Text = "My Profile";
            superToolTip1.Items.Add(toolTipItem1);
            this.myProfileViewItem.SuperTip = superToolTip1;
            this.myProfileViewItem.Tag = "EmployeeView";
            // 
            // schedulerViewItem
            // 
            this.schedulerViewItem.Height = 60;
            this.schedulerViewItem.ImageOptions.SvgImage = global::DevExpress.DentalClinic.Properties.Resources.calendar;
            this.schedulerViewItem.Name = "schedulerViewItem";
            this.schedulerViewItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            toolTipItem2.Text = "Calendar";
            superToolTip2.Items.Add(toolTipItem2);
            this.schedulerViewItem.SuperTip = superToolTip2;
            this.schedulerViewItem.Tag = "SchedulerView";
            // 
            // patientsViewItem
            // 
            this.patientsViewItem.Height = 60;
            this.patientsViewItem.ImageOptions.SvgImage = global::DevExpress.DentalClinic.Properties.Resources.Patients;
            this.patientsViewItem.Name = "patientsViewItem";
            this.patientsViewItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            toolTipItem3.Text = "Patients";
            superToolTip3.Items.Add(toolTipItem3);
            this.patientsViewItem.SuperTip = superToolTip3;
            this.patientsViewItem.Tag = "PatientCollectionView";
            // 
            // dashboardViewItem
            // 
            this.dashboardViewItem.Height = 60;
            this.dashboardViewItem.ImageOptions.SvgImage = global::DevExpress.DentalClinic.Properties.Resources.Chart;
            this.dashboardViewItem.Name = "dashboardViewItem";
            this.dashboardViewItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            toolTipItem4.Text = "Analytics";
            superToolTip4.Items.Add(toolTipItem4);
            this.dashboardViewItem.SuperTip = superToolTip4;
            this.dashboardViewItem.Tag = "AnalyticsView";
            // 
            // usersViewItem
            // 
            this.usersViewItem.Height = 60;
            this.usersViewItem.ImageOptions.SvgImage = global::DevExpress.DentalClinic.Properties.Resources.people;
            this.usersViewItem.Name = "usersViewItem";
            this.usersViewItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            toolTipItem5.Text = "Employees";
            superToolTip5.Items.Add(toolTipItem5);
            this.usersViewItem.SuperTip = superToolTip5;
            this.usersViewItem.Tag = "UserCollectionView";
            // 
            // fluentDesignFormControl
            // 
            this.fluentDesignFormControl.FluentDesignForm = this;
            this.fluentDesignFormControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.darkThemeBBI,
            this.loginButtonItem});
            this.fluentDesignFormControl.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fluentDesignFormControl.Name = "fluentDesignFormControl";
            this.fluentDesignFormControl.Size = new System.Drawing.Size(1754, 41);
            this.fluentDesignFormControl.TabIndex = 2;
            this.fluentDesignFormControl.TabStop = false;
            this.fluentDesignFormControl.TitleItemLinks.Add(this.darkThemeBBI);
            this.fluentDesignFormControl.TitleItemLinks.Add(this.loginButtonItem);
            // 
            // darkThemeBBI
            // 
            this.darkThemeBBI.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.darkThemeBBI.Caption = "barButtonItem1";
            this.darkThemeBBI.Id = 0;
            this.darkThemeBBI.ImageOptions.SvgImage = global::DevExpress.DentalClinic.Properties.Resources.DarkTheme;
            this.darkThemeBBI.Name = "darkThemeBBI";
            toolTipItem6.Text = "Change theme";
            superToolTip6.Items.Add(toolTipItem6);
            this.darkThemeBBI.SuperTip = superToolTip6;
            // 
            // loginButtonItem
            // 
            this.loginButtonItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.loginButtonItem.Caption = "barButtonItem1";
            this.loginButtonItem.Id = 0;
            this.loginButtonItem.ImageOptions.SvgImage = global::DevExpress.DentalClinic.Properties.Resources.Lock;
            this.loginButtonItem.Name = "loginButtonItem";
            toolTipItem7.Text = "Change User";
            superToolTip7.Items.Add(toolTipItem7);
            this.loginButtonItem.SuperTip = superToolTip7;
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.DentalClinic.ViewModel.NavigationViewModel);
            // 
            // breadCrumbEdit1
            // 
            this.breadCrumbEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.breadCrumbEdit1.Location = new System.Drawing.Point(6, 6);
            this.breadCrumbEdit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.breadCrumbEdit1.Name = "breadCrumbEdit1";
            this.breadCrumbEdit1.Properties.AllowEdit = false;
            this.breadCrumbEdit1.Properties.AllowNodeDropDown = false;
            this.breadCrumbEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.breadCrumbEdit1.Properties.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.breadCrumbEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.breadCrumbEdit1.Properties.Appearance.Options.UseFont = true;
            this.breadCrumbEdit1.Properties.AutoHeight = false;
            this.breadCrumbEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.breadCrumbEdit1.Properties.ShowPathSuggestions = false;
            this.breadCrumbEdit1.Size = new System.Drawing.Size(1654, 32);
            this.breadCrumbEdit1.TabIndex = 3;
            // 
            // pnlNavigationBar
            // 
            this.pnlNavigationBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlNavigationBar.Controls.Add(this.breadCrumbEdit1);
            this.pnlNavigationBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavigationBar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigationBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNavigationBar.Name = "pnlNavigationBar";
            this.pnlNavigationBar.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlNavigationBar.Size = new System.Drawing.Size(1666, 44);
            this.pnlNavigationBar.TabIndex = 4;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mainPanel.Controls.Add(this.navigationFrame);
            this.mainPanel.Controls.Add(this.pnlNavigationBar);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(88, 41);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1666, 1060);
            this.mainPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1754, 1101);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.accordionControl);
            this.Controls.Add(this.fluentDesignFormControl);
            this.FluentDesignFormControl = this.fluentDesignFormControl;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Happy Paws";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadCrumbEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNavigationBar)).EndInit();
            this.pnlNavigationBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XtraBars.Navigation.NavigationFrame navigationFrame;
        private XtraBars.Navigation.AccordionControl accordionControl;
        private Utils.MVVM.MVVMContext mvvmContext;
        private XtraBars.Navigation.AccordionControlElement schedulerViewItem;
        private XtraBars.Navigation.AccordionControlElement patientsViewItem;
        private XtraBars.Navigation.AccordionControlElement dashboardViewItem;
        private XtraBars.Navigation.AccordionControlElement navigationGroup;
        private XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl;
        private XtraEditors.BreadCrumbEdit breadCrumbEdit1;
        private XtraBars.Navigation.AccordionControlElement myProfileViewItem;
        private XtraEditors.PanelControl pnlNavigationBar;
        private XtraEditors.PanelControl mainPanel;
        private XtraBars.Navigation.AccordionControlElement usersViewItem;
        private XtraBars.BarButtonItem darkThemeBBI;
        private XtraBars.BarButtonItem loginButtonItem;
    }
}

