using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_examination_system
{
    class SubjectClass
    {
        private int id;
        private string name;

        public string Name { get => name; set => name = value; }
        
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return name;
        }
    }
}
