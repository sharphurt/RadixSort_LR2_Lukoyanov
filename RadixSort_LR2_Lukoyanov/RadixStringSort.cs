using System;
using System.Collections.Generic;
using System.Linq;

namespace RadixSort_LR2_Lukoyanov
{
    public class RadixStringSort
    {
        private const int Repeats = 256;

        private int GetLongestLength(IEnumerable<string> a) => a.Select(s => s.Length).Concat(new[] {0}).Max();

        private int GetCharInString(int i, int d, IReadOnlyList<string> a)
        {
            if (d < 0 || d >= a[i].Length)
                return 0;

            return a[i][d];
        }

        public SortedWithInfo SortWithInfo(string[] initialArray)
        {
            var arrLength = initialArray.Length;
            var iteration = 0;
            var sorted = new string[arrLength];
            var longestLength = GetLongestLength(initialArray);
            for (var d = longestLength - 1; d >= 0; d--)
            {
                var count = new int[Repeats + 1];
                for (var i = 0; i < arrLength; ++i)
                {
                    var c = GetCharInString(i, d, initialArray);
                    count[c + 1]++;
                    iteration++;
                }

                for (var r = 0; r < Repeats; ++r)
                {
                    count[r + 1] += count[r];
                    iteration++;
                }

                for (var i = 0; i < arrLength; ++i)
                {
                    var c = GetCharInString(i, d, initialArray);
                    sorted[count[c]++] = initialArray[i];
                    iteration++;
                }

                iteration++;
                Array.Copy(sorted, 0, initialArray, 0, arrLength);
            }

            return new SortedWithInfo(initialArray, iteration);
        }
    }
}