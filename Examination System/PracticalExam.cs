using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(double _time, int _questionNumber, Question[] _questions)
               : base(_time, _questionNumber, _questions) { }
    }
}
