using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" These are the candidates standing for the US presidency, Hillary, Donald");
           
            Console.WriteLine("Enter who would win");
            String input = Console.ReadLine();

            switch (input)

            {
                case "Hillary":
                    Console.WriteLine("Excellent !!");
                    break;
                case "Donald":
                    Console.WriteLine("Maybe");
                    break;

                default:
                    Console.WriteLine("Out of range !!");
                    break;
            }

            Console.Read();


            }


        }
}
      