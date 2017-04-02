using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator! No offense to pigs, who are wonderful, and with apologies to Latin.");
            Boolean run = true;
            while (run == true)
            {
                Console.WriteLine("Enter a word to be rendered into Pig Latin.");
                string myWord = (Console.ReadLine());
                myWord.ToLower();
                int breakPoint = myWord.IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E','I','O','U'});
                //program now has the location of the first vowel!
                if (breakPoint == 0)
                {
                    Console.WriteLine(myWord+"way");
                }
                else if (breakPoint != 0)
                {
                    string firstBit = myWord.Substring(0, breakPoint);
                    string secondBit = myWord.Substring(breakPoint);
                    Console.WriteLine(secondBit + firstBit + "ay");
                }
                run = Continue();
            }
        }
        public static Boolean Continue()
        {
            Console.WriteLine("Translate another word? (Y/N): ");
            string input = Console.ReadLine();
            Boolean run = true;
            input.ToLower();
            if (input == "n")
            {
                Console.WriteLine("Goodbye!");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand your input. Let's try that again!");
                run = Continue();
            }

            return run;
        }
    }
}
