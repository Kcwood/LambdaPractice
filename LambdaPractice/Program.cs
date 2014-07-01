using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};

            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            var kayakProducts = new List<string> {"Kayak", "Kayak Paddles"};
            //print the kayakProducts to the console using a foreach loop.
            foreach (var kayak in kayakProducts)
            {
                Console.WriteLine(kayak);
            }	 
            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            Console.WriteLine();
            var shoeProducts = new List<string> { "Running Shoes", "Wrestling Shoes", "Trail Running Shoes", "Cycling Shoes" };
            //print the shoeProducts to the console using a foreach loop.
            foreach (var shoe in shoeProducts)
            {
                Console.WriteLine(shoe);  
            }
            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            Console.WriteLine();
            var ballProducts = new List<string> { "Basketball", "Baseball", "Soccer Ball", "Football" };
            //print the ballProducts to the console using a foreach loop.
            foreach (var ball in ballProducts)
	        {
                Console.WriteLine(ball);
	        }
            //sort ballProducts alphabetically and print them to the console.
            ballProducts = ballProducts.OrderBy(x => x.Length).ToList();
            //add six more items to the products list using .add().
            products.Add("Swim Suit");
            products.Add("Goggles");
            products.Add("Tennis Ball");
            products.Add("Chalk");
            products.Add("Rope");
            products.Add("Cleet");
            //print the product with the longest name to the console using the .First() extension.
            Console.WriteLine("The longest product name is: " + products.OrderByDescending(x => x.Length).First());
            //print the product with the shortest name to the console using the .First() extension.
            Console.WriteLine("The shortest product name is: " + products.OrderBy(x => x.Length).First());
            //print the product with the 4th shortest name to the console using an index (you must convert the results to a list using .ToList()).
            Console.WriteLine("The fourth shortest product name is: " + products.OrderBy(x => x.Length).Skip(3).Take(1).First());
            //print the ballProduct with the 2nd longest name to the console using an index(you must convert the results to a list using .ToList()).
            Console.WriteLine("The second longest product name is: " + products.OrderByDescending(x => x.Length).Skip(1).Take(1).First());
            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDecending() extension).
            var reversedProducts = products.OrderByDescending(x => x).First();
            //print out the reversedProducts to the console using a foreach loop.
            foreach (var reversed in reversedProducts)
            {
                Console.WriteLine(reversed); 
            }
            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            //You will not use a variable to store your list
            foreach (var longest in products)
            {
                Console.WriteLine("Products ordered by the longest word first: " + products.OrderByDescending(x => x.Length).First());
            }
            
            Console.ReadKey();
        }
    }
}
