﻿// <auto-generated />
using Courses_Distribution_System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Courses_Distribution_System.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210913124623_DropDistributions")]
    partial class DropDistributions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Courses_Distribution_System.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<int>("CourseHours")
                        .HasColumnType("int");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<bool>("Optional")
                        .HasColumnType("bit");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<int>("TdHours")
                        .HasColumnType("int");

                    b.Property<int>("TpHours")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentName");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Courses_Distribution_System.Models.Department", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Name");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Courses_Distribution_System.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("AcademicRank")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

                    b.Property<string>("BackupEmail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("BackupPhoneNumber")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Contract")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("Id");

                    b.ToTable("Professors");
                });

            modelBuilder.Entity("Courses_Distribution_System.Models.ProfessorHours", b =>
                {
                    b.Property<string>("AcademicYear")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.Property<int>("MaxHours")
                        .HasColumnType("int");

                    b.Property<int>("MinHours")
                        .HasColumnType("int");

                    b.HasKey("AcademicYear", "ProfessorId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("ProfessorHours");
                });

            modelBuilder.Entity("Courses_Distribution_System.Models.ProfessorsDepartments", b =>
                {
                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentName", "ProfessorId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("ProfessorsDepartments");
                });

            modelBuilder.Entity("Courses_Distribution_System.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcademicYear")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<int>("CourseHours")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.Property<int>("TdHours")
                        .HasColumnType("int");

                    b.Property<int>("TpHours")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("Courses_Distribution_System.Models.Course", b =>
                {
                    b.HasOne("Courses_Distribution_System.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentName");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Courses_Distribution_System.Models.ProfessorHours", b =>
                {
                    b.HasOne("Courses_Distribution_System.Models.Professor", "Professor")
                        .WithMany("ProfessorHours")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Courses_Distribution_System.Models.ProfessorsDepartments", b =>
                {
                    b.HasOne("Courses_Distribution_System.Models.Department", "Department")
                        .WithMany("ProfessorsDepartments")
                        .HasForeignKey("DepartmentName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Courses_Distribution_System.Models.Professor", "Professor")
                        .WithMany("ProfessorsDepartments")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Courses_Distribution_System.Models.Section", b =>
                {
                    b.HasOne("Courses_Distribution_System.Models.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Courses_Distribution_System.Models.Professor", "Professor")
                        .WithMany("Sections")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Courses_Distribution_System.Models.Course", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("Courses_Distribution_System.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("ProfessorsDepartments");
                });

            modelBuilder.Entity("Courses_Distribution_System.Models.Professor", b =>
                {
                    b.Navigation("ProfessorHours");

                    b.Navigation("ProfessorsDepartments");

                    b.Navigation("Sections");
                });
#pragma warning restore 612, 618
        }
    }
}