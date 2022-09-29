using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItemAdd_Click(object sender, System.EventArgs e)
        {   
            MessageBox.Show("Добавление");
        }
        private void menuItemDel_Click(object sender, System.EventArgs e)
        {   
            MessageBox.Show("Удаление");
        }

        private void menuItemMove_Click(object sender, System.EventArgs e)
        {   
            MessageBox.Show("Перемещение");
        }

        private void сообщение1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string message = item.Text;
            MessageBox.Show(message);
        }

        private void menuItemNone_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string text = item.Text;

            switch (text)
            {
                case "Пусто":
                    trackBar1.TickStyle = TickStyle.None;
                    break;
                case "Сверху-Слева":
                    trackBar1.TickStyle = TickStyle.TopLeft;
                    break;
                case "Снизу-Справа":
                    trackBar1.TickStyle = TickStyle.BottomRight;
                    break;
                case "С обеих сторон":
                    trackBar1.TickStyle = TickStyle.Both;
                    break;
            }

            foreach (ToolStripMenuItem item1 in menuItemTrackBar.DropDownItems)
            {
                if (item1.Text == text)
                    item1.Checked = true;
                else
                    item1.Checked = false;
            }
            foreach (ToolStripMenuItem item1 in StripMenuBarStyle.DropDownItems)
            {
                if (item1.Text == text)
                    item1.Checked = true;
                else
                    item1.Checked = false;
            }
        }

        private void OrientationMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string text = item.Text;

            switch (text)
            {
                case "Вертикальная":
                    trackBar1.Orientation = Orientation.Vertical;
                    break;
                case "Горизонтальная":
                    trackBar1.Orientation = Orientation.Horizontal;
                    break;
            }

            foreach (ToolStripMenuItem item1 in menuItemTrackBarOrientation.DropDownItems)
            {
                if (item1.Text == text)
                    item1.Checked = true;
                else
                    item1.Checked = false;
            }
            foreach (ToolStripMenuItem item1 in orientationStripMenu.DropDownItems)
            {
                if (item1.Text == text)
                    item1.Checked = true;
                else
                    item1.Checked = false;
            }
        }
    }
}