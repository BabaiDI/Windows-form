using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            Text = comboBox1.SelectedItem.ToString();
        }

        private void radioButtons_ChekedChanged(object sender, EventArgs e)
        {
            RadioButton[] radiobuttons = new RadioButton[]
            {
                radioButton1,
                radioButton2,
                radioButton3,
                radioButton4
            };

            foreach (RadioButton button in radiobuttons)
            {
                if (button.Checked)
                {
                    if (BackgroundImage != null)
                        BackgroundImage.Dispose();
                    switch (button.Tag)
                    {
                        case ("0"):
                            BackgroundImage = Image.FromFile("D:\\Work\\WIndows Form\\Lab2\\Task2\\WinFormsApp1\\WinFormsApp1\\Theme\\blurred-colorful.jpg");
                            break;
                        case ("1"):
                            BackgroundImage = Image.FromFile("D:\\Work\\WIndows Form\\Lab2\\Task2\\WinFormsApp1\\WinFormsApp1\\Theme\\vaporwave.jpg");
                            break;
                        case ("2"):
                            BackgroundImage = Image.FromFile("D:\\Work\\WIndows Form\\Lab2\\Task2\\WinFormsApp1\\WinFormsApp1\\Theme\\neon-lights.jpg");
                            break;
                        case ("3"):
                            BackgroundImage = Image.FromFile("D:\\Work\\WIndows Form\\Lab2\\Task2\\WinFormsApp1\\WinFormsApp1\\Theme\\sakura.jpg");
                            break;

                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = comboBox1.SelectedItem.ToString();
        }

        private void width_ValueChanged(object sender, EventArgs e)
        {
            Width = (int)width.Value;
        }

        private void height_ValueChanged(object sender, EventArgs e)
        {
            Height = (int)height.Value;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                ChangeFonts(Controls);
            }
        }

        private void ChangeFonts(Control.ControlCollection Control)
        {
            foreach (Control ctrl in Control)
            {
                if (ctrl.Controls != null)
                    ChangeFonts(ctrl.Controls);

                ctrl.Font = new Font(listBox1.SelectedItem.ToString(), 14, FontStyle.Regular);
            }
        }
    }
}