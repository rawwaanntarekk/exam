using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Subject
    {
        #region Properties

        public int Id { get; set; }
        public string Name { get; set; }
        public Exam[]? Exams { get; set; }

        #endregion

        #region Constructors
        public Subject(int _id, string _name)
        {
            Id = _id;
            Name = _name;
        }



        #endregion
    }
}
