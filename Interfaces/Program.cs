using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            manager.Studentadd(new Student { 
                StudentId =1, 
                Name = "berkay", 
                Lastname = "çınar",
                age = 20,
                Department = "Computer" });

            Manager manager2 = new Manager();
            manager2.Teacheradd(new Teacher
            {
                TeacherId = 1,
                Name = "yasemin",
                Lastname = "çınar",
                age = 20,
                Department = "Computer"


            });








            Console.ReadKey();
        }
    }

    interface IPerson
    {
        string Name { get; set; }
        string Lastname { get; set; }
        string Department { get; set; }
        int age  { get; set; }

    }

    class Student:IPerson
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Department { get; set; }
        public int age { get; set; }
        public int StudentId { get; set; }
    }
    class Teacher:IPerson
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Department { get; set; }
        public int age { get; set; }
        public int TeacherId { get; set; }
    }

    class Manager
    {
        public void Studentadd(Student student)
        {
            Console.WriteLine(student.Name + student.Lastname + student.age);
            Console.WriteLine("Student added successfully");
        }
        public void Teacheradd(Teacher teacher)
        {
            Console.WriteLine(teacher.Name + teacher.Lastname + teacher.age);
            Console.WriteLine("Teacher added successfully");

        }
    }
}
