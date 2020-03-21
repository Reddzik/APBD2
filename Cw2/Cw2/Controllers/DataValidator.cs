using System;
using System.Collections.Generic;
using System.Text;

namespace Cw2.Controllers
{
    class DataValidator<T>
    {
       public static Boolean checkLength(T[] tab, int correct)
        {
            return tab.Length == correct;
        }
        public static Boolean checkColumnsContent(T column)
        {
            return String.IsNullOrWhiteSpace(column.ToString()) || String.IsNullOrEmpty(column.ToString()); 
        }

    }
}
