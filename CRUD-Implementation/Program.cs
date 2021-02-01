using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CRUD_Implementation.Models;
using CRUD_Implementation.Context;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Proxies;
namespace CRUD_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
           using (var context = new StudentContext())
            { 
                   //var student = new Student()
                  // {
                    //   StudentName = "Taimoor",
                     //  TeacherId =  7,
                   // };
                // var teacher  = new Teacher()
                //  {
                      // TeacherName = "Noor_muhammad",

                   // };
                // var course = new Course()
              //   {
                 //    CourseName = "Maths",
                 // };
                //  var StudentAddress = new StudentAddress()
                 //  {
                 //    Address = "johar",
                  //   City = "Lahore",
                 //    Country= "Pakistan",
                 //      StudentId=9
                 //   };
               //  var Studentcourse = new StudentCourse()
               //  {
               //  StudentId=9,
               //  CourseId=6,
                // };

               // Creating_Data
               //  context.Add(student);
              //  context.Add(teacher);
              //   context.Add(StudentAddress);
              //   context.Add(course);
              //  context.Add(Studentcourse);
              //  context.SaveChanges();


                //Updating_Data
                // var stu = context.student.Find(1);
                //stu.StudentName = "Zunair";
                // context.SaveChanges();

                //REMOVING RECORD
                // var stu2 = context.student.Find(8);
                // context.Remove(stu2);
                // context.SaveChanges();

                //RetrieveData using method
             //   var student = new Student()
               // {
                 ////   StudentName = "Ali",
                  //  TeacherId = 1,
              //  };
              //  var student1 = new Student()
               // {
                //    StudentName = "Muneb",
                //    TeacherId = 1,
              //  };
                //var student2 = new Student()
              //  {
                 //   StudentName = "Sunny",
                  //  TeacherId = 1,
               // };
               // var student3 = new Student()
               // {
                 //   StudentName = "Taimoor",
                 //   TeacherId = 1,
              //  };
              //  context.Add(student);
              //  context.Add(student1);
              //  context.Add(student2);
              //  context.Add(student3);
              //  context.SaveChanges();

               var result = context.student.Where(s => s.StudentId == 1).FirstOrDefault<Student>();
                var Address =result.StudentAddress;
               // context.Entry(result).Reference(s => s.StudentAddress).Load(); // loads StudentAddress




                /*foreach (var d in result)*/
                Console.WriteLine(result.StudentName + " " + Address.Address + Address.City + Address.Country);
                //RetrieveData using Query
               // var res = from s in context.student
                         // where s.StudentId == 1
                       //   select s;
              // foreach (var d in res)
                  //  Console.WriteLine(d.StudentName);
               // Console.WriteLine("Displaying Students Name in Order");
                //Orderby
              //  var result2 = context.student.OrderBy(s => s.StudentName).ToList();
              //  foreach (var f in result2)
                //    Console.WriteLine(f.StudentName);
                //GroupBy
              //  Console.WriteLine("--Grouping by studentname--");

               // var students = context.student.AsEnumerable().GroupBy(s => s.StudentName).ToList();

               // foreach (var groupItem in students)
              //  {
                   // Console.WriteLine("--------------------------");
                   //// Console.WriteLine(groupItem.Key);
                   // Console.WriteLine("--------------------------");

                   // foreach (var stud in groupItem)
                   // {
                     //   Console.WriteLine(stud.StudentName + " " + stud.StudentId );
                   // }
               // }
            }
        }
    }
}
