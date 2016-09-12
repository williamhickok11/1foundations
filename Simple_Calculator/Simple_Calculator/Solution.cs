using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    public class Solution
    {
        public static string GetBirthMonth(Person person, string descendantName)
        {
            // Solution logic here
            for (int i = 0; i < person.Descendants.Count; i++)
            {
                if (person.Descendants[i].Name == descendantName)
                {
                    Console.WriteLine(person.Descendants[i].Birthday);
                    return person.Descendants[i].Birthday.ToString();
                }
                // if the name doesnt exist here, check for the following decendants of the currnt decendant
                else
                {
                    for (int j = 0; j < person.Descendants[i].Descendants.Count; j++)
                    {
                        if (person.Descendants[i].Descendants[j].Name == descendantName)
                        {
                            Console.WriteLine(person.Descendants[i].Descendants[j].Birthday);
                            return person.Descendants[i].Descendants[j].Birthday.ToString();
                        }
                    }
                }
            }

            return "Descendant Not found";
            //throw new NotImplementedException();
            
        }
    }
}