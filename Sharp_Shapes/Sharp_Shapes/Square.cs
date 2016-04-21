using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_Shapes
{
    public class Square
    {
        public static double height { get; set; }
        public static double width { get; set; }
        public double equasion()
        {
            double answer = height * width;
            Console.WriteLine("The square's area is {0}", answer);
            return answer;
        }
    }
}
