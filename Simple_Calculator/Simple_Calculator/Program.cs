using System;
using System.Collections.Generic;

namespace Simple_Calculator
{
    class Program
    {
        private static string result;

        static void Main(string[] args)
        {
            CodeTest.oddNumbers(3, 14);
            CodeTest.reverseSentence("this is a trial");
            List<int> listOfNumbers = new List<int>(new int[] { 7, 3, 6, 6, -4, 9, 8, 75, 9, 22 });
            CodeTest.minValue(listOfNumbers);

            // VGT PREP
            // Add Even Numbers
            int[] arr1 = new int[] { 3, 4, 5, 7, 9, 10, 12, 25, 44, 2, 3 };
            CodeTest.evenNumbersTotal(arr1);

            // Family Tree
            Person Ted = FamilyTreeGenerator.Make();
            //Console.WriteLine(Ted.Descendants[0].Birthday);
            Solution.GetBirthMonth(Ted, "Joe");
            Solution.GetBirthMonth(Ted, "Sally");

            // Pirate Test
            Dictionary<string, string[]> myDictonary = new Dictionary<string, string[]>()
            {
                {"English", new string [] { "sport", "parrot", "ports", "matey" } }
            };
            var answer = SolutionII.GetPossibleWords("ortsp", myDictonary);
            foreach (string word in answer)
            {
                Console.WriteLine(word);
            }
            // Should return ["sport", "ports"].

            Console.ReadLine();
        }
    }
}


            //while (true)
            //{
                


                //var breakCheck = false;
                //Regex regex = new Regex(@"^[a-z,!,@,#]$");
                //Console.WriteLine("Enter in an Equasion");
                //string expression = Console.ReadLine();
                

                ////Split the string by the operator
                //string[] separators = { "+", "-", "*", "/" };
                //string[] numbers = expression.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                //var realNumbers = new List<double>();
                ////Loop through, convert the string into an int, and add it to a new list
                //foreach (var number in numbers)
                //{
                //    if (regex.IsMatch(number))
                //    {
                //        //Check for invalid characters
                //        Console.WriteLine("Not a valid character");
                //        breakCheck = true;
                //        continue;
                //    } else
                //    {
                //        realNumbers.Add(Int32.Parse(number));
                //    }
                //}
                //if (breakCheck == true)
                //{
                //    continue;
                //}
                ////Access the ints in the new list
                //double one = realNumbers[0];
                //double two = realNumbers[1];

                //string add = "+";
                //string subtract = "-";
                //string divide = "/";
                //string multiply = "*";
                ////Check which expression was written
                //if (expression.Contains(add))
                //{
                //    Addition.addidtion(one, two);
                //}
                //else if (expression.Contains(subtract))
                //{
                //    Subtraction.subtraction(one, two);
                //}
                //else if (expression.Contains(divide))
                //{
                //    Division.division(one, two);
                //}
                //else if (expression.Contains(multiply))
                //{
                //    Multiplication.multiplication(one, two);
                //}
//            }
//        }
//    }
//}
