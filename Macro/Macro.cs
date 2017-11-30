
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Macro
{
    public class Macro
    {
        public static IEnumerable<T> MacroExpansion<T>(IEnumerable<T> sequence, T value, IEnumerable<T> newValues)
        {
            if(typeof(T) != value.GetType()) throw new InvalidEnumArgumentException();
            // Controllo dei tipi
            // if()
            List<T> res = sequence.ToList();
            List<T> NewValues = newValues.ToList();
            List<T> resList = new List<T>();
            foreach (var elem in res)
            {
                if (elem.Equals(value))
                {
                    foreach (var e in NewValues)
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
