using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayinputandaverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[5];



   
        Console.WriteLine("Please enter 5 numbers to be averaged");

            for(int i =0; i< input.Length ; i++)

            {
                Console.WriteLine(" Please enter another  number");
                
                int display = Convert.ToInt32(Console.ReadLine());
                input[i]= display;

            }

            double total = 0;

            for (var j = 0; j < input.Length; j++)
            {
                total += input[j];
                
            }
            double average = total / input.Length;
            Console.WriteLine("Average is " + average);









        }
    }
}
