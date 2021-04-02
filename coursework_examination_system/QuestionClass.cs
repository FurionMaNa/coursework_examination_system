using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_examination_system
{
    class QuestionClass
    {
        public int id;
        public string question;
        public byte type;
        public List<AnswerClass> answers;
    }
}
