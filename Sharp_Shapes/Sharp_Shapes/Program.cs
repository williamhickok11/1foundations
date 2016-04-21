using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {

            Square square1 = new Square();
            while (true)
            {
                Console.WriteLine("Select a shape: 1.Circle 2.Square 3.Rhombus 4.Cube 5.Cylinder");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Circle":
                        Console.WriteLine("you chose Circle");
                        break;
                    case "Square":
                        Console.WriteLine("you chose Square, please input the height of your square");
                        string height_input = Console.ReadLine();
                        double numVal = Int32.Parse(height_input);
                        string width_input = Console.ReadLine();
                        double numVal2 = Int32.Parse(width_input);
                        Square.height = numVal;
                        Square.width = numVal2;
                        square1.equasion();
                        break;
                    case "Rhombus":
                        Console.WriteLine("you chose Rhombus, please input the height of your square");
                        string altitude_input = Console.ReadLine();
                        double numVa3 = Int32.Parse(altitude_input);
                        string side_input = Console.ReadLine();
                        double numVal4 = Int32.Parse(side_input);
                        Square.height = numVa3;
                        Square.width = numVal4;
                        square1.equasion();
                        break;
                    case "Cube":
                        Console.WriteLine("you chose Cube");
                        break;
                    case "Cylinder":
                        Console.WriteLine("you chose Cylinder");
                        break;
                    default:
                        Console.WriteLine("Please choose a Shape");
                        break;
                }
            }
        }
    }
}
