using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_examination_system
{
    //Класс хранящий информацию о предметах
    class SubjectClass
    {
        //id предмета
        private int id;
        //Название предмета
        private string name;

        public string Name { get => name; set => name = value; }
        
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return name;
        }
    }
}
