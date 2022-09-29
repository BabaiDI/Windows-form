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
            this.YellowButton = new System.Windows.Forms.ToolStripButton();
            this.BlueButton = new System.Windows.Forms.ToolStripButton();
            this.RedButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YellowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.YellowButton,
            this.BlueButton,
            this.RedButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // YellowButton
            // 
            this.YellowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.YellowButton.Image = ((System.Drawing.Image)(resources.GetObject("YellowButton.Image")));
            this.YellowButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(23, 22);
            this.YellowButton.Text = "toolStripButton1";
            this.YellowButton.Click += new System.EventHandler(this.toolStrip_ItemClicked);
            // 
            // BlueButton
            // 
            this.BlueButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BlueButton.Image = ((System.Drawing.Image)(resources.GetObject("BlueButton.Image")));
            this.BlueButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(23, 22);
            this.BlueButton.Text = "toolStripButton2";
            this.BlueButton.Click += new System.EventHandler(this.toolStrip_ItemClicked);
            // 
            // RedButton
            // 
            this.RedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedButton.Image = ((System.Drawing.Image)(resources.GetObject("RedButton.Image")));
            this.RedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(23, 22);
            this.RedButton.Text = "toolStripButton3";
            this.RedButton.Click += new System.EventHandler(this.toolStrip_ItemClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ColorMenuItem
            // 
            this.ColorMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BlueMenuItem,
            this.YellowMenuItem,
            this.RedMenuItem});
            this.ColorMenuItem.Name = "ColorMenuItem";
            this.ColorMenuItem.Size = new System.Drawing.Size(77, 20);
            this.ColorMenuItem.Text = "Цвет фона";
            // 
            // BlueMenuItem
            // 
            this.BlueMenuItem.Name = "BlueMenuItem";
            this.BlueMenuItem.Size = new System.Drawing.Size(123, 22);
            this.BlueMenuItem.Text = "Синий";
            this.BlueMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // YellowMenuItem
            // 
            this.YellowMenuItem.Name = "YellowMenuItem";
            this.YellowMenuItem.Size = new System.Drawing.Size(123, 22);
            this.YellowMenuItem.Text = "Желтый";
            this.YellowMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // RedMenuItem
            // 
            this.RedMenuItem.Name = "RedMenuItem";
            this.RedMenuItem.Size = new System.Drawing.Size(123, 22);
            this.RedMenuItem.Text = "Красный";
            this.RedMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel1.Text = "Колір";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 406);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(800, 22);
            this.statusStrip2.TabIndex = 4;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel2.Text = "Колір";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton YellowButton;
        private ToolStripButton BlueButton;
        private ToolStripButton RedButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ColorMenuItem;
        private ToolStripMenuItem BlueMenuItem;
        private ToolStripMenuItem YellowMenuItem;
        private ToolStripMenuItem RedMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}