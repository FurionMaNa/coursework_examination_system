
namespace coursework_examination_system
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.системаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.системаToolStripMenuItem,
            this.тестыToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // системаToolStripMenuItem
            // 
            this.системаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTestToolStripMenuItem,
            this.ListTestToolStripMenuItem,
            this.createUserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.системаToolStripMenuItem.Name = "системаToolStripMenuItem";
            this.системаToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.системаToolStripMenuItem.Text = "Система";
            // 
            // createTestToolStripMenuItem
            // 
            this.createTestToolStripMenuItem.Name = "createTestToolStripMenuItem";
            this.createTestToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.createTestToolStripMenuItem.Text = "Создать тест";
            this.createTestToolStripMenuItem.Click += new System.EventHandler(this.createTestToolStripMenuItem_Click);
            // 
            // ListTestToolStripMenuItem
            // 
            this.ListTestToolStripMenuItem.Name = "ListTestToolStripMenuItem";
            this.ListTestToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ListTestToolStripMenuItem.Text = "Список тестов";
            this.ListTestToolStripMenuItem.Click += new System.EventHandler(this.ListTestToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.createUserToolStripMenuItem.Text = "Создать пользователя";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // тестыToolStripMenuItem
            // 
            this.тестыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestMenuToolStripMenuItem,
            this.посмотретьРезультатыToolStripMenuItem});
            this.тестыToolStripMenuItem.Name = "тестыToolStripMenuItem";
            this.тестыToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.тестыToolStripMenuItem.Text = "Тесты";
            // 
            // TestMenuToolStripMenuItem
            // 
            this.TestMenuToolStripMenuItem.Name = "TestMenuToolStripMenuItem";
            this.TestMenuToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.TestMenuToolStripMenuItem.Text = "Пройти тест";
            this.TestMenuToolStripMenuItem.Click += new System.EventHandler(this.TestMenuToolStripMenuItem_Click);
            // 
            // посмотретьРезультатыToolStripMenuItem
            // 
            this.посмотретьРезультатыToolStripMenuItem.Name = "посмотретьРезультатыToolStripMenuItem";
            this.посмотретьРезультатыToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.посмотретьРезультатыToolStripMenuItem.Text = "Посмотреть результаты";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.оАвтореToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // оАвтореToolStripMenuItem
            // 
            this.оАвтореToolStripMenuItem.Name = "оАвтореToolStripMenuItem";
            this.оАвтореToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оАвтореToolStripMenuItem.Text = "О авторе";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Экзаменационная система";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem системаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TestMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьРезультатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListTestToolStripMenuItem;
    }
}

