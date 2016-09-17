using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    public class SolutionII
    {
        //static int myInt;

        //static SolutionII()
        //{
        //    myInt = 100382;
        //}

        public static List<string> GetPossibleWords(string jumbledWord, Dictionary<string, List<string>> dictionary)
        {
            //var dictionaryAsIEnumerable = dictionary["English"].AsEnumerable();

            var stuff = dictionary["English"]
                .Where(x => x.Length == jumbledWord.Length)
                .Where(x => string.Join("", x.OrderBy(y => y)) == string.Join("",jumbledWord.OrderBy(y => y)));

            Console.WriteLine(string.Join(",", stuff));

            List<string> possibleWordList = new List<string>();
            foreach (string possibleWord in dictionary["English"])
            {
                string buildAnswerString = "";
                if (possibleWord.Length == jumbledWord.Length)
                {
                    foreach (char character in possibleWord)
                    {
                        foreach (char jumbledWordCharacter in jumbledWord)
                        {
                            if (character == jumbledWordCharacter)
                            {
                                buildAnswerString += jumbledWordCharacter;
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
                            possibleWordList.Add(buildAnswerString);
                        }
                    }
                }
                
                //Console.WriteLine(word);
            }
            return possibleWordList;
            //throw new NotImplementedException();
        }
    }
}