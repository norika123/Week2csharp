using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{

    class car
    {

        public string model;
        public string make;
        public int price;
        public bool sold;
        public static int numberOfCars;


        public void AddCar(string model, string make, int price)
        {

            this.model = model;
            this.make = make;
            this.price = price;
            this.sold = false;
            car.numberOfCars++;

        }

        public void SoldCar(int price)
        {

            //this.model = model;
            //this.make = make;
            this.price = price;
            this.sold = true;
            car.numberOfCars--;

        }

        public static void DisplayAllCars (List<car> myCarList)
        {
            foreach (car myCar in myCarList)
            {
                Console.WriteLine(myCar.make + " " + myCar.model + " " + myCar.price) ;
            }
        }

    }//end car class

    class Program
    {

        

            static void Main(string[] args)

            {
            List<car> myCarList = new List<car>();

                car car1 = new car();

                car1.make = "volvo";
                car1.model = "Robin";
                car1.price = 99999;

                myCarList.Add(car1);


                car car2 = new car();
                car2.make = "astra";
                car2.model = "twowheel";
                car2.price = 330;

                myCarList.Add(car2);

            car.DisplayAllCars(myCarList);

            //car.numberOfCar = 6;

            //Console.WriteLine("The datails of this car are:");
            // Console.WriteLine("make and model:{0} {1}, price: £{2:N0}", car1.make, car1.model, car1.price);
            //  Console.WriteLine("make and model:{0} {1}, price:£{2:NO}" ,car2.make, car2.model, car2.price);

            //Display number of cars



            // public void ListCar()
            // {
            // Console .WriteLine("The details of this car are: ");
            // Console.Write("Make and model: {0} {1}, price: £{2:N0}.", make, model, price);  //:N0 formats the number")
            // Console.Write("Make and model: {0} {1}, price: £{2:N0}.", make, model, price);  //:N0 formats the number")
        }//end main



    }//end program class


}//end namespace

