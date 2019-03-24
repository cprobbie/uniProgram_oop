using System;

namespace UProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new UProgram("Information Technology");
            var studentA = new Student("Ada");
            var studentB = new Student("Brian");
            var studentC = new Student("Cathy");
            var course = new Course("Programming with C#");
            course.AddStudent(studentA);
            course.AddStudent(studentB);
            course.AddStudent(studentC);
            var teacher = new Teacher();
            course.AddTeacher(teacher);
            var degree = new Degree("Bachelor");
            degree.AddCourse(course);
            program.AddDegree(degree);

            Console.WriteLine($"The name of the program is {program.Name} and it contains {degree.Type}");
            Console.WriteLine($"The name of the course in the degree is {course.Name}");
            Console.WriteLine($"The number of students in the above course is {Student.NumOfStudents}");
            Console.ReadLine();
        }
    }
}
