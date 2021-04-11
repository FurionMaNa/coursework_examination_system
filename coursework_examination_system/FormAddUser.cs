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
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("ФИО пользователя должно быть заполнено!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox2.Text.Trim().Length != 10)
                {
                    MessageBox.Show("Номер и серия паспорта должны быть введены корректно!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (textBox3.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Не указан логин пользователя!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (textBox4.Text.Trim().Length < 8)
                        {
                            MessageBox.Show("Пароль должен быть не меньше 8 символов!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            String response = SendRequestClass.PostRequestAsync("addUser", "{ \"userName\" : \"" + textBox1.Text + "\" ,\n" +
                                                                                                                                                " \"passport\" : " + textBox2.Text + " ,\n" +
                                                                                                                                                "\"login\" : \"" + textBox3.Text + "\" , \n" +
                                                                                                                                                "\"password\" : \"" + textBox4.Text + "\", \n" +
                                                                                                                                                "\"status\" : "+ (checkBox2.Checked ? 0 : 1 ) +" }").Result;
                            if (response.Contains("error"))
                            {
                                MessageBox.Show("Ошибка при создани пользователя, обратитесь к админу", "Ошибка при создания пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            } 
                            else if (response.Length > 2)
                            {
                                MessageBox.Show(response, "Ошибка при создания пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            MessageBox.Show("Пользователь создан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && e.KeyChar != (char)Keys.Back) 
            {
                e.Handled = true;
            }
        }
    }
}
