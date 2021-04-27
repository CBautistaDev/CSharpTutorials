using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("Carlos is learning");
            int result = multiply(15 ,31);
            Console.WriteLine(result);
        }

        //access modifier(static) (return type) (methond name)
        public static void WriteSomething(){
            Console.WriteLine("I am called by a metohd");
        }

        public static void WriteSomethingSpecific(string mytext){
            Console.WriteLine(mytext);
        }

        public static int Add(int parameter1, int paramter2){
            return
            parameter1 + paramter2;
        }

        public static int multiply(int one, int two){
            return one * two;
            
        }

        public static double divide(double num1, double num2){
            return num1 / num2;
        }
    }
}
