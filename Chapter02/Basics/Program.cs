using System;
using static System.Console;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {

                // Write("Type your first name and press ENTER ");
                // string firstname = ReadLine();
                // Write("Type your age and press ENTER ");
                // string age = ReadLine();
                // WriteLine($"Hello {firstname}, you look good for {age}");
                // Write("Press any key combination: ");
                // ConsoleKeyInfo key = ReadKey();
                // WriteLine();
                // WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
                // arg0: key.Key,
                // arg1: key.KeyChar,
                // arg2: key.Modifiers);
                //WriteLine($"There are {args.Length} arguments.");
                if (args.Length < 3)
{
  WriteLine("You must specify two colors and cursor size, e.g.");
  WriteLine("dotnet run red yellow 50");
  return; // stop running
}
ForegroundColor = (ConsoleColor)Enum.Parse(
  enumType: typeof(ConsoleColor), 
  value: args[0], 
  ignoreCase: true);
BackgroundColor = (ConsoleColor)Enum.Parse(
  enumType: typeof(ConsoleColor), 
  value: args[1], 
  ignoreCase: true);
  try {
CursorSize = int.Parse(args[2]);
  }
  catch{
        WriteLine("The current platform does not support changing the size of the cursor.");

  }


        }

    }

}
