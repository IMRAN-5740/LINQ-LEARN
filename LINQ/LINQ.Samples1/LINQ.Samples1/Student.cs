using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Samples1
{
    public class Student:IEquatable<Student>
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string  StudentEmail { get; set; }
        public double Marks { get; set; }
        public List<Subject> Subjects { get; set; }

        public bool Equals(Student? other)
        {
            if(object.ReferenceEquals(null, other)) return false;
            if(object.ReferenceEquals(this, other)) return true;
            return (StudentId == other.StudentId) && (StudentName==other.StudentName);
           
        }
        public override int GetHashCode()
        {
            int idHashCode = StudentId.GetHashCode();
            int nameHashCode=StudentName.GetHashCode();
            return idHashCode ^ nameHashCode;   
        }
    }
}
