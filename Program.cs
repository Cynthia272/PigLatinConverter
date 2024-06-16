using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Converter and Vowel Counter!");

            string[] words = new string[5];

            // Input words from the user
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter word {i + 1}: ");
                words[i] = Console.ReadLine().Trim().ToLower();
            }

            // Array to store Pig Latin versions of the words
            string[] pigLatinWords = new string[5];

            // Count of words starting with a vowel
            int vowelStartCount = 0;

            // Convert each word to Pig Latin and count words starting with vowels
            for (int i = 0; i < 5; i++)
            {
                string word = words[i];
                string pigLatinWord = ConvertToPigLatin(word);

                // Count words starting with a vowel
                if (StartsWithVowel(word))
                {
                    vowelStartCount++;
                }

                pigLatinWords[i] = pigLatinWord;
            }

            // Output results
            Console.WriteLine("\nPig Latin versions of your words:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{words[i]} -> {pigLatinWords[i]}");
            }

            Console.WriteLine($"\nNumber of words starting with vowels: {vowelStartCount}");

            Console.WriteLine("\nThank you for using the Pig Latin Converter!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Method to check if a word starts with a vowel
        static bool StartsWithVowel(string word)
        {
            char firstChar = word[0];
            return "aeiou".Contains(firstChar);
        }

        // Method to convert a word to Pig Latin
        static string ConvertToPigLatin(string word)
        {
            if (word.Length < 2)
            {
                return word; 
            }

            // Move the second letter to the start and add "ay"
            string pigLatinWord = word.Substring(1) + word[0] + "ay";
            return pigLatinWord;
        }
    }
}
