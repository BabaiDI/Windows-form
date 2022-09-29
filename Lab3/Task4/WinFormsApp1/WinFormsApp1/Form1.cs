namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }
    }
}