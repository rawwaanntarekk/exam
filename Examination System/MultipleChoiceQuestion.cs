using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class MultipleChoiceQuestion : Question
    {
        // Constructor takes the body of the question, the mark of the question, the correct answer and the answers
        // the header is fixed for this type of question
        #region Constructors
        public MultipleChoiceQuestion(string _body, int _mark, Answer _correctAnswer, Answer[] _answers)
            : base("Choose One Answer Correct", _body, _mark, _correctAnswer, _answers) { }

        #endregion

    }
}
