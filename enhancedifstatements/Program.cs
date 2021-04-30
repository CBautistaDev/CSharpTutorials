using System;

namespace enhancedifstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = -5;
            string stateofmatter;

            if (temperature < 0){
                stateofmatter = "solid";
            }else{
                stateofmatter = "liquid";
            }
            Console.WriteLine("State of matter is {0}", stateofmatter);

            //in short
            stateofmatter = temperature < 0 ? "solid":"liquid";
        }
    }
}
