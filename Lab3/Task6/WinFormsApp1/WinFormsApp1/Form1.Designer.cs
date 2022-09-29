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
            this.buttonBold = new System.Windows.Forms.Button();
            this.buttonUnderlined = new System.Windows.Forms.Button();
            this.buttonInclined = new System.Windows.Forms.Button();
            this.buttonCentered = new System.Windows.Forms.Button();
            this.textSize = new System.Windows.Forms.TextBox();
            this.textEditor = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBold
            // 
            this.buttonBold.Location = new System.Drawing.Point(180, 12);
            this.buttonBold.Name = "buttonBold";
            this.buttonBold.Size = new System.Drawing.Size(103, 29);
            this.buttonBold.TabIndex = 0;
            this.buttonBold.Text = "Полужирный";
            this.buttonBold.UseVisualStyleBackColor = true;
            this.buttonBold.Click += new System.EventHandler(this.buttonBold_Click);
            // 
            // buttonUnderlined
            // 
            this.buttonUnderlined.Location = new System.Drawing.Point(289, 12);
            this.buttonUnderlined.Name = "buttonUnderlined";
            this.buttonUnderlined.Size = new System.Drawing.Size(103, 29);
            this.buttonUnderlined.TabIndex = 1;
            this.buttonUnderlined.Text = "Подчеркнутый";
            this.buttonUnderlined.UseVisualStyleBackColor = true;
            this.buttonUnderlined.Click += new System.EventHandler(this.buttonUnderlined_Click);
            // 
            // buttonInclined
            // 
            this.buttonInclined.Location = new System.Drawing.Point(398, 12);
            this.buttonInclined.Name = "buttonInclined";
            this.buttonInclined.Size = new System.Drawing.Size(103, 29);
            this.buttonInclined.TabIndex = 2;
            this.buttonInclined.Text = "Наклонный";
            this.buttonInclined.UseVisualStyleBackColor = true;
            this.buttonInclined.Click += new System.EventHandler(this.buttonInclined_Click);
            // 
            // buttonCentered
            // 
            this.buttonCentered.Location = new System.Drawing.Point(507, 12);
            this.buttonCentered.Name = "buttonCentered";
            this.buttonCentered.Size = new System.Drawing.Size(103, 29);
            this.buttonCentered.TabIndex = 3;
            this.buttonCentered.Text = "По центру";
            this.buttonCentered.UseVisualStyleBackColor = true;
            this.buttonCentered.Click += new System.EventHandler(this.buttonCentered_Click);
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(370, 47);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(100, 23);
            this.textSize.TabIndex = 4;
            this.textSize.TextChanged += new System.EventHandler(this.textSize_TextChanged);
            // 
            // textEditor
            // 
            this.textEditor.Location = new System.Drawing.Point(12, 76);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(776, 297);
            this.textEditor.TabIndex = 5;
            this.textEditor.Text = "";
            this.textEditor.SelectionChanged += new System.EventHandler(this.textEditor_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Размер";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(234, 379);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(158, 32);
            this.buttonOpen.TabIndex = 7;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(398, 379);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(158, 32);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.buttonUnderlined);
            this.Controls.Add(this.textSize);
            this.Controls.Add(this.buttonBold);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonInclined);
            this.Controls.Add(this.textEditor);
            this.Controls.Add(this.buttonCentered);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBold;
        private Button buttonUnderlined;
        private Button buttonInclined;
        private Button buttonCentered;
        private TextBox textSize;
        private RichTextBox textEditor;
        private Label label1;
        private Button buttonOpen;
        private Button buttonSave;
    }
}