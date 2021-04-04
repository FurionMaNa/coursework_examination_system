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

        int countCorrectAnswer = 0; 
        private AllTestClass allTest;
        private int idTest;
        private int index = 0;

        public TestingForm(int id)
        {
            idTest = id;
            InitializeComponent();
            String response = SendRequestClass.PostRequestAsync("getTest", "{ \"id\" : " + idTest + " }").Result;
            allTest = JsonConvert.DeserializeObject<AllTestClass>(response);
            label1.Text = allTest.Name;
            newListQuestion(index);
        }



        private void newListQuestion(int index)
        {
            //Формирование нового листа с ответом
            //Верный ответ помечаем 1 в Tag объекта
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
