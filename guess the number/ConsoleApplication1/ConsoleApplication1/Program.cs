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
            int usernumber = 0;
            int selectednumber;
            string playagain = "Y";

            while (playagain == "Y")
            { 
            
            Random rand = new Random();
            selectednumber = rand.Next(1, 50);


            do
            {
                Console.WriteLine("Enter the number between 1 and 50");
                usernumber = Convert.ToInt32(Console.ReadLine());

                if (usernumber > selectednumber)
                {
                    Console.WriteLine("You have entered a larger nmber");

                }

                else if (usernumber < selectednumber)
                { 
               

   
                    Console.WriteLine("You have enterd a smaller number");

                }

                else

                {
                    Console.WriteLine("Your guess is right");
                }
                
              

            } while (usernumber!=selectednumber);

                Console.WriteLine(" Do you want to continue");

                if(Y == )
            }
            Console.WriteLine("Game over");

         
        }
    }
}
