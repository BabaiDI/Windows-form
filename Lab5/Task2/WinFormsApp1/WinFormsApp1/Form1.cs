using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        btnColor color;

        private enum btnColor{
            Red = 1, Yellow, Blue
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void changeColor()
        {
            switch (color)
            {
                case btnColor.Yellow:
                    BackColor = Color.Yellow;
                    break;
                case btnColor.Red:
                    BackColor = Color.Red;
                    break;
                case btnColor.Blue:
                    BackColor = Color.Blue;
                    break;
            }

            foreach (ToolStripMenuItem button in ColorMenuItem.DropDownItems)
            {
                button.Checked = (button.Name == color.ToString()+"MenuItem");
            }

            foreach (ToolStripButton button in toolStrip1.Items)
            {
                button.Checked = (button.Name == color.ToString()+"Button");
            }

            Image img = Image.FromFile("D:\\Work\\WIndows Form\\Lab5\\Task2\\WinFormsApp1\\" + color.ToString()+"icon.ico");
            toolStripStatusLabel2.Image = img;
            toolStripStatusLabel2.Text = "";
            toolStripStatusLabel1.Text = color.ToString();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            switch (item.Name)
            {
                case ("BlueMenuItem"):
                    color = btnColor.Blue;
                    break;
                case ("YellowMenuItem"):
                    color = btnColor.Yellow;
                    break;
                case ("RedMenuItem"):
                    color = btnColor.Red;
                    break;
            }
            changeColor();
        }

        private void toolStrip_ItemClicked(object sender, EventArgs e)
        {
            ToolStripItem item = (ToolStripItem)sender;
            switch (item.Name)
            {
                case ("BlueButton"):
                    color = btnColor.Blue;
                    break;
                case ("YellowButton"):
                    color = btnColor.Yellow;
                    break;
                case ("RedButton"):
                    color = btnColor.Red;
                    break;
            }
            changeColor();
        }
    }
}