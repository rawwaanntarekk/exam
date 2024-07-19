using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class FinalExam : Exam
    {
        public FinalExam(int _time, int _questionNumber, Question[] _questions)
               : base(_time, _questionNumber, _questions)
        {
        }
    }
}
