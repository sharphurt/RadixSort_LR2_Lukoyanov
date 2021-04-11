using System;
using System.Linq;

namespace RadixSort_LR2_Lukoyanov
{
    public static class Utils
    {
        private static readonly Random Random = new Random();
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static string[] GenerateRandomArray(int size)
        {
            var arr = new string [size];
            for (var i = 0; i < size; i++)
                arr[i] = GenerateString((int) (100 * Random.NextDouble()));

            return arr;
        }

        private static string GenerateString(int length) => 
            new string(Enumerable.Repeat(Chars, length).Select(s => s[Random.Next(s.Length)]).ToArray());
    }
}