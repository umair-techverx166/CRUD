﻿// <auto-generated />
using System;
using CRUD_Implementation.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD_Implementation.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20210107071253_tgtg")]
    partial class tgtg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CRUD_Implementation.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("course");
                });

            modelBuilder.Entity("CRUD_Implementation.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("student");
                });

            modelBuilder.Entity("CRUD_Implementation.Models.StudentAddress", b =>
                {
                    b.Property<int>("StudentAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("StudentAddressId");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("studentaddress");
                });

            modelBuilder.Entity("CRUD_Implementation.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("studeentcourse");
                });

            modelBuilder.Entity("CRUD_Implementation.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TeacherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("teacher");
                });

            modelBuilder.Entity("CRUD_Implementation.Models.Student", b =>
                {
                    b.HasOne("CRUD_Implementation.Models.Teacher", "Teacher")
                        .WithMany("Student")
                        .HasForeignKey("TeacherId");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("CRUD_Implementation.Models.StudentAddress", b =>
                {
                    b.HasOne("CRUD_Implementation.Models.Student", "Student")
                        .WithOne("StudentAddress")
                        .HasForeignKey("CRUD_Implementation.Models.StudentAddress", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CRUD_Implementation.Models.StudentCourse", b =>
                {
                    b.HasOne("CRUD_Implementation.Models.Course", "Course")
                        .WithMany("StudentCourse")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRUD_Implementation.Models.Student", "Student")
                        .WithMany("StudentCourse")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CRUD_Implementation.Models.Course", b =>
                {
                    b.Navigation("StudentCourse");
                });

            modelBuilder.Entity("CRUD_Implementation.Models.Student", b =>
                {
                    b.Navigation("StudentAddress");

                    b.Navigation("StudentCourse");
                });

            modelBuilder.Entity("CRUD_Implementation.Models.Teacher", b =>
                {
                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
