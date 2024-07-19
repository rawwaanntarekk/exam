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

        public int Time { get; set; }
        public int QuestionNumber { get; set; }
        public Question[] Questions { get; set; }
        #endregion

        #region Constructors
        public Exam(int _time, int _questionNumber, Question[] _questions)
        {
            Time = _time;
            QuestionNumber = _questionNumber;
            Questions = _questions;
        }
        #endregion

        


    }
}
