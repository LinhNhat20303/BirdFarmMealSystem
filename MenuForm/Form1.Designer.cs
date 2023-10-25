namespace MenuForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            btnLogout = new Button();
            btnDashboard = new Button();
            icons = new ImageList(components);
            btnPlan = new Button();
            btnCage = new Button();
            btnBird = new Button();
            panelLogo = new Panel();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelDesktop = new Panel();
            btnCloseChildForm = new Button();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Moccasin;
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(btnPlan);
            panelMenu.Controls.Add(btnCage);
            panelMenu.Controls.Add(btnBird);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(228, 601);
            panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.FromArgb(131, 139, 131);
            btnLogout.Location = new Point(0, 535);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(228, 66);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.FromArgb(131, 139, 131);
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.ImageIndex = 2;
            btnDashboard.ImageList = icons;
            btnDashboard.Location = new Point(0, 423);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(228, 66);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "     Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // icons
            // 
            icons.ColorDepth = ColorDepth.Depth8Bit;
            icons.ImageStream = (ImageListStreamer)resources.GetObject("icons.ImageStream");
            icons.TransparentColor = Color.Transparent;
            icons.Images.SetKeyName(0, "bird.png");
            icons.Images.SetKeyName(1, "cage.png");
            icons.Images.SetKeyName(2, "dashboard.png");
            icons.Images.SetKeyName(3, "plan.png");
            icons.Images.SetKeyName(4, "exit.png");
            icons.Images.SetKeyName(5, "logo.png");
            // 
            // btnPlan
            // 
            btnPlan.Dock = DockStyle.Top;
            btnPlan.FlatAppearance.BorderSize = 0;
            btnPlan.FlatStyle = FlatStyle.Flat;
            btnPlan.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlan.ForeColor = Color.FromArgb(131, 139, 131);
            btnPlan.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlan.ImageIndex = 3;
            btnPlan.ImageList = icons;
            btnPlan.Location = new Point(0, 357);
            btnPlan.Name = "btnPlan";
            btnPlan.Padding = new Padding(10, 0, 0, 0);
            btnPlan.Size = new Size(228, 66);
            btnPlan.TabIndex = 4;
            btnPlan.Text = "Plans";
            btnPlan.UseVisualStyleBackColor = true;
            btnPlan.Click += btnPlan_Click;
            // 
            // btnCage
            // 
            btnCage.Dock = DockStyle.Top;
            btnCage.FlatAppearance.BorderSize = 0;
            btnCage.FlatStyle = FlatStyle.Flat;
            btnCage.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCage.ForeColor = Color.FromArgb(131, 139, 131);
            btnCage.ImageAlign = ContentAlignment.MiddleLeft;
            btnCage.ImageIndex = 1;
            btnCage.ImageList = icons;
            btnCage.Location = new Point(0, 291);
            btnCage.Name = "btnCage";
            btnCage.Padding = new Padding(10, 0, 0, 0);
            btnCage.Size = new Size(228, 66);
            btnCage.TabIndex = 3;
            btnCage.Text = "Cages";
            btnCage.UseVisualStyleBackColor = true;
            btnCage.Click += btnCage_Click;
            // 
            // btnBird
            // 
            btnBird.Dock = DockStyle.Top;
            btnBird.FlatAppearance.BorderSize = 0;
            btnBird.FlatStyle = FlatStyle.Flat;
            btnBird.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBird.ForeColor = Color.FromArgb(131, 139, 131);
            btnBird.ImageAlign = ContentAlignment.MiddleLeft;
            btnBird.ImageIndex = 0;
            btnBird.ImageList = icons;
            btnBird.Location = new Point(0, 225);
            btnBird.Name = "btnBird";
            btnBird.Padding = new Padding(10, 0, 0, 0);
            btnBird.Size = new Size(228, 66);
            btnBird.TabIndex = 2;
            btnBird.Text = "Birds";
            btnBird.UseVisualStyleBackColor = true;
            btnBird.Click += btnBird_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Linen;
            panelLogo.BackgroundImage = Properties.Resources.logo;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(228, 225);
            panelLogo.TabIndex = 2;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.BlanchedAlmond;
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(228, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1087, 71);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Peru;
            lblTitle.Location = new Point(485, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(67, 22);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(228, 71);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1087, 530);
            panelDesktop.TabIndex = 2;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.ImageIndex = 4;
            btnCloseChildForm.ImageList = icons;
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(112, 71);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 601);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelTitleBar;
        private Panel panelLogo;
        private Button btnLogout;
        private Button btnDashboard;
        private Button btnPlan;
        private Button btnCage;
        private Button btnBird;
        private ImageList icons;
        private Panel panelDesktop;
        private Label lblTitle;
        private Button btnCloseChildForm;
    }
}