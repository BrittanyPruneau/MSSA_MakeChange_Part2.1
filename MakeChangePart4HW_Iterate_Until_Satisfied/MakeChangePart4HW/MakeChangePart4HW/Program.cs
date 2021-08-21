using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string request1 = ("How much will your items cost?");
                string request2 = ("How much will you pay for those items?");

                (double secondcost, double secondPayment) = secondRequest(request1, request2);


                //if (secondPayment < secondcost)
                //{
                //Console.WriteLine("You must give a minimum payment of {0}", secondcost);
                //  Instead, we could use iteration to ask the user to re-enter both the price 
                //  and the payment (the user might have entered either one wrong). With iteration, 
                //  as long as the payment is too small, we can keep asking them to re-enter.

                //Check to see if the payment is enough.If it isn't enough, loop so that you ask for 
                //    both the purchase price and the payment again. As long as the payment isn't enough, 
                //    you should continue to loop and ask for the amounts again.When the payment is finally enough, 
                //        you should compute and print out the change as before and end.
                //    In order to get both parts done, it will probably require one loop(purchase price > 0)  
                //        to be inside of another loop(payment is enough


                while (secondPayment < secondcost || secondcost <= 0)
                {
                    Console.WriteLine("You must pay a minimum payment of {0}, which was the cost of your items. You must also input " +
                        "a cost greater than 0 " +
                        "please re-enter the cost of your items. ", secondcost);
                    secondcost = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter how much you will pay for your items. ");
                    secondPayment = double.Parse(Console.ReadLine());

                    if (secondPayment == secondcost)
                    {
                        Console.WriteLine("Perfect! You've given exact change =] Have a nice day. ");
                    }
                    else if (secondPayment > secondcost)
                    {
                        Console.WriteLine("The amount you owe: $ {0} and the amount you have paid: $ {1}", secondcost, secondPayment);
                        (int twenties, double change) = Twenties(secondPayment, secondcost);  // how to get it to not print whats inside the method yet.
                        double change1 = Tens(change);
                        double change2 = Fives(change1);
                        double change3 = Ones(change2);
                        double change4 = Quarters(change3);
                        double change5 = Dimes(change4);
                        double change6 = Nickles(change5);
                        double change7 = Pennies(change6);

                    }
                }
            }


            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }



        }

        public static (int, double) Twenties(double secondPayment, double secondcost)
        {
            double change = secondPayment - secondcost;
            int twenties = (int)(change / 20);
            if (twenties != 0)
            {
                Console.WriteLine("Twenties Due: " + twenties);
            }

            change = change - (twenties * 20);
            return (twenties, change);
        }

        public static double Tens(double change)
        {

            int tens = (int)(change / 10);
            if (tens != 0)
            {
                Console.WriteLine("Tens Due: " + tens);
            }
            change = change - (tens * 10);
            return change;
        }

        public static double Fives(double change)
        {
            int fives = (int)(change / 20);
            if (fives != 0)
            {
                Console.WriteLine("Fives Due: " + fives);
            }
            change = change - (fives * 5);
            return change;
        }

        public static double Ones(double change)
        {

            int ones = (int)(change);
            if (ones != 0)
            {
                Console.WriteLine("Ones Due: " + ones);
            }
            change = change - ones;
            return change;
        }

        public static double Quarters(double change)
        {

            int quarters = (int)(change * 100) / 25;  // converted float change into an int
            if (quarters != 0)
            {
                Console.WriteLine("Quarters Due: " + quarters);
            }
            change = change - (float)(quarters * .25);
            return change;
        }

        public static double Dimes(double change)
        {

            int dimes = (int)(change * 100) / 10;  // converted float change into an int
            if (dimes != 0)
            {
                Console.WriteLine("Dimes Due: " + dimes);
            }
            change = change - (float)(dimes * .10);
            return change;
        }

        public static double Nickles(double change)
        {

            int nickles = (int)(change * 100) / 5;  // converted float change into an int
            if (nickles != 0)
            {
                Console.WriteLine("Nickles Due: " + nickles);
            }
            change = change - (float)(nickles * .05);
            return change;
        }

        public static double Pennies(double change)
        {

            int pennies = (int)(change * 100);  // converted float change into an int
            if (pennies != 0)
            {
                Console.WriteLine("Pennies Due: " + pennies);
            }
            change = change - (float)(pennies * .01);
            return change;
        }

        /// hold up ////////
        public static (double, double) secondRequest(string request1, string request2)
        {
            Console.WriteLine(request1);

            double secondCost = double.Parse(Console.ReadLine());
            Console.WriteLine(request2);
            double secondPayment = double.Parse(Console.ReadLine());
            return (secondCost, secondPayment);
        }

        public static double PurchaseAmount(string LookingFor)
        {
            Console.WriteLine(LookingFor);
            double cost = double.Parse(Console.ReadLine());
            return cost;
        }

        public static double PaymentAmount(string customerSays)
        {
            Console.WriteLine(customerSays);
            double payment = double.Parse(Console.ReadLine());
            return payment;
        }



    }
}