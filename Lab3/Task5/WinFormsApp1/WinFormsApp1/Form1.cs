namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool filledRichTextBoxAdress = false,
             filledTextBoxName = false;

        public Form1()
        {
            InitializeComponent();
            radioButtonFemale.Checked = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = $"��� = ���� ���\n" +
                                $"����� = ��� �����\n" +
                                $"�������� = �������� ���� ��������� ������������\n" +
                                $"��� = �������� ��� ���\n" +
                                $"������� = ��� �������\n";
    }

        private void printResult()
        {
            richTextBox2.Text = $"���: {textBoxName.Text}\n" +
                                $"�����: {richTextBoxAdress.Text}\n" +
                                $"��������:{(checkBoxProgrammist.Checked?"":" ��") + " ����������"}\n" +
                                $"���: {(radioButtonFemale.Checked ? "�������" : "�������")}\n" +
                                $"�������: {numericUpDownAge.Value}\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printResult();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.TextLength > 0)
            {
                foreach (char latter in textBoxName.Text)
                {
                    if (latter != ' ')
                    {
                        filledTextBoxName = true;
                        break;
                    }

                    filledTextBoxName = false;
                }
            }
            else
            {
                filledTextBoxName = false;
            }

            enableOKButton();
        }

        private void richTextBoxAdress_TextChanged(object sender, EventArgs e)
        {
            if (richTextBoxAdress.TextLength > 0)
            {
                foreach (char latter in richTextBoxAdress.Text)
                {
                    if (latter != ' ')
                    {
                        filledRichTextBoxAdress = true;
                        break;
                    }

                    filledRichTextBoxAdress = false;
                }
            }
            else
            {
                filledRichTextBoxAdress = false;
            }

            enableOKButton();
        }

        private void enableOKButton()
        {
            button1.Enabled = (filledRichTextBoxAdress && filledTextBoxName);
        }
    }
}