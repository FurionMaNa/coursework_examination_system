using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_examination_system
{
    //Класс для хранения информации по результатам тестирования
    public class ResultClass
    {
        //Имя тестируемого
        public String userName;
        //тема теста
        public String examTopic;
        //Количество баллов
        public int score;
        //Оценка
        public int mark;
        //Время завершения
        public DateTime dateT;
    }
}
