using System;

namespace RadixSort_LR2_Lukoyanov
{
    public class SortedWithInfo
    {
        public string[] Array { get; }
        public int Iterations { get; }

        public SortedWithInfo(string[] array, int iterations)
        {
           Array = array;
           Iterations = iterations;
        }
    }
}