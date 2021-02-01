using System;
using System.Collections.Generic;
using System.Text;
using CRUD_Implementation.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Implementation.Context
{
    class StudentContext: DbContext
    {
        public DbSet<Student> student { set; get; }
        public DbSet<StudentCourse> studentcourse { set; get; }
        public DbSet<StudentAddress> studentaddress { set; get; }
        public DbSet<Teacher> teacher { set; get; }
        public DbSet<Course> course { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=StudentDB;Trusted_Connection=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Composite Key
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
        }
      
    }

}
