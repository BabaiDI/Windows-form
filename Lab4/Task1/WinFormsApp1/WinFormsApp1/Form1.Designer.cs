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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTrackBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNone = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTopLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBottomRight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBoth = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTrackBarOrientation = new System.Windows.Forms.ToolStripMenuItem();
            this.VMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюСообщенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сообщение1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сообщение2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сообщение3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenuBarStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.пустоToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сверхуСлеваToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.снизуСправаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сОбеихСторонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orientationStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальнаяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальнаяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переместитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCommand,
            this.menuItemTrackBar,
            this.menuItemTrackBarOrientation,
            this.менюСообщенийToolStripMenuItem,
            this.menuItemAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemCommand
            // 
            this.menuItemCommand.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAdd,
            this.menuItemDel,
            this.menuItemMove});
            this.menuItemCommand.Name = "menuItemCommand";
            this.menuItemCommand.Size = new System.Drawing.Size(102, 20);
            this.menuItemCommand.Text = "Команда меню";
            // 
            // menuItemAdd
            // 
            this.menuItemAdd.Name = "menuItemAdd";
            this.menuItemAdd.Size = new System.Drawing.Size(146, 22);
            this.menuItemAdd.Text = "Добавить";
            this.menuItemAdd.Click += new System.EventHandler(this.menuItemAdd_Click);
            // 
            // menuItemDel
            // 
            this.menuItemDel.Name = "menuItemDel";
            this.menuItemDel.Size = new System.Drawing.Size(146, 22);
            this.menuItemDel.Text = "Удалить";
            this.menuItemDel.Click += new System.EventHandler(this.menuItemDel_Click);
            // 
            // menuItemMove
            // 
            this.menuItemMove.Name = "menuItemMove";
            this.menuItemMove.Size = new System.Drawing.Size(146, 22);
            this.menuItemMove.Text = "Переместить";
            this.menuItemMove.Click += new System.EventHandler(this.menuItemMove_Click);
            // 
            // menuItemTrackBar
            // 
            this.menuItemTrackBar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNone,
            this.menuItemTopLeft,
            this.menuItemBottomRight,
            this.menuItemBoth});
            this.menuItemTrackBar.Name = "menuItemTrackBar";
            this.menuItemTrackBar.Size = new System.Drawing.Size(98, 20);
            this.menuItemTrackBar.Text = "Стиль бегунка";
            // 
            // menuItemNone
            // 
            this.menuItemNone.Checked = true;
            this.menuItemNone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemNone.Name = "menuItemNone";
            this.menuItemNone.Size = new System.Drawing.Size(160, 22);
            this.menuItemNone.Text = "Пусто";
            this.menuItemNone.Click += new System.EventHandler(this.menuItemNone_Click);
            // 
            // menuItemTopLeft
            // 
            this.menuItemTopLeft.Name = "menuItemTopLeft";
            this.menuItemTopLeft.Size = new System.Drawing.Size(160, 22);
            this.menuItemTopLeft.Text = "Сверху-Слева";
            this.menuItemTopLeft.Click += new System.EventHandler(this.menuItemNone_Click);
            // 
            // menuItemBottomRight
            // 
            this.menuItemBottomRight.Name = "menuItemBottomRight";
            this.menuItemBottomRight.Size = new System.Drawing.Size(160, 22);
            this.menuItemBottomRight.Text = "Снизу-Справа";
            this.menuItemBottomRight.Click += new System.EventHandler(this.menuItemNone_Click);
            // 
            // menuItemBoth
            // 
            this.menuItemBoth.Name = "menuItemBoth";
            this.menuItemBoth.Size = new System.Drawing.Size(160, 22);
            this.menuItemBoth.Text = "С обеих сторон";
            this.menuItemBoth.Click += new System.EventHandler(this.menuItemNone_Click);
            // 
            // menuItemTrackBarOrientation
            // 
            this.menuItemTrackBarOrientation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VMenuItem,
            this.GMenuItem});
            this.menuItemTrackBarOrientation.Name = "menuItemTrackBarOrientation";
            this.menuItemTrackBarOrientation.Size = new System.Drawing.Size(86, 20);
            this.menuItemTrackBarOrientation.Text = "Ориентация";
            // 
            // VMenuItem
            // 
            this.VMenuItem.Name = "VMenuItem";
            this.VMenuItem.Size = new System.Drawing.Size(163, 22);
            this.VMenuItem.Text = "Вертикальная";
            this.VMenuItem.Click += new System.EventHandler(this.OrientationMenuItem_Click);
            // 
            // GMenuItem
            // 
            this.GMenuItem.Checked = true;
            this.GMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GMenuItem.Name = "GMenuItem";
            this.GMenuItem.Size = new System.Drawing.Size(163, 22);
            this.GMenuItem.Text = "Горизонтальная";
            this.GMenuItem.Click += new System.EventHandler(this.OrientationMenuItem_Click);
            // 
            // менюСообщенийToolStripMenuItem
            // 
            this.менюСообщенийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сообщение1ToolStripMenuItem,
            this.сообщение2ToolStripMenuItem1,
            this.сообщение3ToolStripMenuItem});
            this.менюСообщенийToolStripMenuItem.Name = "менюСообщенийToolStripMenuItem";
            this.менюСообщенийToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.менюСообщенийToolStripMenuItem.Text = "Меню сообщений";
            // 
            // сообщение1ToolStripMenuItem
            // 
            this.сообщение1ToolStripMenuItem.Name = "сообщение1ToolStripMenuItem";
            this.сообщение1ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.сообщение1ToolStripMenuItem.Text = "Сообщение1";
            this.сообщение1ToolStripMenuItem.Click += new System.EventHandler(this.сообщение1ToolStripMenuItem_Click);
            // 
            // сообщение2ToolStripMenuItem1
            // 
            this.сообщение2ToolStripMenuItem1.Name = "сообщение2ToolStripMenuItem1";
            this.сообщение2ToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.сообщение2ToolStripMenuItem1.Text = "Сообщение2";
            this.сообщение2ToolStripMenuItem1.Click += new System.EventHandler(this.сообщение1ToolStripMenuItem_Click);
            // 
            // сообщение3ToolStripMenuItem
            // 
            this.сообщение3ToolStripMenuItem.Name = "сообщение3ToolStripMenuItem";
            this.сообщение3ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.сообщение3ToolStripMenuItem.Text = "Сообщение3";
            this.сообщение3ToolStripMenuItem.Click += new System.EventHandler(this.сообщение1ToolStripMenuItem_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(94, 20);
            this.menuItemAbout.Text = "О программе";
            // 
            // trackBar1
            // 
            this.trackBar1.ContextMenuStrip = this.contextMenuStrip2;
            this.trackBar1.Location = new System.Drawing.Point(12, 49);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(302, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuBarStyle,
            this.orientationStripMenu});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(154, 48);
            this.contextMenuStrip2.Click += new System.EventHandler(this.menuItemNone_Click);
            // 
            // StripMenuBarStyle
            // 
            this.StripMenuBarStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пустоToolStripMenuItem1,
            this.сверхуСлеваToolStripMenuItem1,
            this.снизуСправаToolStripMenuItem1,
            this.сОбеихСторонToolStripMenuItem});
            this.StripMenuBarStyle.Name = "StripMenuBarStyle";
            this.StripMenuBarStyle.Size = new System.Drawing.Size(153, 22);
            this.StripMenuBarStyle.Text = "Стиль бегунка";
            this.StripMenuBarStyle.Click += new System.EventHandler(this.menuItemNone_Click);
            // 
            // пустоToolStripMenuItem1
            // 
            this.пустоToolStripMenuItem1.Checked = true;
            this.пустоToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.пустоToolStripMenuItem1.Name = "пустоToolStripMenuItem1";
            this.пустоToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.пустоToolStripMenuItem1.Text = "Пусто";
            this.пустоToolStripMenuItem1.Click += new System.EventHandler(this.menuItemNone_Click);
            // 
            // сверхуСлеваToolStripMenuItem1
            // 
            this.сверхуСлеваToolStripMenuItem1.Name = "сверхуСлеваToolStripMenuItem1";
            this.сверхуСлеваToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.сверхуСлеваToolStripMenuItem1.Text = "Сверху-Слева";
            this.сверхуСлеваToolStripMenuItem1.Click += new System.EventHandler(this.menuItemNone_Click);
            // 
            // снизуСправаToolStripMenuItem1
            // 
            this.снизуСправаToolStripMenuItem1.Name = "снизуСправаToolStripMenuItem1";
            this.снизуСправаToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.снизуСправаToolStripMenuItem1.Text = "Снизу-Справа";
            this.снизуСправаToolStripMenuItem1.Click += new System.EventHandler(this.menuItemNone_Click);
            // 
            // сОбеихСторонToolStripMenuItem
            // 
            this.сОбеихСторонToolStripMenuItem.Name = "сОбеихСторонToolStripMenuItem";
            this.сОбеихСторонToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.сОбеихСторонToolStripMenuItem.Text = "С обеих сторон";
            this.сОбеихСторонToolStripMenuItem.Click += new System.EventHandler(this.menuItemNone_Click);
            // 
            // orientationStripMenu
            // 
            this.orientationStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вертикальнаяToolStripMenuItem1,
            this.горизонтальнаяToolStripMenuItem1});
            this.orientationStripMenu.Name = "orientationStripMenu";
            this.orientationStripMenu.Size = new System.Drawing.Size(153, 22);
            this.orientationStripMenu.Text = "Ориентация";
            this.orientationStripMenu.Click += new System.EventHandler(this.OrientationMenuItem_Click);
            // 
            // вертикальнаяToolStripMenuItem1
            // 
            this.вертикальнаяToolStripMenuItem1.Name = "вертикальнаяToolStripMenuItem1";
            this.вертикальнаяToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.вертикальнаяToolStripMenuItem1.Text = "Вертикальная";
            this.вертикальнаяToolStripMenuItem1.Click += new System.EventHandler(this.OrientationMenuItem_Click);
            // 
            // горизонтальнаяToolStripMenuItem1
            // 
            this.горизонтальнаяToolStripMenuItem1.Checked = true;
            this.горизонтальнаяToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.горизонтальнаяToolStripMenuItem1.Name = "горизонтальнаяToolStripMenuItem1";
            this.горизонтальнаяToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.горизонтальнаяToolStripMenuItem1.Text = "Горизонтальная";
            this.горизонтальнаяToolStripMenuItem1.Click += new System.EventHandler(this.OrientationMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.переместитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 70);
            this.contextMenuStrip1.Text = "Команда меню";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.menuItemAdd_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.menuItemDel_Click);
            // 
            // переместитьToolStripMenuItem
            // 
            this.переместитьToolStripMenuItem.Name = "переместитьToolStripMenuItem";
            this.переместитьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.переместитьToolStripMenuItem.Text = "Переместить";
            this.переместитьToolStripMenuItem.Click += new System.EventHandler(this.menuItemMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 487);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuItemCommand;
        private ToolStripMenuItem menuItemAdd;
        private ToolStripMenuItem menuItemDel;
        private ToolStripMenuItem menuItemMove;
        private ToolStripMenuItem menuItemAbout;
        private ToolStripMenuItem менюСообщенийToolStripMenuItem;
        private ToolStripMenuItem сообщение1ToolStripMenuItem;
        private ToolStripMenuItem сообщение2ToolStripMenuItem1;
        private ToolStripMenuItem сообщение3ToolStripMenuItem;
        private ToolStripMenuItem menuItemTrackBar;
        private ToolStripMenuItem menuItemNone;
        private ToolStripMenuItem menuItemTopLeft;
        private ToolStripMenuItem menuItemBottomRight;
        private ToolStripMenuItem menuItemBoth;
        private TrackBar trackBar1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem переместитьToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem menuItemTrackBarOrientation;
        private ToolStripMenuItem VMenuItem;
        private ToolStripMenuItem GMenuItem;
        private ToolStripMenuItem StripMenuBarStyle;
        private ToolStripMenuItem пустоToolStripMenuItem1;
        private ToolStripMenuItem сверхуСлеваToolStripMenuItem1;
        private ToolStripMenuItem снизуСправаToolStripMenuItem1;
        private ToolStripMenuItem сОбеихСторонToolStripMenuItem;
        private ToolStripMenuItem orientationStripMenu;
        private ToolStripMenuItem вертикальнаяToolStripMenuItem1;
        private ToolStripMenuItem горизонтальнаяToolStripMenuItem1;
    }
}