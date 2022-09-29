namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string checkedItem in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(checkedItem);
            }
        }
    }
}