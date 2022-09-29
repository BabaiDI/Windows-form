namespace MDIBasic
{
    partial class frmChild
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rtfText = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemBold = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolButtonBolt = new System.Windows.Forms.ToolStripButton();
            this.ToolButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.ToolButtonUnderline = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtfText
            // 
            this.rtfText.ContextMenuStrip = this.contextMenuStrip1;
            this.rtfText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfText.Location = new System.Drawing.Point(0, 0);
            this.rtfText.Name = "rtfText";
            this.rtfText.Size = new System.Drawing.Size(800, 450);
            this.rtfText.TabIndex = 0;
            this.rtfText.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemBold,
            this.MenuItemItalic,
            this.MenuItemUnderline});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 70);
            // 
            // MenuItemBold
            // 
            this.MenuItemBold.Name = "MenuItemBold";
            this.MenuItemBold.Size = new System.Drawing.Size(156, 22);
            this.MenuItemBold.Text = "Полу&жирный";
            this.MenuItemBold.Click += new System.EventHandler(this.MenuItemBold_Click);
            // 
            // MenuItemItalic
            // 
            this.MenuItemItalic.Name = "MenuItemItalic";
            this.MenuItemItalic.Size = new System.Drawing.Size(156, 22);
            this.MenuItemItalic.Text = "&Курсив";
            this.MenuItemItalic.Click += new System.EventHandler(this.MenuItemItalic_Click);
            // 
            // MenuItemUnderline
            // 
            this.MenuItemUnderline.Name = "MenuItemUnderline";
            this.MenuItemUnderline.Size = new System.Drawing.Size(156, 22);
            this.MenuItemUnderline.Text = "Под&черкнутый";
            this.MenuItemUnderline.Click += new System.EventHandler(this.MenuItemUnderline_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.правкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNew,
            this.MenuItemOpen,
            this.MenuItemSave});
            this.MenuItemFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.MenuItemFile.Text = "&Файл";
            // 
            // MenuItemNew
            // 
            this.MenuItemNew.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.MenuItemNew.MergeIndex = 1;
            this.MenuItemNew.Name = "MenuItemNew";
            this.MenuItemNew.Size = new System.Drawing.Size(133, 22);
            this.MenuItemNew.Text = "&Создать";
            this.MenuItemNew.Click += new System.EventHandler(this.MenuItemNew_Click);
            // 
            // MenuItemOpen
            // 
            this.MenuItemOpen.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.MenuItemOpen.MergeIndex = 2;
            this.MenuItemOpen.Name = "MenuItemOpen";
            this.MenuItemOpen.Size = new System.Drawing.Size(133, 22);
            this.MenuItemOpen.Text = "&Открыть";
            this.MenuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click);
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.MenuItemSave.MergeIndex = 3;
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.Size = new System.Drawing.Size(133, 22);
            this.MenuItemSave.Text = "&Сохранить";
            this.MenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUndo,
            this.MenuItemRedo,
            this.MenuItemCopy,
            this.menuItemCut,
            this.MenuItemPaste});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            this.правкаToolStripMenuItem.MouseEnter += new System.EventHandler(this.правкаToolStripMenuItem_MouseEnter);
            // 
            // MenuItemUndo
            // 
            this.MenuItemUndo.Name = "MenuItemUndo";
            this.MenuItemUndo.Size = new System.Drawing.Size(180, 22);
            this.MenuItemUndo.Text = "Отменить";
            this.MenuItemUndo.Click += new System.EventHandler(this.MenuItemUndo_Click);
            // 
            // MenuItemRedo
            // 
            this.MenuItemRedo.Name = "MenuItemRedo";
            this.MenuItemRedo.Size = new System.Drawing.Size(180, 22);
            this.MenuItemRedo.Text = "Повторить";
            this.MenuItemRedo.Click += new System.EventHandler(this.MenuItemRedo_Click);
            // 
            // MenuItemCopy
            // 
            this.MenuItemCopy.Name = "MenuItemCopy";
            this.MenuItemCopy.Size = new System.Drawing.Size(180, 22);
            this.MenuItemCopy.Text = "Копировать";
            this.MenuItemCopy.Click += new System.EventHandler(this.MenuItemCopy_Click);
            // 
            // menuItemCut
            // 
            this.menuItemCut.Name = "menuItemCut";
            this.menuItemCut.Size = new System.Drawing.Size(180, 22);
            this.menuItemCut.Text = "Вырезать";
            this.menuItemCut.Click += new System.EventHandler(this.menuItemCut_Click);
            // 
            // MenuItemPaste
            // 
            this.MenuItemPaste.Name = "MenuItemPaste";
            this.MenuItemPaste.Size = new System.Drawing.Size(180, 22);
            this.MenuItemPaste.Text = "Вставить";
            this.MenuItemPaste.Click += new System.EventHandler(this.MenuItemPaste_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolButtonBolt,
            this.ToolButtonItalic,
            this.ToolButtonUnderline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolButtonBolt
            // 
            this.ToolButtonBolt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolButtonBolt.Image = global::MDIBasic.Properties.Resources.Bolt;
            this.ToolButtonBolt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButtonBolt.Name = "ToolButtonBolt";
            this.ToolButtonBolt.Size = new System.Drawing.Size(23, 22);
            this.ToolButtonBolt.Text = "toolStripButton1";
            this.ToolButtonBolt.Click += new System.EventHandler(this.MenuItemBold_Click);
            // 
            // ToolButtonItalic
            // 
            this.ToolButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolButtonItalic.Image = global::MDIBasic.Properties.Resources.Italic;
            this.ToolButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButtonItalic.Name = "ToolButtonItalic";
            this.ToolButtonItalic.Size = new System.Drawing.Size(23, 22);
            this.ToolButtonItalic.Text = "toolStripButton2";
            this.ToolButtonItalic.Click += new System.EventHandler(this.MenuItemItalic_Click);
            // 
            // ToolButtonUnderline
            // 
            this.ToolButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolButtonUnderline.Image = global::MDIBasic.Properties.Resources.Underline;
            this.ToolButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButtonUnderline.Name = "ToolButtonUnderline";
            this.ToolButtonUnderline.Size = new System.Drawing.Size(23, 22);
            this.ToolButtonUnderline.Text = "toolStripButton3";
            this.ToolButtonUnderline.Click += new System.EventHandler(this.MenuItemUnderline_Click);
            // 
            // frmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rtfText);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChild";
            this.Text = "frmChild";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtfText;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem MenuItemBold;
        private ToolStripMenuItem MenuItemItalic;
        private ToolStripMenuItem MenuItemUnderline;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItemFile;
        private ToolStripMenuItem MenuItemNew;
        private ToolStripMenuItem MenuItemOpen;
        private ToolStripMenuItem MenuItemSave;
        private ToolStrip toolStrip1;
        private ToolStripButton ToolButtonBolt;
        private ToolStripButton ToolButtonItalic;
        private ToolStripButton ToolButtonUnderline;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem MenuItemUndo;
        private ToolStripMenuItem MenuItemRedo;
        private ToolStripMenuItem MenuItemCopy;
        private ToolStripMenuItem menuItemCut;
        private ToolStripMenuItem MenuItemPaste;
    }
}