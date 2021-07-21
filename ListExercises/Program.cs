using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> exampleNumbers = new List<int>{ 1, 1, 2, 3, 5, 8, 6, 6, 5, 9 };
            static int sumOfEvens(List<int> exampleNumbers)
            {
                int totalEvens = 0;
                foreach (int number in exampleNumbers)
                {
                    if(number % 2 == 0)
                    {
                        totalEvens += number;
                    }
                }
                return totalEvens;
            }
            
            Console.WriteLine(sumOfEvens(exampleNumbers));
            
            string passage = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string[] splitPassage = passage.Split(' ');
            List<string> wordsList = new List<string>();
            foreach (string word in splitPassage)
            {
                wordsList.Add(word);
            }
            string otherPassage = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            List<string> otherSplitPassage = new List<string>(otherPassage.Split(' ').ToList());
            Console.WriteLine("Enter the word length for the search: ");
            
            static List<string> onlyFiveLetters(List<string> wordsList)
            {
                string input = Console.ReadLine();
                int wordLength = int.Parse(input);
                List<string> fiveLetterWords = new List<string>();
                foreach (string word in wordsList)
                {
                    if(word.Length == wordLength)
                    {
                        fiveLetterWords.Add(word);
                        Console.WriteLine(word);
                    }
                }
                return fiveLetterWords;
            }

            Console.WriteLine(onlyFiveLetters(otherSplitPassage));
            
            
        }
        
    }
}
