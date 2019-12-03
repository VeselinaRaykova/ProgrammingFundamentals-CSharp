﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06Students2._0
{
    class Program
    {
        public static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            string[] commandArgs = Console.ReadLine().Split().ToArray();

            while (commandArgs[0] != "end")
            {
                string firstName = commandArgs[0];
                string lastName = commandArgs[1];
                int age = int.Parse(commandArgs[2]);
                string homeTown = commandArgs[3];

                if (IsExisting(firstName, lastName))
                {

                }
                if (students.Where(s => s.FirstName == firstName && s.LastName == lastName).ToList().Count > 0)
                {
                    Student existingStudent = GetStudent(firstName);
                    existingStudent.Age = age;
                    existingStudent.HomeTown = homeTown;
                }
                else
                {
                    Student student = new Student(firstName, lastName, age, homeTown);
                    students.Add(student);
                }

                commandArgs = Console.ReadLine().Split().ToArray();
            }

            string city = Console.ReadLine();

            foreach (Student s in students.Where(s => s.HomeTown == city))
            {
                Console.WriteLine($"{s.FirstName} {s.LastName} is {s.Age} years old.");
            }
        }

        private static Student GetStudent(string firstName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }

        private static bool IsExisting(string firstName, string lastName)
        {
            if (students.Where(s => s.FirstName == firstName && s.LastName == lastName).ToList().Count > 0)
            {
                return true;
            }
            return false;
        }
    }

    public class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string HomeTown;

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
    }
}
