using System;
using System.Collections.Generic;

namespace CSharpDrom
{


    public class Student
    {
        public Student(string firstName, string lastName,int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age; 
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


    }
    
    public class School
    {
        public string Name { get; set; }
        public List<Student> Students;

        public School(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public  void PrintStudents()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine($"В школе {Name} нет учеников");
            }
            else
            {
                Console.WriteLine("{0,-3} {1,-10} {2,-10} {3,-10}"," № ", "Фамилия", "Имя", "Возраст");
                Console.WriteLine();
                string tempName;
                for (int i = 0; i < Students.Count; i++)
                {
                    
                    Console.WriteLine("{0,-3} {1,-10} {2,-10} {3,-10}",i+1 , Students[i].FirstName, Students[i].LastName,Students[i].Age);
                }
            }

            
        }

        public void AddNewStudent(Student student)
        {
            Students.Add(student);
            Console.WriteLine($"Студент {student.FirstName} добавлен в школу {Name}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Введите название вашей школы");
            string schoolName = Console.ReadLine();

            School school = new School(schoolName);
            Console.WriteLine($"Школа {school.Name} успешно создана ");

            while (true)
            {
                Console.WriteLine($"Посмотреть список учеников школы {school.Name} ? Да/Нет");
                string userAnswer = Console.ReadLine();
                if (userAnswer =="да" || userAnswer== "yes" || userAnswer == "y")
                {
                    school.PrintStudents();
                }

                Console.WriteLine($"Добавить учеников в школу {school.Name} ? Да/Нет");
                string userAnswerAdd = Console.ReadLine();
                if (userAnswerAdd == "да" || userAnswerAdd == "yes" || userAnswerAdd == "y")
                {
                    Console.WriteLine("Фамилия ученика ");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Имя ученика ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Возраст ученика ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Student student = new Student(firstName,lastName,age);
                    school.AddNewStudent(student);
                }
            }
        }

    }
}
