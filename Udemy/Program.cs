using System;

namespace Udemy
{
    class Program
    {
        static int age = 15;

        static void Main(string[] args)
        {
            // int num1 = 13;
            // int num2 = 5;
            // int sum = num1 + num2;

            // Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            // Console.Read();

            //string variables on main
            string myname = "Denis";
            string message = "my name is " + myname;
            string capsMessage = message.ToUpper();
            string lowermessage = message.ToLower();

            Console.WriteLine(capsMessage);
            Console.WriteLine(lowermessage);
            Console.Read();

        }
    }
}
