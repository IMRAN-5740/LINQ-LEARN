using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Samples1
{
    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            if (object.ReferenceEquals(x, y))
                return true;
           
            else if(object.ReferenceEquals(x, null) || object.ReferenceEquals(y,null))
                return false;
              
           // return (x.StudentId == y.StudentId) && (x.StudentName == y.StudentName);
           return (x.StudentId.Equals(y.StudentId)) && (x.StudentName.Equals(y.StudentName));
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
           if(object.ReferenceEquals(obj,null))
            {
                return 0;
            }
           int idHashCode = obj.StudentId.GetHashCode();
           int nameHashCode = obj.StudentName==null ?  0 : obj.StudentName.GetHashCode();

            return idHashCode^ nameHashCode;
        }
    }
}
