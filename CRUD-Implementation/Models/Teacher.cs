using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Implementation.Models
{
    class Teacher
    {
        public int TeacherId { set; get; }
        public string TeacherName { set; get; }
        public ICollection<Student> Student { set; get; }

    }
}
