using System;

namespace Challenges
{
    class Program
    {
        //create three varaibles with names of your friends
        static string name1 = "Carlos";
        static string name2 = "Wesley";
        static string name3 = "Andrew";
        static void Main(string[] args)
        {
            GreetFriend(name1);
            GreetFriend(name2);
            GreetFriend(name3);

        }

        //Create method greedfriend which writes Hi Frnakem
        public static void GreetFriend(string friend1){
            Console.WriteLine("Hi " + friend1 + " my friend!");
        }
    }
}
