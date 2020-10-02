using System;
using System.Collections.Generic;

namespace Counting_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to be counted: ");
            string userString = Console.ReadLine();

            //string testString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in userString.ToLower().ToCharArray())
            {
                if (!charCount.ContainsKey(c))
                {
                    charCount.Add(c, 1);
                }
                else
                {
                    charCount[c]++;
                }
            }
            foreach (KeyValuePair<char, int> count in charCount)
            {
                Console.WriteLine(count.Key + ": " + count.Value);
            }
        }
    }
}
