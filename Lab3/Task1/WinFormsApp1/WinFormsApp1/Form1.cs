namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.LargeImageList = imageList1;
            treeView1.ImageList = imageList1;
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            // ��������� ����� ������� � ������
            listView1.Items.Add(textBox1.Text, 0);
        }

        private void ButtonTree_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            // ���� ����������� ���� ���
            if (node == null)
            {   // ��������� ����� �������
                // � ������ ��������� ������
                TreeNode newNode = new TreeNode();
                newNode.Text = textBox1.Text;
                newNode.ImageIndex = 0;
                treeView1.Nodes.Add(newNode);

            }
            // ���� ������� ���������� ����
            else
            {   // ��������� ����� �������
                // ��� ��������� � ���������� ����
                TreeNode newNode = new TreeNode();
                newNode.Text = textBox1.Text;
                newNode.ImageIndex = 0;
                node.Nodes.Add(newNode);
            }
        }

        private void DelListButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }
        }

        private void DelTreeButton_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }
    }
}