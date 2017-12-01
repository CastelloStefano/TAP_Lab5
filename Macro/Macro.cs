
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Macro
{
    public class Macro
    {
        public static IEnumerable<T> MacroExpansion<T>(IEnumerable<T> sequence, object value, IEnumerable<T> newValues)
        {
            if(sequence == null || value == null || newValues == null) throw new ArgumentNullException();
            var res = sequence.ToList();
            var substitute = newValues.ToList();
            var resList = new List<T>();
            foreach (var elem in res)
            {
                if (elem.Equals(value))
                {
                    foreach (var e in substitute)
                    {
                       resList.Add(e);
                    }
                }
                else
                {
                    resList.Add(elem);
                }
            }
            return resList;
        }
    }
}
