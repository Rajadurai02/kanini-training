using EFExampleFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFStudentApplication
{
    class Program
    {
        StudentContext studentContext;
        public Program()
        {
            studentContext = new StudentContext();
        }
        /// <summary>
        /// method for printing all student details in student databse
        /// </summary>
        public void PrintAllStudentDetails()
        {
            List<Student> students = studentContext.Students.ToList();
            foreach (var item in students)
            {
                Console.WriteLine("Student ID: " + item.Id);
                Console.WriteLine("Student Name: " + item.Name);
                Console.WriteLine("Date Of Joining: " + item.DateOfJoining);
                Console.WriteLine("-----------------------------");
            }
        }
        /// <summary>
        /// Add a new student detail to the database 
        /// </summary>
        public void AddStudent()
        {
            Student student = new Student();
            Console.WriteLine("ADDING DATA TO DATABASE");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Please Enter the Student Name");
            student.Name = Console.ReadLine();
            Console.WriteLine("Please Enter the Student's Date of Joining");
            student.DateOfJoining = Console.ReadLine();
            studentContext.Students.Add(student);
            studentContext.SaveChanges();
            Console.WriteLine("Data Added to database!!!\n");
        }
        /// <summary>
        /// Removing data in student database using student Id
        /// </summary>
        public void DeleteStudent()
        {
            Console.WriteLine("REMOVING DATA TO DATABASE");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Please enter the student ID you want delete");
            int StuID = Convert.ToInt32(Console.ReadLine());
            foreach (var item in studentContext.Students)
            {
                if (StuID == item.Id)
                {
                    studentContext.Students.Remove(item);
                }
            }
            studentContext.SaveChanges();
            Console.WriteLine($"Student ID {StuID} remmoved from the database!!\n");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.AddStudent();
            program.DeleteStudent();
            program.PrintAllStudentDetails();
            Console.ReadKey();
        }
    }
}
