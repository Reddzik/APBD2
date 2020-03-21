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
            if (firstStudent.Imie.Equals(secondStudent.Imie))
/*                && firstStudent.Imie.Equals(secondStudent.Imie)
                && firstStudent.Email.Equals(secondStudent.Email))*/
            {
                return true;
            }
            else return false;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return obj.Imie.GetHashCode();
        }
    }
}

