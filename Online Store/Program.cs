using System;

namespace Online_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Firstname = "Ben";
            customer1.Lastname = "Griffin";
            customer1.OrderNum = 138456;

            string message = "Order number of customer " + customer1.Firstname + " " + customer1.Lastname + " is: " + customer1.OrderNum + ".";
            Console.Write(message);
        }
    }
}
