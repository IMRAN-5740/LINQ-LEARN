using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Samples1
{
    public class TeacherComparer : IEqualityComparer<Teacher>

    {
        public bool Equals(Teacher? x, Teacher? y)
        {
            if(object.ReferenceEquals(x,y))
                return true;
            else if(object.ReferenceEquals(x,null))
                return false;
            else if(object.ReferenceEquals(y,null))
                return false ;
            return ((x.Id.Equals(y.Id)) && (x.TeacherName.Equals(y.TeacherName)));
        }

        public int GetHashCode([DisallowNull] Teacher obj)
        {
           int idHashCode=obj.Id.GetHashCode();
           int nameHashCode = obj.TeacherName.GetHashCode();
           return idHashCode ^ nameHashCode;
        }
    }
}
