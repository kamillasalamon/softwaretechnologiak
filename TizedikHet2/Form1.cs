namespace TizedikHet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 uc = new UserControl1();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl2 uc = new UserControl2();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControl3 uc = new UserControl3();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserControl4 uc = new UserControl4();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}