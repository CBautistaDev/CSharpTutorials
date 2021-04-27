using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion 
            int num = 123456;
            long bignum = num;

            float myfloat = 12.39f;
            double mynewdouble = myfloat;

            double mydouble = 13.37;
            int myInt;

            //explicit conversion 
            //cast double to int
            myInt = (int)mydouble;

            //type conversion 
            string mystring = mydouble.ToString();
            string myfloatString = myfloat.ToString();
            bool sunisShining =false;
            
            //Bool to string
            string mybool = sunisShining.ToString();

            Console.WriteLine(mystring);
            Console.WriteLine(myfloatString);
            Console.ReadKey();
            string readinput = Console.ReadLine();
            Console.WriteLine(readinput);


            int asccivalue = Console.Read();
            Console.WriteLine(asccivalue);
            Console.ReadKey();
        }
    }
}
