using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinput
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            String input1 = "";
            String input2 = "";

            Console.WriteLine("Enter the first numer");
            input1 = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            input2 = Console.ReadLine();

            num1 = Convert.ToInt32(input1);
            num2 = Convert.ToInt32(input2);

            int sum;
            sum = num1 + num2;

            Console.WriteLine("Your Total is" + "  " + sum);
            Console.Read();


        }
    }
}
