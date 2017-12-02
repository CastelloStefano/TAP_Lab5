
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Macro
{
    public class Macro
    {
        public static IEnumerator<T> MacroExpansion<T>(IEnumerable<T> sequence, T value, IEnumerable<T> newValues)
        {
            //var enumerable = sequence as T[] ?? sequence.ToArray();
            IEnumerator<T> sequencEnumerator = sequence.GetEnumerator();
            //var values = newValues as IList<T> ?? newValues.ToList();
            IEnumerator<T> newValuesEnumerator = newValues.GetEnumerator();
            if(!sequencEnumerator.MoveNext()) throw new InvalidEnumArgumentException(); // Mangia il primo ?

            T current = sequencEnumerator.Current;
            while (sequencEnumerator.MoveNext()){
                if (current.Equals(value))
                {
                    while (newValuesEnumerator.MoveNext())
                        yield return newValuesEnumerator.Current;
                }
                else
                {
                    yield return current;
                }
                current = sequencEnumerator.Current;
            }
            if (current.Equals(value))
            {
                while (newValuesEnumerator.MoveNext())
                    yield return newValuesEnumerator.Current;
            }
            else
            {
                yield return current;
            }

            /*

            if (typeof(T) != value.GetType()) throw new InvalidEnumArgumentException();
            var res = newValuesEnumerator.ToList();
            var substitute = values.ToList();
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
            foreach (var rs in resList)
            {
                yield return rs;
            }
            //return resList;
            */
        }
    }
}
