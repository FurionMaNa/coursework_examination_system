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
    public partial class TestingForm : Form
    {

        private struct coordSize
        {
            public Point point;
            public Size size;
        }

        int countCorrectAnswer = 0; 
        private AllTestClass allTest;
        private int idTest;
        private int index = 0;

        coordSize[] coord = new coordSize[9];

        public TestingForm(int id)
        {
            idTest = id;

            coord[0].point = new System.Drawing.Point(7, 20);
            coord[0].size = new System.Drawing.Size(15, 14);
            coord[1].point = new System.Drawing.Point(7, 74);
            coord[1].size = new System.Drawing.Size(15, 14);
            coord[2].point = new System.Drawing.Point(7, 123);
            coord[2].size = new System.Drawing.Size(15, 14);
            coord[3].point = new System.Drawing.Point(216, 20);
            coord[3].size = new System.Drawing.Size(15, 14);
            coord[4].point = new System.Drawing.Point(216, 74);
            coord[4].size = new System.Drawing.Size(15, 14);
            coord[5].point = new System.Drawing.Point(216, 123);
            coord[5].size = new System.Drawing.Size(15, 14);
            coord[6].point = new System.Drawing.Point(421, 20);
            coord[6].size = new System.Drawing.Size(15, 14);
            coord[7].point = new System.Drawing.Point(421, 74);
            coord[7].size = new System.Drawing.Size(15, 14);
            coord[8].point = new System.Drawing.Point(421, 123);
            coord[8].size = new System.Drawing.Size(15, 14);
            String response = SendRequestClass.PostRequestAsync("getTest", "{ \"id\" : " + idTest + " }").Result;
            allTest = JsonConvert.DeserializeObject<AllTestClass>(response);
            InitializeComponent();
            label1.Text = allTest.Name;
            this.Text = allTest.Name;
            newListQuestion(index);
        }



        private void newListQuestion(int index)
        {
            if (allTest.questions.Count > index)
            {
                Control questionBox = null;
                groupBox1.Controls.Clear();
                if (allTest.questions[index].type == 0)
                {
                    questionBox = new TextBox();
                    ((TextBox)questionBox).Multiline = true;
                    ((TextBox)questionBox).Text = allTest.questions[index].question;
                }
                else
                {
                    questionBox = new PictureBox();
                    try
                    {
                        ((PictureBox)questionBox).Load(allTest.questions[index].question);
                        ((PictureBox)questionBox).SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Не возможно загрузить изображение!", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                groupBox1.Controls.Add(questionBox);
                questionBox.Location = new Point(10, 20);
                questionBox.Width = groupBox1.Width - 20;
                questionBox.Height = groupBox1.Height - 30;
                int countCorrect = 0;
                groupBox2.Controls.Clear();
                allTest.questions[index].answers.ForEach(delegate (AnswerClass answer) {
                    countCorrect+=answer.correct;
                });
                if (countCorrect > 1)
                {
                    int i = 0;
                    allTest.questions[index].answers.ForEach(delegate (AnswerClass answer)
                    {
                        CheckBox answerBox = new CheckBox();
                        answerBox.Location = coord[i].point;
                        answerBox.Text = answer.answer;
                        answerBox.Tag = answer.correct;
                        groupBox2.Controls.Add(answerBox);
                        i++;
                    });    
                }
                else
                {
                    int i = 0;
                    allTest.questions[index].answers.ForEach(delegate (AnswerClass answer)
                    {
                        RadioButton answerBox = new RadioButton();
                        answerBox.Location = coord[i].point;
                        answerBox.Text = answer.answer;
                        answerBox.Tag = answer.correct;
                        groupBox2.Controls.Add(answerBox);
                        answerBox.CheckedChanged += AnswerBox_CheckedChanged;
                        answerBox.Checked = i == 0;
                        i++;
                    });
                }
            }
        }

        private void AnswerBox_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Пробигаемся по всем отмеченным пользователем ответам и проверяе Tag на наличие 1
            //Колличество верных записываем в countCorrectAnswer
            //Если вопрос предпологает возможность выбора нескольких ответов, то при наличии хотя бы одного правильно выбранного ответа
            //все остальные не правильные будут вычитаться из суммы
            index++;
            newListQuestion(index);
        }
    }
    
}
