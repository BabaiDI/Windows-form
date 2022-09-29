namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonText = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEIIipse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPen,
            this.toolStripButtonLine,
            this.toolStripButtonEllipse,
            this.toolStripButtonText});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButtonPen
            // 
            this.toolStripButtonPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPen.Image")));
            this.toolStripButtonPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPen.Name = "toolStripButtonPen";
            this.toolStripButtonPen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPen.Tag = "PEN";
            this.toolStripButtonPen.Text = "Карандаш";
            // 
            // toolStripButtonLine
            // 
            this.toolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLine.Image")));
            this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLine.Name = "toolStripButtonLine";
            this.toolStripButtonLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLine.Tag = "LINE";
            this.toolStripButtonLine.Text = "Линия";
            // 
            // toolStripButtonEllipse
            // 
            this.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEllipse.Image")));
            this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
            this.toolStripButtonEllipse.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEllipse.Tag = "ELLIPSE";
            this.toolStripButtonEllipse.Text = "Элипс";
            // 
            // toolStripButtonText
            // 
            this.toolStripButtonText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonText.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonText.Image")));
            this.toolStripButtonText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonText.Name = "toolStripButtonText";
            this.toolStripButtonText.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonText.Tag = "TEXT";
            this.toolStripButtonText.Text = "Текст";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(288, 17);
            this.toolStripStatusLabel1.Text = "Не выбрано ни одного графического инструмента";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem
            // 
            this.MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPen,
            this.menuItemText,
            this.menuItemLine,
            this.menuItemEIIipse});
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(86, 20);
            this.MenuItem.Text = "Инструмент";
            // 
            // menuItemPen
            // 
            this.menuItemPen.Name = "menuItemPen";
            this.menuItemPen.Size = new System.Drawing.Size(133, 22);
            this.menuItemPen.Tag = "PEN";
            this.menuItemPen.Text = "&Карандаш ";
            this.menuItemPen.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItemText
            // 
            this.menuItemText.Name = "menuItemText";
            this.menuItemText.Size = new System.Drawing.Size(133, 22);
            this.menuItemText.Tag = "TEXT";
            this.menuItemText.Text = "&Текст ";
            this.menuItemText.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItemLine
            // 
            this.menuItemLine.Name = "menuItemLine";
            this.menuItemLine.Size = new System.Drawing.Size(133, 22);
            this.menuItemLine.Tag = "LINE";
            this.menuItemLine.Text = "&Линия ";
            this.menuItemLine.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItemEIIipse
            // 
            this.menuItemEIIipse.Name = "menuItemEIIipse";
            this.menuItemEIIipse.Size = new System.Drawing.Size(133, 22);
            this.menuItemEIIipse.Tag = "ELLIPSE";
            this.menuItemEIIipse.Text = "&Эллипс ";
            this.menuItemEIIipse.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Графический редактор";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonPen;
        private ToolStripButton toolStripButtonLine;
        private ToolStripButton toolStripButtonEllipse;
        private ToolStripButton toolStripButtonText;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItem;
        private ToolStripMenuItem menuItemPen;
        private ToolStripMenuItem menuItemText;
        private ToolStripMenuItem menuItemLine;
        private ToolStripMenuItem menuItemEIIipse;
    }
}