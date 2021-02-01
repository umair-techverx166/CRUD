using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Implementation.Models
{
    class Course
    {
        public int CourseId { set; get; }
        public string CourseName { set; get; }
        public IList<StudentCourse> StudentCourse { set; get; }
    }
}
