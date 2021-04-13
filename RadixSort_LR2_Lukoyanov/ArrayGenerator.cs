using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace RadixSort_LR2_Lukoyanov
{
    public class ArrayGenerator
    {
        private static readonly Random Random = new Random();
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public List<string[]> Generate(Node node)
        {
            return node.Name == "Arithmetic Progression"
                ? GenerateInArithmeticProgression(node)
                : GenerateInGeometricProgression(node);
        }

        private List<string[]> GenerateInArithmeticProgression(Node node)
        {
            var arrays = new List<string[]>();
            for (float i = node.StartLength; i < node.MaxLength; i += node.Diff)
            {
                var strings = new List<string>();
                for (var j = 0; j < i; j++)
                    strings.Add(GenerateString(Random.Next(node.MinElement, node.MaxElement)));
                arrays.Add(strings.ToArray());
            }

            return arrays;
        }

        private List<string[]> GenerateInGeometricProgression(Node node)
        {
            var arrays = new List<string[]>();
            for (float i = node.StartLength; i < node.MaxLength; i *= node.Denominator)
            {
                var strings = new List<string>();
                for (var j = 0; j < i; j++)
                    strings.Add(GenerateString(Random.Next(node.MinElement, node.MaxElement)));
                arrays.Add(strings.ToArray());
            }

            return arrays;
        }

        private static string GenerateString(int length) =>
            new string(Enumerable.Repeat(Chars, length).Select(s => s[Random.Next(s.Length)]).ToArray());
    }
}