﻿using System;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace RadixSort_LR2_Lukoyanov
{
    [TestFixture]
    public class RadixSortTests
    {
        private RadixStringSort _radixStringSort = new RadixStringSort();

        [Test]
        public void TestEmpty() =>
            Assert.AreEqual(_radixStringSort.SortWithInfo(new string[] { }).Array, new string[] { });

        [Test]
        public void TestArrayWithOneElement() =>
            Assert.AreEqual(_radixStringSort.SortWithInfo(new[] {"38A"}).Array, new[] {"38A"});

        [Test]
        public void TestArrayWithSimpleStrings() =>
            Assert.AreEqual(_radixStringSort.SortWithInfo(new[] {"b", "a", "c"}).Array, new[] {"a", "b", "c"});

        [Test]
        public void TestArrayWithNumber() =>
            Assert.AreEqual(_radixStringSort.SortWithInfo(new[] {"3", "1", "2"}).Array, new[] {"1", "2", "3"});

        [Test]
        public void TestArrayWithStringsInDifferentCases() =>
            Assert.AreEqual(_radixStringSort.SortWithInfo(new[] {"a", "A", "B", "b"}).Array,
                new[] {"A", "B", "a", "b"});

        [Test]
        public void TestArrayWithSpecialChars() =>
            Assert.AreEqual(_radixStringSort.SortWithInfo(new[] {"a", "A", "!", "B"}).Array,
                new[] {"!", "A", "B", "a"});

        [Test]
        public void TestArrayWithLettersNumbersSpecialsChars() =>
            Assert.AreEqual(_radixStringSort.SortWithInfo(new[] {"a", "5", "!", "B"}).Array,
                new[] {"!", "5", "B", "a"});

        [Test]
        public void TestArrayWithLongLengthStrings() =>
            Assert.AreEqual(_radixStringSort.SortWithInfo(new[] {"aaa", "aba", "aab", "bba"}).Array,
                new[] {"aaa", "aab", "aba", "bba"});
        
        [TestCase(new[] {"Aaa", "aba", "Bab", "bba"}, new[] {"Aaa", "Bab", "aba", "bba"})]
        [TestCase(new[] {"bbF", "Aaa", "ABA", "Cba", "Bab", "bba"}, new[] {"ABA", "Aaa", "Bab", "Cba", "bbF", "bba"})]
        public void TestArrayWithLongLengthStringInDifferentCases(string[] initial, string[] sorted) =>
            Assert.AreEqual(_radixStringSort.SortWithInfo(initial).Array, sorted);
        
        public void TestArrayWithLongLengthSpecialCharsStrings() =>
            Assert.AreEqual(_radixStringSort.SortWithInfo(new[] {"!a", "a!", "@a!"}).Array, new[] {"!a", "@a!", "a!"});
        
        public void TestArrayWithLongLengthSpecialCharsDifferentCasesStrings() =>
            Assert.AreEqual(_radixStringSort.SortWithInfo(new[] {"A!", "a!", "@a!"}).Array, new[] {"@a!", "A!", "a!"});
        
                
        public void TestArrayWithEqualElements() =>
            Assert.AreEqual(_radixStringSort.SortWithInfo(new[] {"a", "a", "a"}).Array, new[] {"a", "a", "a"});
    }
}