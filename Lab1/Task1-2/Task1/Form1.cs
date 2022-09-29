namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rn = new();
            this.BackColor = Color.FromArgb(rn.Next(100, 256), rn.Next(100, 256), rn.Next(100, 256));
        }
    }
}