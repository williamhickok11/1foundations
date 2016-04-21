using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabits
{
    public class Methods
    {
        public List<string> charList = new List<string>();

        public void addChar(string character)
        {
            charList.Add(character);
            Console.WriteLine(charList);
        }

        static void listLength()
        {

        }
    }
}
