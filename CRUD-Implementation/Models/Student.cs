using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Implementation.Models
{
    class Student
    {
        public int StudentId { set; get; }
        public string StudentName { set; get; }
        public IList<StudentCourse> StudentCourse { set; get; }
        public Teacher Teacher { set; get;}
        public   int TeacherId { set; get;}
        public virtual StudentAddress StudentAddress { set; get; }
        
    }

}
