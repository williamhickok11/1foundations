using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_Shapes
{
    public class Rhombus
    {
        public static double altitude { get; set; }
        public static double side { get; set; }
        public double areaEquasion()
        {
            double answer = altitude * side;
            Console.WriteLine("The square's area is {0}", answer);
            return answer;
        }
    }
}
