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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonList = new System.Windows.Forms.Button();
            this.ButtonTree = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DelTreeButton = new System.Windows.Forms.Button();
            this.DelListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(154, 259);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(12, 277);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(125, 45);
            this.buttonList.TabIndex = 2;
            this.buttonList.Text = "Добавить в список";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // ButtonTree
            // 
            this.ButtonTree.Location = new System.Drawing.Point(256, 277);
            this.ButtonTree.Name = "ButtonTree";
            this.ButtonTree.Size = new System.Drawing.Size(125, 45);
            this.ButtonTree.TabIndex = 3;
            this.ButtonTree.Text = "Добавить в дерево";
            this.ButtonTree.UseVisualStyleBackColor = true;
            this.ButtonTree.Click += new System.EventHandler(this.ButtonTree_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(143, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 33);
            this.textBox1.TabIndex = 4;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(227, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(154, 259);
            this.treeView1.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "warframe.png");
            // 
            // DelTreeButton
            // 
            this.DelTreeButton.Location = new System.Drawing.Point(256, 328);
            this.DelTreeButton.Name = "DelTreeButton";
            this.DelTreeButton.Size = new System.Drawing.Size(125, 42);
            this.DelTreeButton.TabIndex = 6;
            this.DelTreeButton.Text = "Удалить из дерева";
            this.DelTreeButton.UseVisualStyleBackColor = true;
            this.DelTreeButton.Click += new System.EventHandler(this.DelTreeButton_Click);
            // 
            // DelListButton
            // 
            this.DelListButton.Location = new System.Drawing.Point(12, 328);
            this.DelListButton.Name = "DelListButton";
            this.DelListButton.Size = new System.Drawing.Size(125, 42);
            this.DelListButton.TabIndex = 7;
            this.DelListButton.Text = "Удалить из списка";
            this.DelListButton.UseVisualStyleBackColor = true;
            this.DelListButton.Click += new System.EventHandler(this.DelListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 385);
            this.Controls.Add(this.DelListButton);
            this.Controls.Add(this.DelTreeButton);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonTree);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private Button buttonList;
        private Button ButtonTree;
        private TextBox textBox1;
        private TreeView treeView1;
        private ImageList imageList1;
        private Button DelTreeButton;
        private Button DelListButton;
    }
}