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
    //Форма для настройки подключения
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0)
            {
                using (StreamWriter sw = new StreamWriter("../../resources/system.json", false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("{ \"server\" : \"" + textBox1.Text + "\" }");
                }
            }
            else
            {
                MessageBox.Show("Поле не должно быть пустым", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }
    }
}
