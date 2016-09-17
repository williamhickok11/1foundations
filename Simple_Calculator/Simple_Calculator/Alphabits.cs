using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    public class Alphabits
    {
        public List<string> arrayOfUserLetter = new List<string>();
        public Alphabits()
        {}

        public List<string> addChar()
        {
            while (arrayOfUserLetter.Count < 26)
            {
                string userInput = Console.ReadLine();
                if (Regex.IsMatch(userInput, "^[a-zA-Z]+$") && userInput.Length == 1)
                {
                    var flag = false;
                    foreach (string letter in arrayOfUserLetter)
                    {
                        if (letter == userInput)
                        {
                            Console.WriteLine("You already entered this letter");
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        arrayOfUserLetter.Add(userInput);
                        Console.WriteLine(arrayOfUserLetter.Count);
                    }
                    flag = false;
                }
                else
                {
                    Console.WriteLine("please enter a correct character");
                }
            }
            Console.WriteLine("You Win!");
            Console.WriteLine(arrayOfUserLetter);
            return null;
            
        }
    }
}
