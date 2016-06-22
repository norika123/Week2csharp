using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soldcars

{
    class car
    {
        public string make;
        public string model;
        public int price;
        public bool sold = false;


        public static int total_numberofcars;


        public void AddCar(string make, string model, int price)

        {
            this.make = make;
            this.model = model;
            this.price = price;
            
        }

    }
         class program
        {




        static void main(string [] args)
        {
            car car1 = new car();

            car1.AddCar("AUDI", "bird", 12000);
            car.total_numberofcars = 10;
            Console.WriteLine("make : {0} ", car1.model);
        }

        }


    
    }
