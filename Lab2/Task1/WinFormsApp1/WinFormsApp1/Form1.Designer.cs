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
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Timer_Progress = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.TimerPanel = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start.Location = new System.Drawing.Point(12, 134);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(147, 58);
            this.Start.TabIndex = 0;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stop.Location = new System.Drawing.Point(165, 134);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(147, 58);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Стоп";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Timer_Progress
            // 
            this.Timer_Progress.Location = new System.Drawing.Point(13, 72);
            this.Timer_Progress.Name = "Timer_Progress";
            this.Timer_Progress.RightToLeftLayout = true;
            this.Timer_Progress.Size = new System.Drawing.Size(300, 17);
            this.Timer_Progress.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(12, 95);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(128, 33);
            this.numericUpDown1.TabIndex = 3;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Секунды",
            "Минуты",
            "Часы"});
            this.comboBox.Location = new System.Drawing.Point(147, 95);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(166, 33);
            this.comboBox.TabIndex = 4;
            // 
            // TimerPanel
            // 
            this.TimerPanel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerPanel.Location = new System.Drawing.Point(13, 12);
            this.TimerPanel.Name = "TimerPanel";
            this.TimerPanel.ReadOnly = true;
            this.TimerPanel.Size = new System.Drawing.Size(300, 54);
            this.TimerPanel.TabIndex = 5;
            this.TimerPanel.Text = "00:00:00";
            this.TimerPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 203);
            this.Controls.Add(this.TimerPanel);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Timer_Progress);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Start;
        private Button Stop;
        private ProgressBar Timer_Progress;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox;
        private TextBox TimerPanel;
        private System.Windows.Forms.Timer timer;
    }
}