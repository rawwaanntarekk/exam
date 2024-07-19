using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Answer
    {
        #region Properties

        public int Id { get; set; }
        public string Text { get; set; }

        #endregion


        public Answer(int _id , string _text)
        {
            Id = _id;
            Text = _text;  
        }
    }


}
