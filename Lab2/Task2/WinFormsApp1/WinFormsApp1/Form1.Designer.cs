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
            this.theme = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.theme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.SuspendLayout();
            // 
            // theme
            // 
            this.theme.BackColor = System.Drawing.SystemColors.Control;
            this.theme.Controls.Add(this.radioButton4);
            this.theme.Controls.Add(this.radioButton1);
            this.theme.Controls.Add(this.radioButton3);
            this.theme.Controls.Add(this.radioButton2);
            this.theme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.theme.Location = new System.Drawing.Point(12, 12);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(275, 191);
            this.theme.TabIndex = 0;
            this.theme.TabStop = false;
            this.theme.Text = "Изображение фона";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.Location = new System.Drawing.Point(22, 127);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(91, 29);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "3";
            this.radioButton4.Text = "Сакура";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButtons_ChekedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(22, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(105, 29);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "0";
            this.radioButton1.Text = "Цветной";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButtons_ChekedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(22, 92);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 29);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "2";
            this.radioButton3.Text = "Неон";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButtons_ChekedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(22, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(136, 29);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "1";
            this.radioButton2.Text = "Вейпорвейв";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButtons_ChekedChanged);
            // 
            // width
            // 
            this.width.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.width.Location = new System.Drawing.Point(12, 262);
            this.width.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.width.Minimum = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(120, 29);
            this.width.TabIndex = 1;
            this.width.Value = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.width.ValueChanged += new System.EventHandler(this.width_ValueChanged);
            // 
            // height
            // 
            this.height.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.height.Location = new System.Drawing.Point(167, 262);
            this.height.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.height.Minimum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(120, 29);
            this.height.TabIndex = 2;
            this.height.Value = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.height.ValueChanged += new System.EventHandler(this.height_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Заголовок1",
            "Заголовок2"});
            this.comboBox1.Location = new System.Drawing.Point(365, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 29);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Items.AddRange(new object[] {
            "Times New Roman",
            "Arial",
            "Ms Sans Serif"});
            this.listBox1.Location = new System.Drawing.Point(365, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 109);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(189, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Висота";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(401, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Шрифт";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.theme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.theme.ResumeLayout(false);
            this.theme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox theme;
        private RadioButton radioButton4;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private NumericUpDown width;
        private NumericUpDown height;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}