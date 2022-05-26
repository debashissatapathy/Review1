using System;

namespace AnagramPreoject
{
    class Program
    {
        static void Main(string[] args)
        {
            Anagram a = new Anagram();
            Console.WriteLine("Find anagram word.");
            Console.Write("Please enter first word: ");
            string first = Console.ReadLine();
            Console.Write("Please enter second word: ");
            string second = Console.ReadLine();
            if (a.IsAnagram(first, second))
            {
                Console.WriteLine("Given words are anagram");
            }
            else
            {
                Console.WriteLine("Not anagram, put another word.");
            }
        }
    }
}
