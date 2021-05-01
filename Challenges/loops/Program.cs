using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int counter = 0;
            string entered = "";
            bool validint;
            int finalnumber;
            int averagescore;

           while (entered != "-1"){
               Console.WriteLine("Please enter student score or -1 to quit ");
               entered = Console.ReadLine();
               validint = int.TryParse(entered, out finalnumber);
               if (validint && finalnumber > 0 && finalnumber < 20){
                   total += finalnumber;
                   counter++;
                   Console.WriteLine(counter);
                   Console.WriteLine(total);
               }else{
                   Console.WriteLine("not a valid number. Please enter -1 to quit");
               }
               
           }

           averagescore = (total/counter);
           Console.WriteLine(averagescore);
        
            
        }
    }
}
