using Newtonsoft.Json;
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
    public partial class TestMenuForm : Form
    {
        private List<SubjectClass> subjects;
        private List<TestClass> tests;

        public TestMenuForm()
        {
            InitializeComponent();
            String response = SendRequestClass.PostRequestAsync("getSubjects", "").Result;
            subjects = JsonConvert.DeserializeObject<List<SubjectClass>>(response);
            if(subjects.Count>0)
            {
                subjects.ForEach(delegate (SubjectClass subject)
                {
                    comboBox1.Items.Add(subject);
                });
                comboBox1.SelectedIndex = 0;
            } 
            else 
            {
                MessageBox.Show("В системе нет ни одного предмета, необходимо добавить!", "Нет предметов", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubjectClass subjectSelect = (SubjectClass)comboBox1.SelectedItem;
            String response = SendRequestClass.PostRequestAsync("getTests", "{ \"id\" : " + subjectSelect.Id + "} ").Result;
            tests = JsonConvert.DeserializeObject<List<TestClass>>(response);
            if (tests.Count > 0)
            {
                listBox1.Items.Clear();
                tests.ForEach(delegate (TestClass test)
                {
                    listBox1.Items.Add(test);
                });
                listBox1.SelectedIndex = 0;
            }
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
    }
}
