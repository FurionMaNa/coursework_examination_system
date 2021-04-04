using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace coursework_examination_system
{
    public partial class ConstructorTestForm : Form
    {
        private AllTestClass allTest;
        private List<SubjectClass> subjects;
        private List<int> idDelAnswer = new List<int>();
        private List<int> idDelQuestion = new List<int>();

        public ConstructorTestForm(int idTest)
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
            catch (Exception exception)
            {
                MessageBox.Show("Проверьте соединение с интернетом!", "Ошибка соединения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (idTest > -1)
            {
                String response = SendRequestClass.PostRequestAsync("getTest", "{ \"id\" : " + idTest + " }").Result;
                allTest = JsonConvert.DeserializeObject<AllTestClass>(response);
                textBox1.Text = allTest.Name;
                for (int i = 0; i < subjects.Count; i++)
                {
                    if (subjects[i].Id == allTest.subject)
                    {
                        comboBox1.SelectedIndex = i;
                    }
                }
                allTest.questions.ForEach(delegate (QuestionClass question)
                {
                    button1_Click(new Object(), new EventArgs());
                    ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count-1]).idQuestion = question.id;
                    if (question.type == 0)
                    {
                        ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).groupBox2.Controls.Add(((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).textBoxQuestion);
                        ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).textBoxQuestion.Text = question.question;
                        ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).textBoxQuestion.Location = new Point(10, 20);
                        ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).textBoxQuestion.Width = ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).groupBox2.Width - 20;
                        ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).textBoxQuestion.Height = ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).groupBox2.Height - 30;
                        ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).textBoxQuestion.Multiline = true;
                        ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).textBoxCreate = true;
                    } 
                    else
                    {
                        ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).groupBox2.Controls.Add(((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).pictureBox); 
                        ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).pictureBox.Location = new Point(10, 20);
                        ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).pictureBox.Width = ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).groupBox2.Width - 20;
                        ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).pictureBox.Height = ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).groupBox2.Height - 30;
                        ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).pictureBox.Load(question.question);
                        ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).filePath = question.question;
                    }
                    ((TabPageClass)tabControl1.TabPages[tabControl1.TabPages.Count - 1]).idQuestion = question.id;
                    int indexAnswer = 0;
                    question.answers.ForEach(delegate (AnswerClass answer)
                    {
                        ((TabPageClass)tabControl1.SelectedTab).objectAnswers[indexAnswer].checkBox.Visible = true;
                        ((TabPageClass)tabControl1.SelectedTab).objectAnswers[indexAnswer].textBox.Visible = true;
                        ((TabPageClass)tabControl1.SelectedTab).objectAnswers[indexAnswer].delButton.Visible = true;
                        ((TabPageClass)tabControl1.SelectedTab).objectAnswers[indexAnswer].checkBox.Checked = answer.correct == 1;
                        ((TabPageClass)tabControl1.SelectedTab).objectAnswers[indexAnswer].textBox.Text = answer.answer;
                        ((TabPageClass)tabControl1.SelectedTab).objectAnswers[indexAnswer].delButton.Tag = answer.id;
                        ((TabPageClass)tabControl1.SelectedTab).objectAnswers[indexAnswer].textBox.Tag = answer.id;
                        indexAnswer++;
                    });
                });
            }
            else
            {
                button1_Click(new Object(), new EventArgs());
            }
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
                answer.textBox.Text = "";
                answer.delButton.Visible = false;
                if (button.Tag != null)
                {
                    idDelAnswer.Add((int)button.Tag);
                }
            } 
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count < 20)
            {
                TabPageClass tpNew = new TabPageClass(this);
                tpNew.BackColor = Color.White;
                tpNew.groupBox3.BackColor = Color.White;
                tpNew.groupBox2.BackColor = Color.White;
                tpNew.Text = "Вопрос " + (tabControl1.TabPages.Count + 1);
                tabControl1.TabPages.Add(tpNew);
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(((TabPageClass)tabControl1.SelectedTab).idQuestion != -1)
            {
                idDelQuestion.Add(((TabPageClass)tabControl1.SelectedTab).idQuestion);
            }
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
                if(((TabPageClass)tabControl1.SelectedTab).textBoxCreate)
                {
                    ((TabPageClass)tabControl1.SelectedTab).groupBox2.Controls.Remove(((TabPageClass)tabControl1.SelectedTab).textBoxQuestion);
                    ((TabPageClass)tabControl1.SelectedTab).textBoxCreate = false;
                }
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
                ((TabPageClass)tabControl1.SelectedTab).pictureBox.Location = new Point(10, 20);
                ((TabPageClass)tabControl1.SelectedTab).pictureBox.Width = ((TabPageClass)tabControl1.SelectedTab).groupBox2.Width-20;
                ((TabPageClass)tabControl1.SelectedTab).pictureBox.Height = ((TabPageClass)tabControl1.SelectedTab).groupBox2.Height-30;
                ((TabPageClass)tabControl1.SelectedTab).pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!((TabPageClass)tabControl1.SelectedTab).filePath.Equals(""))
            {
                ((TabPageClass)tabControl1.SelectedTab).groupBox2.Controls.Remove(((TabPageClass)tabControl1.SelectedTab).pictureBox);
            }
            if(!((TabPageClass)tabControl1.SelectedTab).textBoxCreate)
            {
                ((TabPageClass)tabControl1.SelectedTab).groupBox2.Controls.Add(((TabPageClass)tabControl1.SelectedTab).textBoxQuestion);
                ((TabPageClass)tabControl1.SelectedTab).textBoxQuestion.Location = new Point(10, 20);
                ((TabPageClass)tabControl1.SelectedTab).textBoxQuestion.Width = ((TabPageClass)tabControl1.SelectedTab).groupBox2.Width-20;
                ((TabPageClass)tabControl1.SelectedTab).textBoxQuestion.Height = ((TabPageClass)tabControl1.SelectedTab).groupBox2.Height-30;
                ((TabPageClass)tabControl1.SelectedTab).textBoxQuestion.Multiline = true;
                ((TabPageClass)tabControl1.SelectedTab).textBoxCreate = true;
            }
        }

        private bool validationTest()
        {
            if(textBox1.Text.Trim().Length == 0)
                {
                MessageBox.Show("Тема теста не может быть пустой", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (TabPage tp in tabControl1.TabPages)
            {
                if (!((TabPageClass)tp).isValidTab())
                {
                    MessageBox.Show("Ошибка в вопросе " + tp.Text, "Ошибка в вопросе", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idTest = -1;
            String response;
            if (!validationTest())
            {
                return;
            }
            if (allTest == null)
            {
                response = SendRequestClass.PostRequestAsync("addTest", "{\"id\": " + ((SubjectClass)comboBox1.SelectedItem).Id +
                                                                                                                    " ,\n\"name\" : \"" + textBox1.Text + "\" }").Result;
                if (response.Equals("\terror"))
                {
                    MessageBox.Show("Ошибка при добавлении теста, обратитесь к админу", "Ошибка при добавлении теста", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (response.Equals("\tДанный тест уже создан!!!"))
                {

                    MessageBox.Show("Тест с таким названием уже существует", "Ошибка в названии", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    idTest = int.Parse(response);
                }
            }
            else
            {
                idTest = allTest.Id;
                response = SendRequestClass.PostRequestAsync("updateTest", "{\"idTest\": " + idTest +
                                                                                                                    " ,\n\"name\" : \"" + textBox1.Text + "\"" +
                                                                                                                    " ,\n\"idSubject\"  : " + ((SubjectClass)comboBox1.SelectedItem).Id + " }").Result;
                if (response.Equals("\terror"))
                {
                    MessageBox.Show("Ошибка при обновлении теста, обратитесь к админу", "Ошибка при обновлении теста", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (response.Equals("\tДанный тест уже создан!!!"))
                {

                    MessageBox.Show("Тест с таким названием уже существует", "Ошибка в названии", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    idTest = int.Parse(!response.Contains("\t") ? response : allTest.Id.ToString());
                }
            }
            foreach (TabPageClass tp in tabControl1.TabPages)
            {
                int idQuestion = -1;
                if (idTest != allTest.Id)
                {
                    tp.idQuestion = -1;
                }
                if (tp.filePath.Length == 0)
                {
                    if (tp.idQuestion == -1)
                    {
                        IdNameClass question = new IdNameClass(idTest, tp.textBoxQuestion.Text);
                        response = SendRequestClass.PostRequestAsync("addQuestionText", JsonConvert.SerializeObject(question)).Result;
                        if (response.Equals("\terror"))
                        {
                            MessageBox.Show("Ошибка при добавлении вопроса, обратитесь к админу", "Ошибка при добавлении вопроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            idQuestion = int.Parse(response);
                        }
                    }
                    else
                    {
                        idQuestion = tp.idQuestion;
                        IdNameClass question = new IdNameClass(idQuestion, tp.textBoxQuestion.Text);
                        response = SendRequestClass.PostRequestAsync("updateQuestionText", JsonConvert.SerializeObject(question)).Result;
                        if (response.Equals("\terror"))
                        {
                            MessageBox.Show("Ошибка при обновлении вопроса, обратитесь к админу", "Ошибка при обновлении вопроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            idQuestion = int.Parse(!response.Contains("\t") ? response : idQuestion.ToString());
                        }
                    }
                }
                else
                {
                    if (tp.idQuestion == -1)
                    {
                        response = SendRequestClass.Upload("addQuestionImage", "idTest=" + idTest, tp.pictureBox.Image).Result;
                        if ((response != null && (response.Equals("\terror") || response.Equals("\t"))) || (response == null))
                        {
                            MessageBox.Show("Ошибка при добавлении вопроса, обратитесь к админу", "Ошибка при добавлении вопроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            idQuestion = int.Parse(response);
                        }
                    }
                    else
                    {
                        idQuestion = tp.idQuestion;
                        response = SendRequestClass.Upload("updateQuestionImage", "idTest=" + idTest + "&idQuestion=" + tp.idQuestion, tp.pictureBox.Image).Result;
                        if (response != null && response.Equals("error"))
                        {
                            MessageBox.Show("Ошибка при добавлении вопроса, обратитесь к админу", "Ошибка при добавлении вопроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            idQuestion = int.Parse(!response.Contains("\t") ? response : idQuestion.ToString());
                        }
                    }
                }
                if (tp.textBox2.Text.Length > 0) addAnswer(tp.checkBox1, tp.textBox2, idQuestion);
                if (tp.textBox3.Text.Length > 0) addAnswer(tp.checkBox2, tp.textBox3, idQuestion);
                if (tp.textBox4.Text.Length > 0) addAnswer(tp.checkBox3, tp.textBox4, idQuestion);
                if (tp.textBox5.Text.Length > 0) addAnswer(tp.checkBox4, tp.textBox5, idQuestion);
                if (tp.textBox6.Text.Length > 0) addAnswer(tp.checkBox5, tp.textBox6, idQuestion);
                if (tp.textBox7.Text.Length > 0) addAnswer(tp.checkBox6, tp.textBox7, idQuestion);
                if (tp.textBox8.Text.Length > 0) addAnswer(tp.checkBox7, tp.textBox8, idQuestion);
                if (tp.textBox9.Text.Length > 0) addAnswer(tp.checkBox8, tp.textBox9, idQuestion);
                if (tp.textBox10.Text.Length > 0) addAnswer(tp.checkBox9, tp.textBox10, idQuestion);
                idDelQuestion.ForEach(delegate (int id)
                {
                    response = SendRequestClass.PostRequestAsync("deleteQuestion", "{ \"id\" : "+id+"}").Result;
                    if (response.Equals("\terror"))
                    {
                        MessageBox.Show("Ошибка при удалении вопроса, обратитесь к админу", "Ошибка при удалении вопроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
                idDelAnswer.ForEach(delegate (int id)
                {
                    response = SendRequestClass.PostRequestAsync("deleteAnswer", "{ \"id\" : " + id + "}").Result;
                    if (response.Equals("\terror"))
                    {
                        MessageBox.Show("Ошибка при удалении ответа, обратитесь к админу", "Ошибка при удалении ответа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
            if (allTest != null)
            {
                MessageBox.Show("Тест успешно обновлён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Тест успешно создан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Form1.refresEventClass.StartRefreshEvent(sender, e);
        }

        private void addAnswer(CheckBox checkBox, TextBox textBox, int idQuestion)
        {
            String response;
            if (textBox.Tag!=null)
            {
                response = SendRequestClass.PostRequestAsync("updateAnswer", "{\"idAnswer\": " + textBox.Tag +
                                                                                                              " ,\"name\" : \"" + textBox.Text + "\" ," +
                                                                                                              "\"correct\" : " + (checkBox.Checked ? 1 : 0) +
                                                                                                              ", \"idQuestion\" : " + idQuestion + "}").Result;
            }
            else
            {
                response = SendRequestClass.PostRequestAsync("addAnswer", "{\"id\": " + idQuestion +
                                                                                                              " ,\"name\" : \"" + textBox.Text + "\" ," +
                                                                                                              "\"correct\" : " + (checkBox.Checked ? 1 : 0) + "}").Result;
            }
            if (response.Equals("\terror"))
            {
                MessageBox.Show("Ошибка при добавлении ответа, обратитесь к админу", "Ошибка при добавлении ответа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        protected class IdNameClass
        {
            public int id;
            public string name;

            public IdNameClass(int id, string name)
            {
                this.id = id;
                this.name = name;
            }
        }

    }
}