using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    public class SolutionII
    {
        private string newString = "";
        //I use 10 becasue I can't set it to null, but I know this is a two digit number,
        //which will never come up in my foreach loop
        private int invalidDublicatedInt_RepeatLetterPlaceHolder = 10;
        private int numToRepeatLetter;
        private bool numberCheckerFlag = false;
        // input == "a4ig"
        public string returnNewString(string input)
        {
            foreach (char x in input)
            {
                string y = x.ToString();
                if (int.TryParse(y, out numToRepeatLetter))
                {
                    numberCheckerFlag = true;
                    if (invalidDublicatedInt_RepeatLetterPlaceHolder != 10)
                    {
                        throw new ArgumentException("not a vaild entry, you have repeating numbers", "input");
                    }
                    invalidDublicatedInt_RepeatLetterPlaceHolder = numToRepeatLetter;
                    continue;
                } else if (numberCheckerFlag == false)
                {
                    newString += x;
                    invalidDublicatedInt_RepeatLetterPlaceHolder = 10;
                } else if (numberCheckerFlag == true)
                {
                    for(var i = 0; i < invalidDublicatedInt_RepeatLetterPlaceHolder; i++)
                    {
                        newString += x;
                    }
                    invalidDublicatedInt_RepeatLetterPlaceHolder = 10;
                    numberCheckerFlag = false;
                }
            }
            Console.WriteLine(newString);
            return input;
        }



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
