
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;

namespace Macro
{
    public class Macro
    {
        public static IEnumerator<T> MacroExpansion<T>(IEnumerable<T> sequence, T value, IEnumerable<T> newValues)
        {
            /*
             * Controllo params con T non nullabile non dovrebbe essere consentito un tipo nullo in value
             */
            foreach (var elem in sequence)
                if (elem.Equals(value))
                    foreach (var e in newValues)
                        yield return e;
                else yield return elem;
            
        }
    }
}
