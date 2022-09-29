using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MDIBasic
{
    public partial class frmChild : Form
    {
        public frmChild(MDIBasic.frmContainer parent, string caption)
        {
            InitializeComponent();
            // Присваивание контейнеру родителя данной формы
            this.MdiParent = parent;
            this.Text = caption;
        }

        private void MenuItemBold_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(rtfText.SelectionFont,
            (rtfText.SelectionFont.Bold ?                  
            rtfText.SelectionFont.Style & ~FontStyle.Bold : 
            rtfText.SelectionFont.Style | FontStyle.Bold)); 
            rtfText.SelectionFont = newFont;				
        }

        private void MenuItemItalic_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(rtfText.SelectionFont,
            (rtfText.SelectionFont.Italic ? 
            rtfText.SelectionFont.Style & ~FontStyle.Italic :
            rtfText.SelectionFont.Style | FontStyle.Italic));
            rtfText.SelectionFont = newFont;
        }

        private void MenuItemUnderline_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(rtfText.SelectionFont,
            (rtfText.SelectionFont.Underline ?
            rtfText.SelectionFont.Style & ~FontStyle.Underline :
            rtfText.SelectionFont.Style | FontStyle.Underline));
            rtfText.SelectionFont = newFont;
        }

        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            this.rtfText.Clear();
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            this.rtfText.LoadFile("test.rtf");
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            rtfText.SaveFile("test.rtf");
        }

        private void MenuItemTile_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MenuItemCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MenuItemUndo_Click(object sender, EventArgs e)
        {
            rtfText.Undo();
        }

        private void MenuItemRedo_Click(object sender, EventArgs e)
        {
            rtfText.Redo();
        }

        private void MenuItemCopy_Click(object sender, EventArgs e)
        {
            rtfText.Copy();
        }

        private void menuItemCut_Click(object sender, EventArgs e)
        {
            rtfText.Cut();
        }

        private void MenuItemPaste_Click(object sender, EventArgs e)
        {
            rtfText.Paste();
        }

        private void правкаToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.menuItemCut.Enabled = rtfText.SelectedText.Length > 0 ? true : false;
        }
    }
}