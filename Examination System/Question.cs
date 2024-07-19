﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal abstract class Question
    {
        #region Properties

        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer CorrectAnswer { get; set; }
        public Answer[] Answers { get; set; }
        #endregion


        #region Constructors

        public Question() { }

        protected Question(string _header, string _body, int _mark, Answer _correctAnswer, Answer[] _answers)
        {
            Header = _header;
            Body = _body;
            Mark = _mark;
            CorrectAnswer = _correctAnswer;
            Answers = _answers;
        }

        // ----------------------------------------------------------------------------------------------------------------------------------------

        private protected string ValidateBody()
        {
            string body;
            do
            {
                Console.Write("Please Enter The Body of Question: ");
                body = Console.ReadLine() ?? "";
            } while (string.IsNullOrEmpty(body));

            return body;
        }

        // ----------------------------------------------------------------------------------------------------------------------------------------

        private protected int ValidateMark()
        {
            int mark;
            do
            {
                Console.Write("Please Enter The Mark of Question: ");

            } while (!int.TryParse(Console.ReadLine() ?? "0", out mark) || mark <= 0);

            return mark;
        }


        // ----------------------------------------------------------------------------------------------------------------------------------------

        // Validate the correct answer's index depending on the type of question
         private protected abstract int ValidateCorrectAnswerIndex();


        // ----------------------------------------------------------------------------------------------------------------------------------------

        public abstract Question CreateQuestion();
        #endregion
    }
}
