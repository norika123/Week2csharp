using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)

            
        {
            var dwarfs  = new string[7];
            dwarfs[0] = "Happy";
            dwarfs[1] = "Doc";
            dwarfs[2] = "Sleepy";
            dwarfs[3] = "Sneezy";
            dwarfs[4] = "Dopey";
            dwarfs[5] = "Bashful";
            dwarfs[6] = "Grumpy";


            for (int index = 0; index < dwarfs.Length; index++) 
            {
              
              
                Console.WriteLine ("Here's your dinner:" + dwarfs[index]);
              
            }
           
               foreach (String s in dwarfs)
            {

                Console.WriteLine("And here's a nice warm drink" +" " +  s);

            }

           
        }
    }
}
