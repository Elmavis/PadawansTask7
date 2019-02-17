using System;
using System.Collections;
using System.Collections.Generic;

namespace PadawansTask7
{
    class Comp : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length - y.Length;
        }
    }

    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (array.Length == 0)
                throw new ArgumentException();
            Array.Sort(array, new Comp());
        }
    }
}