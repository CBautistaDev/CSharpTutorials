using System;

namespace IfStatements
{
    class Program
    {      static string username;
            static string password;
        static void Main(string[] args)
        {
           

            Regiser();
            Login();

        
        }

        static public void Regiser(){
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your Password");

            password = Console.ReadLine();
            Console.WriteLine("registration compelted");
            Console.WriteLine("------------------------");

        }

        static public void Login(){
            Console.WriteLine("Please enter username !");
            string UsernameInput = Console.ReadLine();
            Console.WriteLine("Please enter password! ");
            string PasswordInput = Console.ReadLine();

            if (UsernameInput.Equals(username) && PasswordInput.Equals(password)){
                Console.WriteLine("You are logged in");
            }else{
                Console.WriteLine("Incorrect username {0} or password.",UsernameInput);
            }

        }
    }
}
