namespace MenuForm
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(238, 232, 205);
                    currentButton.ForeColor = Color.FromArgb(131, 139, 131);
                    currentButton.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
                    //panelTitleBar.BackColor = 
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(255, 228, 181);
                    previousBtn.ForeColor = Color.FromArgb(205, 183, 181);
                    previousBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;

            //foreach (Control item in childForm.Controls)
            //{
            //    item.Anchor = AnchorStyles.None;
            //}

            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnBird_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.Bird(), sender);
        }

        private void btnCage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.Cage(), sender);
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.Plan(), sender);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard.Form1(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm!= null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
    }
}