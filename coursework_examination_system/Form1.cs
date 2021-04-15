using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework_examination_system
{
    //Родительская форма
    public partial class Form1 : Form
    { 
        //содержит информацию о текущем пользователе
        public static UserClass user;
        //Форма авторизации, нужна для закрытия
        private LoginForm loginForm;
        //Объект для обновления
        public static RefreshClass refresEventClass = new RefreshClass();

        public Form1(UserClass user, LoginForm loginForm)
        {
            InitializeComponent();
            Form1.user = user;
            this.loginForm = loginForm;
            if (!user.status.Equals("0"))
            {
                systemToolStripMenuItem.Enabled = false;
            }
        }

        private void TestMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestMenuForm testMenu = new TestMenuForm(false);
            testMenu.MdiParent = this;
            testMenu.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Close();
        }

        private void createTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConstructorTestForm constructorTestForm = new ConstructorTestForm(-1);
            constructorTestForm.MdiParent = this;
            constructorTestForm.Show();
        }

        private void ListTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestMenuForm testMenu = new TestMenuForm(true);
            testMenu.MdiParent = this;
            testMenu.Show();

        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUser addUserForm = new FormAddUser();
            addUserForm.MdiParent = this;
            addUserForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void getResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            resultForm.MdiParent = this;
            resultForm.Show();
        }

        private void aboutAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAppForm aboutAppForm = new AboutAppForm();
            aboutAppForm.MdiParent = this;
            aboutAppForm.Show();
        }

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAuthorForm aboutAuthorForm = new AboutAuthorForm();
            aboutAuthorForm.MdiParent = this;
            aboutAuthorForm.Show();
        }
    }
}
