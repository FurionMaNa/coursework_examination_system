using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_examination_system
{
    //Класс для хранения информации по вопросу
    class QuestionClass
    {
        //Id вопроса
        public int id;
        //Текст вопроса
        public string question;
        //Тип вопроса 1- картинка, 0 - текст
        public byte type;
        //Лист содержащий ответы на вопрос
        public List<AnswerClass> answers;
    }
}
