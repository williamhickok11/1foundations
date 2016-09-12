using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class CodeTest
    {
        public static void evenNumbersTotal(int[]array)
        {
            int totalOfEvenNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 == 0)
                {
                    totalOfEvenNumbers += array[i];
                }
            }
            Console.WriteLine(totalOfEvenNumbers);
        }

        static long evenNumbersTotalII(int[] array)
        {
            return array.Where(i => i % 2 == 0).Sum(i => (long)i);
        }

        public static void oddNumbers(int first, int second)
        {
            if (first > second)
            {
                Console.WriteLine("the first number needs to be smaller than the second.");
            }
            else
            {
                for (int i = first + 1; i < second; i++)
                {
                    if (i%2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        public static void reverseSentence(string sentence)
        {

            char[] array = sentence.ToCharArray();
            int length = array.Length;
            char[] reversedArray = new char[length];
            int counter = 0;
            for (int i = length; i > 0; i--)
            {
                reversedArray[counter] = array[i - 1];
                counter++;
            }
            string finalAnswerReversedString = new string(reversedArray);
            Console.WriteLine(finalAnswerReversedString);
        }

        public static void minValue(List<int> listOfInts)
        {
            int minNumber = listOfInts[0];
            for (int i = 0; i < listOfInts.Count; i++)
            {
                if (listOfInts[i] < minNumber)
                {
                    minNumber = listOfInts[i];
                }
            }
            Console.WriteLine(minNumber);
            
        }
    }
}
