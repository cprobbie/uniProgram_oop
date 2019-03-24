using System;
using System.Collections.Generic;
using System.Text;

namespace UProgram
{
    public class Course
    {
        public string Name { get; private set; }
        private List<Student> StudentList { get; set; }
        private List<Teacher> TeacherList { get; set; }
        public Course(string name)
        {
            Name = name;
            StudentList = new List<Student>();
            TeacherList = new List<Teacher>();
        }

        internal void AddStudent(Student student)
        {

            StudentList.Add(student);
        }

        internal void AddTeacher(Teacher teacher)
        {
            TeacherList.Add(teacher);
        }
    }
}
