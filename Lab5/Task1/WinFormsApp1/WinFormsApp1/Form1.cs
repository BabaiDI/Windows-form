using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Tools curentTool;

        public enum Tools
        {
            PEN = 1, TEXT, LINE, ELLIPSE, NULL = 0
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem statusStrip = statusStrip1.Items[0];
            switch (e.ClickedItem.Name)
            {
                case "toolStripButtonPen":
                    curentTool = Tools.PEN;
                    statusStrip.Text = "Выбран карандаш";
                    break;
                case "toolStripButtonText":
                    curentTool = Tools.TEXT;
                    statusStrip.Text = "Создание надписей";
                    break;
                case "toolStripButtonLine":
                    curentTool = Tools.LINE;
                    statusStrip.Text = "Рисование линий";
                    break;
                case "toolStripButtonEllipse":
                    curentTool = Tools.ELLIPSE;
                    statusStrip.Text = "Рисование эллипса";
                    break;
            }
            SetToolStripButtonsPushedState();
        }

        private void SetToolStripButtonsPushedState()
        {
            foreach (ToolStripButton btnItem in toolStrip1.Items)
            {
                btnItem.Checked = (btnItem.Tag.ToString() == curentTool.ToString());
            }

            foreach (ToolStripMenuItem item in MenuItem.DropDownItems)
            {
                item.Checked = (item.Tag.ToString() == curentTool.ToString());
            }
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            ToolStripItem statusStrip = statusStrip1.Items[0];
            switch (item.Name)
            {
                case "menuItemPen":
                    curentTool = Tools.PEN;
                    statusStrip.Text = "Выбран карандаш";
                    break;
                case "menuItemText":
                    curentTool = Tools.TEXT;
                    statusStrip.Text = "Создание надписей";
                    break;
                case "menuItemLine":
                    curentTool = Tools.LINE;
                    statusStrip.Text = "Рисование линий";
                    break;
                case "menuItemEIIipse":
                    curentTool = Tools.ELLIPSE;
                    statusStrip.Text = "Рисование эллипса";
                    break;
            }
            SetToolStripButtonsPushedState();
        }
    }
}