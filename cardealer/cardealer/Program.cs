using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardealer
{
    class car
    {


        public string make;
        public string model;
        public int price;


        public static int total_numberofcars;

    }
    class program
    { 

    static void Main(string[] args)

            {
     

            car car1 = new car();

            car1.make = "volvo";
            car1.model = "Robin";

            car1.price = 99999;



                car car2 = new car();
                car2.make = "astra";
                car2.model = "twowheel";
                car2.price = 330;

                car.total_numberofcars = 6;

                Console .WriteLine("The datails of this car are:");
             Console.WriteLine("Make and model:{0} {1}, price: £{2:N0}", car1.make, car1.model,car1.price, car2.make,car2.model,car2.price);

            

        }
    }
}
