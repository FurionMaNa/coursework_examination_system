using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace coursework_examination_system
{
    public partial class TestMenuForm : Form
    {
        private List<SubjectClass> subjects;
        private List<TestClass> tests;

        public TestMenuForm()
        {
            InitializeComponent();
            try
            {
                String response = SendRequestClass.PostRequestAsync("getSubjects", "").Result;
                subjects = JsonConvert.DeserializeObject<List<SubjectClass>>(response);
                if (subjects.Count > 0)
                {
                    comboBox1.DataSource = subjects;
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("В системе нет ни одного предмета, необходимо добавить!", "Нет предметов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("Проверьте соединение с интернетом!", "Ошибка соединения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SubjectClass subjectSelect = (SubjectClass)comboBox1.SelectedItem;
                String response = SendRequestClass.PostRequestAsync("getTests", "{ \"id\" : " + subjectSelect.Id + "} ").Result;
                tests = JsonConvert.DeserializeObject<List<TestClass>>(response);
                fillListBox();
                if (tests.Count > 0)
                {
                    listBox1.SelectedIndex = 0;
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("Проверьте соединение с интернетом!", "Ошибка соединения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillListBox()
        {
            listBox1.Items.Clear();
            tests.ForEach(delegate (TestClass test)
            {
                listBox1.Items.Add(test);
            });
        }

        private void TestMenuForm_Resize(object sender, EventArgs e)
        {
            if (this.Width < 436)
            {
                this.Width = 436;
            }
            if (this.Height < 465)
            {
                this.Height = 465;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tests.Sort((str1, str2) => { return string.Compare(str1.Name, str2.Name); });
            fillListBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tests.Sort((str1, str2) => { return string.Compare(str2.Name, str1.Name); });
            fillListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //todo добавить открытие формы с прохождением теста
        }
    }
}
