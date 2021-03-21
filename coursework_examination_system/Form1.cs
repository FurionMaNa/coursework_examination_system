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
    public partial class Form1 : Form
    {
        private UserClass user;
        private LoginForm loginForm;

        public Form1(UserClass user, LoginForm loginForm)
        {
            InitializeComponent();
            this.user = user;
            this.loginForm = loginForm;
        }

        private void TestMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestMenuForm testMenu = new TestMenuForm();
            testMenu.MdiParent = this;
            testMenu.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Close();
        }
    }
}
