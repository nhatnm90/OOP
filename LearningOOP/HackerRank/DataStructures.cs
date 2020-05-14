using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    static class DataStructures
    {
        
        internal static int[] reverseArray(int[] a)
        {
            int[] result = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                int val = a[a.Length - 1 - i];
                result[i] = val;
            }
            return result;
        }
    }
}
