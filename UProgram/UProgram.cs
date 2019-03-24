using System;
using System.Collections.Generic;
using System.Text;

namespace UProgram
{
    public class UProgram
    {
        private List<Degree> DegreeList { get; set; }
        public string Name { get; set; }
        public UProgram(string courseName)
        {
            Name = courseName;
            DegreeList = new List<Degree>();
        }

        internal void AddDegree(Degree degree)
        {
            DegreeList.Add(degree);
        }
    }
}
