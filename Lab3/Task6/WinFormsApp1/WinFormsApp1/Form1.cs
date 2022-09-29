namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog openedFile = new()
            {
                Filter = "* | *.rtf"
            };
            if (openedFile.ShowDialog() == DialogResult.OK)
            {
                using StreamReader sr = new(openedFile.FileName);
                textEditor.Rtf = sr.ReadToEnd();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new()
            {
                Filter = "* | *.rtf"
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sr = new(saveFile.FileName);
                sr.Write(textEditor.Rtf);
            }
        }

        private void buttonBold_Click(object sender, EventArgs e)
        {
            if (textEditor.SelectionFont.Bold == false)
            {
                textEditor.SelectionFont = new(textEditor.Font, FontStyle.Bold);
            }
            else
            {
                textEditor.SelectionFont = new(textEditor.Font, FontStyle.Regular);
            }
        }

        private void buttonUnderlined_Click(object sender, EventArgs e)
        {
            if (textEditor.SelectionFont.Underline == false)
            {
                textEditor.SelectionFont = new(textEditor.Font, FontStyle.Underline);
            }
            else
            {
                textEditor.SelectionFont = new(textEditor.Font, FontStyle.Regular);
            }
        }

        private void buttonInclined_Click(object sender, EventArgs e)
        {
            if (textEditor.SelectionFont.Italic == false)
            {
                textEditor.SelectionFont = new(textEditor.Font, FontStyle.Italic);
            }
            else
            {
                textEditor.SelectionFont = new(textEditor.Font, FontStyle.Regular);
            }
        }

        private void buttonCentered_Click(object sender, EventArgs e)
        {
            if (textEditor.SelectionAlignment != HorizontalAlignment.Center)
            {
                textEditor.SelectionAlignment = HorizontalAlignment.Center;
            }
            else
            {
                textEditor.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void textSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float size = float.Parse(textSize.Text);
                textEditor.SelectionFont = new(textEditor.SelectionFont.FontFamily, size, textEditor.Font.Style);
            }
            catch
            {

            }
        }

        private void textEditor_SelectionChanged(object sender, EventArgs e)
        {
            textSize.Text = textEditor.SelectionFont.Size.ToString();
        }
    }
}