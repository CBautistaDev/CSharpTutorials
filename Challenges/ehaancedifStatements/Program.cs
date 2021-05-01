using System;

namespace ehaancedifStatements
{
    class Program
    {
        static void Main(string[] args){
        // {
        //     int number;
        //     string results;
        //     string check;
            
        //     Console.WriteLine("Please input number: ");
        //     string input = Console.ReadLine();

        //     results = int.TryParse(input,number);

        //     check = results==true && number >= 15 ? "it is to cold here": 
        //                 results==true && number >= 16 && number <= 28 ? "it is okay": 
        //                 results == false ? "not a valid number": "check";
        int inputTemp = 0;
        string temperatureMessage = string.Empty;
        string inputvalue = string.Empty;

        Console.WriteLine("Enter the current temperatrure: ");
        inputvalue = Console.ReadLine();


        //validate the input as valid innput integer value
        bool validinteger = int.TryParse(inputvalue, out inputTemp);

        if (validinteger){
            temperatureMessage = inputTemp <= 15 ? "it is cold here" : 
            inputTemp >= 16 && inputTemp <=28 ? "it is cold here":
            inputTemp > 28 ? "it is hot here" : " ";

            Console.WriteLine(temperatureMessage);
        }else{
            Console.WriteLine("not an integer");
        }
            
        }
    }
}
