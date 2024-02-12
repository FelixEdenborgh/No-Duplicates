using System;
using System.Collections.Generic;


namespace No_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] words = input.Split(new char[] { ' ' });

            // håller koll på om det finns några dubelvärden typ ord som kommer fler än 1 gång.
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            bool hasDublicatedWords = false;
            // KeyValuePair använd när man jobbar med en samling världen som i dictionarys
            foreach (KeyValuePair<string, int> entry in wordCount)
            {
                if (entry.Value > 1)
                {
                    hasDublicatedWords = true;
                    break;
                }
            }

            if (hasDublicatedWords)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}