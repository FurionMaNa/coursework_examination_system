using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_examination_system
{
    //Класс наследуемый от класса TestClass
    class AllTestClass : TestClass
    {
        //поле содержащее id предмета
        public int subject;
        //Лист с вопросами
        public List<QuestionClass> questions;
    }
}
