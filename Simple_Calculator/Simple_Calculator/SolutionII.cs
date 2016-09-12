using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    public class SolutionII
    {
        public static List<string> GetPossibleWords(string jumble, Dictionary<string, string[]> dictionary)
        {
            List<string> possibleWords = new List<string>();
            foreach (string word in dictionary["English"])
            {
                string buildAnswerString = "";
                foreach (char character in word)
                {
                    foreach (char characterII in jumble)
                    {
                        if (character == characterII)
                        {
                            buildAnswerString += characterII;
                        }
                        //Console.WriteLine(character);
                    }
                    //Console.WriteLine(character);
                }
                foreach (string wordAgain in dictionary["English"])
                {
                    if (wordAgain == buildAnswerString)
                    {
                        //Console.WriteLine(buildAnswerString);
                        possibleWords.Add(buildAnswerString);
                    }
                }
                //Console.WriteLine(word);
            }
            return possibleWords;
            //throw new NotImplementedException();
        }
    }
}