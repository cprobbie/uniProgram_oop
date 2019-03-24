using System;
using System.Collections.Generic;
using System.Text;

namespace UProgram
{
    public class Degree
    {
        public string Type { get; set; }
        private List<Course> CourseList { get; set; }
        public Degree(string type)
        {
            Type = type;
            CourseList = new List<Course>();
        }

        internal void AddCourse(Course course)
        {
            CourseList.Add(course);
        }
    }
}
