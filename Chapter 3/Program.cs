using System;

using static System.Console;

namespace Chapter_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool a = true;
            // bool b = false;
            // WriteLine($"a & DoStuff() = {a && DoStuff()}");
            // WriteLine($"b & DoStuff() = {b && DoStuff()}");
            A_label:
            var number = (new Random()).Next(1, 7);
        WriteLine($"My random number is {number}");
        switch (number)
        {
        case 1:
            WriteLine("One");
            break; // jumps to end of switch statement 
        case 2:
            WriteLine("Two");
            goto case 1;
        case 3:
        case 4:
            WriteLine("Three or four");
            goto case 1;
        case 5:
            // go to sleep for half a second
            System.Threading.Thread.Sleep(500);
            goto A_label;
        default:
            WriteLine("Default"); 
            break;
} // end of switch statement
        }

        private static bool DoStuff()
            {
                WriteLine("I am doing some stuff.");
                return true;
            }
    }
}
