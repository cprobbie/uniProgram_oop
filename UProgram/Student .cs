using System;
using System.Collections.Generic;
using System.Text;

namespace UProgram
{
    public class Student
    {
        public string Name { get; set; }
        public static int NumOfStudents { get; private set; }
        public Student(string name)
        {
            Name = name;
            NumOfStudents++;
        }
    }
}
