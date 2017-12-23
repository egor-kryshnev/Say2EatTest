using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 I suggest to add the ability to order a few dishes at a time, with different additives.
 I myself could write code for this, if necessary.
     */

namespace say2EatTests
{
    public class Program
    {
        private static readonly string[] maindish = new string[] { "pizza", "toast" };
        private static string[] addons = new string[] { "black olives", "green olives", "extra cheese", "mushrooms" };

        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("insert your order");       //I made a loop so that after the output "Please try again" the method was called again
                input = Console.ReadLine();
                Console.WriteLine(AnalizeInput(input));
            } while (AnalizeInput(input).Equals("Please try again"));
            input = Console.ReadLine();
        }

        public static string AnalizeInput(string input)
        {
           
            
            var resualt = "";
            var tryAgain = "Please try again";
            if (!string.IsNullOrEmpty(input))  //here was a bug
            {
                Order order = new Order();
                
                foreach (var item in maindish)
                {
                    if (input.Contains(item))
                    {
                        order.main = item;

                    }
                    
                }
                if (string.IsNullOrEmpty(order.main))          //I created a condition in which if the customer does not specify a dish, it returns "Please try again"
                {    
                    return tryAgain;
                }

                foreach (var item in addons) 
                {
                    if (input.Contains(item))
                    {
                        order.addons += item + ",";
                    }
                }
                if (string.IsNullOrEmpty(order.addons))                             //I created a condition in which if a customer orders a dish without an addons, displays "Your "dish" is on the way"
                {
                    resualt = "Your " + order.main + " is on the way";
                }
                else
                {
                    resualt = "Your " + order.main + " with " + order.addons + "is on the way";
                }
            }
            else
            {
                return tryAgain;
            }

            return resualt;
        }

        public class Order
        {
            public string addons;
            public string main;
        }
    }
}

