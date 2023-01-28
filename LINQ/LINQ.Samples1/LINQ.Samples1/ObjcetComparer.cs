using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Samples1
{
    public class ObjcetComparer : IEqualityComparer<Student>
    {
       public bool Equals(Student? x,Student? y)
        {
            if(object.ReferenceEquals(x, y))
                return true;
            else if(object.ReferenceEquals(x, null) || (object.ReferenceEquals(y,null)))
                return false;
            return (x.StudentId.Equals(y.StudentId)) && (x.StudentName.Equals(y.StudentName));
        }
        public int GetHashCode(Student? obj)
        {
            int idHashCode=obj.StudentId.GetHashCode();
            int nameHashCode=obj.StudentName.GetHashCode();
            return idHashCode^nameHashCode;
        }
    }
}
