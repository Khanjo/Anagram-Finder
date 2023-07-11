using System;
using System.Collections.Generic;
using Anagrams.Models;
using Anagrams.UserInterfaceModels;

namespace Anagrams
{
    class program
    {
        static void Main()
        {
            Console.WriteLine(WelcomeBanner.Welcome);
            Console.WriteLine("~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~");
            Console.WriteLine("Welcome to the Anagrams app. We'll take a word and tell you all of the words that can be made from the letters of that word!");
            Console.WriteLine("Please enter a word:");
            string input = Console.ReadLine();
            //Anagram userWord = new Anagram(input);
        }
    }
}