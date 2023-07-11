using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams.Models;
using System.Collections.Generic;
using System;

namespace Anagrams.Tests
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void AnagramsConstructor_CreatesInstanceOfAnagram_Anagram()
        {
            Anagram newAnagrams = new Anagram("hello");
            Assert.AreEqual(typeof(Anagram), newAnagrams.GetType());
        }
        [TestMethod]
        public void GetWord_ReturnsWord_String()
        {
            string input = "hello";
            Anagram newAnagram = new Anagram(input);
            string result = newAnagram.Word;
            Assert.AreEqual(input, result);
        }
        [TestMethod]
        public void SetWord_SetsValueOfWord_Void()
        {
            Anagram newAnagrams = new Anagram("hello");
            string newWord = "goodbye";
            newAnagrams.Word = newWord;
            Assert.AreEqual(newWord, newAnagrams.Word);
        }
        [TestMethod]
        public void CreateArray_CreatesAnArrayFromWord_String()
        {
            string input = "hello";
            Anagram newAnagram = new Anagram(input);
            char[] wordArray = Anagram.CreateArray(newAnagram.Word);
            Assert.IsInstanceOfType(wordArray, typeof(Array));
        }
        [TestMethod]
        public void CreateAnagrams_CreatesStringsFromCharArray_String()
        {
            Anagram newAnagrams = new Anagram("cat");
            string[] output = Anagram.GetAnagrams(newAnagrams.Word, 0, 2);
            string[] cat = { "cat", "cta", "act", "atc", "tac", "tca" };
            Assert.AreEqual(cat, output);
        }
    }
}