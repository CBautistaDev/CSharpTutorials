using System;

namespace MethodError
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();

            

            int number1 = 0;
            int result;

            try{

                int userinpurtAsInt = int.Parse(userInput);
                result = userinpurtAsInt / number1;

            }
            catch(FormatException){

                Console.WriteLine("Format Excpetion, please enter the correct next time");

            }catch(OverflowException){

                Console.WriteLine("genereal exception");
            }catch(DivideByZeroException){
                Console.WriteLine("cant dive by zero");
            }
            finally{
                Console.WriteLine("This is called anyways");
            }

            Console.ReadKey();
        }

    }
}
