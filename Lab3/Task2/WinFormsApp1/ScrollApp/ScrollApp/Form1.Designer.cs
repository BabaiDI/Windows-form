namespace ScrollApp
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFarTemp = new System.Windows.Forms.Label();
            this.labelCTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(90, 9);
            this.vScrollBar1.Maximum = 60;
            this.vScrollBar1.Minimum = 20;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 261);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Value = 32;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фарингейт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(117, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цельсий";
            // 
            // labelFarTemp
            // 
            this.labelFarTemp.AutoSize = true;
            this.labelFarTemp.BackColor = System.Drawing.Color.White;
            this.labelFarTemp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFarTemp.Location = new System.Drawing.Point(30, 124);
            this.labelFarTemp.Name = "labelFarTemp";
            this.labelFarTemp.Size = new System.Drawing.Size(34, 25);
            this.labelFarTemp.TabIndex = 3;
            this.labelFarTemp.Text = "32";
            // 
            // labelCTemp
            // 
            this.labelCTemp.AutoSize = true;
            this.labelCTemp.BackColor = System.Drawing.Color.White;
            this.labelCTemp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCTemp.Location = new System.Drawing.Point(140, 124);
            this.labelCTemp.Name = "labelCTemp";
            this.labelCTemp.Size = new System.Drawing.Size(23, 25);
            this.labelCTemp.TabIndex = 4;
            this.labelCTemp.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 279);
            this.Controls.Add(this.labelCTemp);
            this.Controls.Add(this.labelFarTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "Form1";
            this.Text = "Измерение температуры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VScrollBar vScrollBar1;
        private Label label1;
        private Label label2;
        private Label labelFarTemp;
        private Label labelCTemp;
    }
}