using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal abstract class Question
    {
        #region Properties

        public  string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer CorrectAnswer { get; set; }
        public Answer[] Answers { get; set; }
        #endregion


        #region Constructors
        public Question(string _header, string _body, int _mark, Answer _correctAnswer, Answer[] _answers)
        {
            Header = _header;
            Body = _body;
            Mark = _mark;
            CorrectAnswer = _correctAnswer;
            Answers = _answers;
        } 
        #endregion
    }
}
