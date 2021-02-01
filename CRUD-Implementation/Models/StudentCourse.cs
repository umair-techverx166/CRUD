using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Implementation.Models
{
    class StudentCourse
    {
        public int StudentId { set; get; }
        public Student Student { set; get; }
        public int CourseId { set; get; }
        public Course Course { set; get; }

    }
}
