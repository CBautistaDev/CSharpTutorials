using System;

namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter First number to add ");
           string input = Console.ReadLine();
           Console.WriteLine("Enter Second number to add ");
           string input2 = Console.ReadLine();

           int number = Add(Convert.ToInt32(input), Convert.ToInt32(input2));
           Console.WriteLine(number);

        }

         public static int Add(int parameter1, int paramter2){
            return parameter1 * paramter2;
        }
    }
}
