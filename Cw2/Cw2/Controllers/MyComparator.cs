using Cw2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Cw2.Controllers
{
    class MyComparator : IEqualityComparer<Student>
    {
        public bool Equals([AllowNull] Student firstStudent, [AllowNull] Student secondStudent)
        {
            if (firstStudent.Name.Equals(secondStudent.Name)
                && firstStudent.Surname.Equals(secondStudent.Surname)
                && firstStudent.Id.Equals(secondStudent.Id))
            {
                return true;
            }
            else return false;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
          return obj.Name.GetHashCode() + obj.Surname.GetHashCode() + obj.Id.GetHashCode();
        }
    }
}

