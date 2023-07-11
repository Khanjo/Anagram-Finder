using System.Collections.Generic;

namespace Anagrams.Models
{
    public class Anagram
    {
        private string _word;
        public string Word
        {
            get { return _word; }
            set { _word = value; }
        }
        public Anagram(string input)
        {
            _word = input;
        }
        public static char[] CreateArray(string Word)
        {
            char[] wordArray = Word.ToCharArray();
            return wordArray;
        }
    }
}