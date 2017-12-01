using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using NUnit.Framework;

namespace Lab5.Test
{
    [TestFixture]
    class Test
    {
        [TestCase(new[] { 1, 2, 1, 2, 3 }, 2, new[] { 7, 8, 9 }, 
            new[] { 1, 7, 8, 9, 1, 7, 8, 9, 3 })]
        [TestCase(new[] { 0.0, 1.2, 1.3, 1.6, 1.5}, 1.3, new[] { 10.0, 10.2 }, 
            new[] { 0.0, 1.2, 10.0, 10.2, 1.6, 1.5 } )]
        [TestCase(new[] { 1, 2, 1, 2, 3 }, 2, new[] { 7, 8, 9 },
            new[] { 1, 7, 8, 9, 1, 7, 8, 9, 3 })]
        [TestCase(new[] { "ciao", "ste", "hello", "tele", "ste", "tele" }, "ste", new[] { "new", "main" },
            new[] { "ciao", "new", "main", "hello", "tele", "new", "main", "tele" })]
        public void Expansions<T>(IEnumerable<T> seq, T val, IEnumerable<T> newVal, IEnumerable<T> expect)
        {
          Assert.That( Macro.Macro.MacroExpansion(seq, val,newVal),Is.EqualTo(expect));
        }

        [TestCase(new[] {"ciao", "ste", "hello", "tele", "ste", "tele"}, "ste", null)]
        [TestCase(null, 2, new[] {7, 8, 9})]
        [TestCase(new[] {1, 2, 1, 2, 3}, null, new[] {7, 8, 9})]
        public void NullParams<T>(IEnumerable<T> seq, object val, IEnumerable<T> newVal)
        {
            Assert.That(() => Macro.Macro.MacroExpansion(seq, val, newVal),
                Throws.TypeOf(typeof(ArgumentNullException)));
        }
        
    }
}
