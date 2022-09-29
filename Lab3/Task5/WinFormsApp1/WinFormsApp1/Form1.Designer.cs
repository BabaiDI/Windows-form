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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.richTextBoxAdress = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxProgrammist = new System.Windows.Forms.CheckBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(86, 9);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(228, 23);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // richTextBoxAdress
            // 
            this.richTextBoxAdress.Location = new System.Drawing.Point(86, 50);
            this.richTextBoxAdress.Name = "richTextBoxAdress";
            this.richTextBoxAdress.Size = new System.Drawing.Size(228, 96);
            this.richTextBoxAdress.TabIndex = 3;
            this.richTextBoxAdress.Text = "";
            this.richTextBoxAdress.TextChanged += new System.EventHandler(this.richTextBoxAdress_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Помощь";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxProgrammist
            // 
            this.checkBoxProgrammist.AutoSize = true;
            this.checkBoxProgrammist.Location = new System.Drawing.Point(12, 164);
            this.checkBoxProgrammist.Name = "checkBoxProgrammist";
            this.checkBoxProgrammist.Size = new System.Drawing.Size(94, 19);
            this.checkBoxProgrammist.TabIndex = 6;
            this.checkBoxProgrammist.Text = "Програмист";
            this.checkBoxProgrammist.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(15, 22);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 19);
            this.radioButtonFemale.TabIndex = 7;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Женский";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(115, 22);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(77, 19);
            this.radioButtonMale.TabIndex = 8;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Мужской";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.Controls.Add(this.radioButtonFemale);
            this.groupBoxSex.Controls.Add(this.radioButtonMale);
            this.groupBoxSex.Location = new System.Drawing.Point(12, 189);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Size = new System.Drawing.Size(223, 51);
            this.groupBoxSex.TabIndex = 9;
            this.groupBoxSex.TabStop = false;
            this.groupBoxSex.Text = "Пол";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(12, 261);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(50, 15);
            this.ageLabel.TabIndex = 11;
            this.ageLabel.Text = "Возраст";
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(86, 259);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(135, 23);
            this.numericUpDownAge.TabIndex = 12;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 313);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(302, 125);
            this.richTextBox2.TabIndex = 13;
            this.richTextBox2.Text = "";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 295);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(60, 15);
            this.labelResult.TabIndex = 14;
            this.labelResult.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.groupBoxSex);
            this.Controls.Add(this.checkBoxProgrammist);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxAdress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxSex.ResumeLayout(false);
            this.groupBoxSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private RichTextBox richTextBoxAdress;
        private Button button1;
        private Button button2;
        private CheckBox checkBoxProgrammist;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private GroupBox groupBoxSex;
        private Label ageLabel;
        private NumericUpDown numericUpDownAge;
        private RichTextBox richTextBox2;
        private Label labelResult;
    }
}