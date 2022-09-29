namespace MDIBasic
{
    public partial class frmContainer : Form
    {
        private int nextFormNumber = 2;

        public frmContainer()
        {
            InitializeComponent();
            // �������� ������ ���������� �������� �����
            MDIBasic.frmChild child = new MDIBasic.frmChild(this, "�������� 1");
            // ����� ��������� �����
            child.Show();
        }

        private void MenuItemNewWindow_Click(object sender, EventArgs e)
        {
            // �������� ������ ���������� �������� �����
            frmChild newChild = new frmChild(this, "��������" + nextFormNumber++);
            // ����� ��������� �����
            newChild.Show();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemTile_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MenuItemCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MenuItemClose_Click(object sender, EventArgs e)
        {// ����������� ��������� ��������� MDI-����
            frmChild frm = (frmChild)this.ActiveMdiChild;
            if (frm != null) // ����� ��� ��� ������������ �������,
                             // ���������� ��������� � ���, ��� �� ��������
            {// �������� ����
                frm.Close();
            }
        }

    }
}