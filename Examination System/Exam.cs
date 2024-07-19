using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal abstract class Exam
    {
        #region Properties

        public double Time { get; set; }
        public int QuestionNumber { get; set; }
        public Question[] Questions { get; set; }
        #endregion

        #region Constructors
        public Exam(double _time, int _questionNumber, Question[] _questions)
        {
            Time = _time;
            QuestionNumber = _questionNumber;
            Questions = _questions;
        }
        #endregion
    }
}
