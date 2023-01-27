using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Samples1
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string  StudentEmail { get; set; }
        public double Marks { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
