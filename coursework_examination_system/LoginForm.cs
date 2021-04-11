using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework_examination_system
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

       private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length>0 && textBox2.Text.Trim().Length > 0)
            {
                AuthorizationClass authorization = new AuthorizationClass(textBox1.Text, textBox2.Text);
                try
                {
                    String response = SendRequestClass.PostRequestAsync("login", JsonConvert.SerializeObject(authorization)).Result;
                    Console.WriteLine(response);
                    UserClass user = JsonConvert.DeserializeObject<UserClass>(response);
                    if (user != null)
                    {
                        Form1 form1 = new Form1(user, this);
                        form1.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
                catch(Exception exception)
                {
                    MessageBox.Show("Проверьте соединение с интернетом!", "Ошибка соединения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                MessageBox.Show("Логин или пароль должны быть указаны!", "Пустые поля",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private class AuthorizationClass
        {
            public String login;
            public String password;

            public AuthorizationClass(string login, string password)
            {
                this.login = login;
                this.password = password;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
        }
    }

}
