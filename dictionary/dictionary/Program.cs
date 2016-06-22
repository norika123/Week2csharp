using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {


            {

                string value;
                string input = "X";
                List<String> dictionary= string
                dictionary.Add("ASP");
                dictiona


                for (var i = 0; i < books.Count; i++)
                {
                    Console.WriteLine(books[i]);
                }


                Console.WriteLine("A: Press A to add the books");
                Console.WriteLine("D: Press D to delete");
                Console.WriteLine("L: Press L to list the items");
                Console.WriteLine("S: Press S to sort the books");



                do
                {
                    Console.WriteLine("Please enter any character for operation:");
                    input = Console.ReadLine();


                    switch (input)

                    {
                        case "A":
                        case "a":

                            Console.WriteLine("Enter the book to be added");
                            value = Console.ReadLine();
                            books.Add(value);
                            Console.WriteLine("Your list is:");
                            for (var i = 0; i < books.Count; i++)
                            {
                                Console.Write(books[i]);

                            }
                            break;

                        case "D":
                        case "d":

                            Console.WriteLine("Enter the book to be deleted");
                            value = Console.ReadLine();
                            books.Remove(value);
                            Console.WriteLine("Your list is:");
                            for (var i = 0; i < books.Count; i++)
                            {
                                Console.Write(books[i]);

                            }
                            break;


                        case "L":
                        case "l":

                            Console.WriteLine("Your list is : ");

                            for (var i = 0; i < books.Count; i++)
                            {
                                Console.WriteLine(books[i]);

                            }
                            break;



                        case "S":
                        case "s":

                            Console.WriteLine("Your  sorted list is :");

                            for (var i = 0; i < books.Count; i++)
                            {
                                Console.WriteLine(books[i]);
                                books.Sort();

                            }
                            break;






                        case "X":
                        case "x":
                            return;


                        default:
                            Console.WriteLine("Sorry wrong character");

                            break;

                    }

                }
                while ((input != "x") || (input != "X"));



            }
        }
    }

}
    }
}
