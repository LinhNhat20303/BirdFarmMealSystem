namespace Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox5.Parent = pictureBox2;
            pictureBox6.Parent = pictureBox2;
            pictureBox7.Parent = pictureBox2;
            pictureBox3.Parent = pictureBox2;
            pictureBox4.Parent = pictureBox1;
            label1.Parent = pictureBox2;
            label2.Parent = pictureBox2;
            label3.Parent = pictureBox2;



            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}