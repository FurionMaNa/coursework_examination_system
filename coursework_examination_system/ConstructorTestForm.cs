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
    public partial class ConstructorTestForm : Form
    {
        
        public ConstructorTestForm()
        {
            InitializeComponent();
            button1_Click(new Object(), new EventArgs());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ((TabPageClass)tabControl1.SelectedTab).objectAnswers.Count(); i++)
            {
                if (!((TabPageClass)tabControl1.SelectedTab).objectAnswers[i].checkBox.Visible)
                {
                    ((TabPageClass)tabControl1.SelectedTab).objectAnswers[i].checkBox.Visible = true;
                    ((TabPageClass)tabControl1.SelectedTab).objectAnswers[i].textBox.Visible = true;
                    ((TabPageClass)tabControl1.SelectedTab).objectAnswers[i].delButton.Visible = true;
                    break;
                }
            }
        }

        private ObjectAnswersClass findBlock(String nameButton)
        {
            ObjectAnswersClass resultObject = new ObjectAnswersClass();
            ((TabPageClass)tabControl1.SelectedTab).objectAnswers.ForEach(delegate (ObjectAnswersClass objectA)
            {
                if (objectA.delButton.Name.Equals(nameButton))
                {
                    resultObject = objectA;
                }
            });
            return resultObject;
        }

        public void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                ObjectAnswersClass answer = findBlock(button.Name);
                answer.checkBox.Visible = false;
                answer.textBox.Visible = false;
                answer.delButton.Visible = false;
            } 
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPageClass tpNew = new TabPageClass(this);
            tpNew.BackColor = Color.White;
            tpNew.groupBox3.BackColor = Color.White;
            tpNew.groupBox2.BackColor = Color.White;
            tpNew.Text = "Вопрос " + (tabControl1.TabPages.Count + 1);
            tabControl1.TabPages.Add(tpNew);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                tabControl1.TabPages[i].Text = "Вопрос " + (i + 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                ((TabPageClass)tabControl1.SelectedTab).filePath = openImage.FileName;
                ((TabPageClass)tabControl1.SelectedTab).pictureBox.Image = Image.FromFile(openImage.FileName);
                if (!((TabPageClass)tabControl1.SelectedTab).filePath.Equals(""))
                {
                    ((TabPageClass)tabControl1.SelectedTab).groupBox2.Controls.Remove(((TabPageClass)tabControl1.SelectedTab).pictureBox);
                    ((TabPageClass)tabControl1.SelectedTab).groupBox2.Controls.Add(((TabPageClass)tabControl1.SelectedTab).pictureBox);
                }
                else
                {
                    ((TabPageClass)tabControl1.SelectedTab).groupBox2.Controls.Add(((TabPageClass)tabControl1.SelectedTab).pictureBox);
                }
                ((TabPageClass)tabControl1.SelectedTab).pictureBox.Location = new Point(0, 0);
                ((TabPageClass)tabControl1.SelectedTab).pictureBox.Width = ((TabPageClass)tabControl1.SelectedTab).groupBox2.Width;
                ((TabPageClass)tabControl1.SelectedTab).pictureBox.Height = ((TabPageClass)tabControl1.SelectedTab).groupBox2.Height;
                ((TabPageClass)tabControl1.SelectedTab).pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}