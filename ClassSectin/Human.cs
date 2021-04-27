using System;

namespace ClassSectin
{
    class Human
    {
     //number variable
     private string firstname;
     private string lastname;

     private string eyecolor;

     private int age;

    //constructor
     public Human(string firstname, string lastname, string eyecolor, int age){

         this.firstname = firstname;
         this.lastname = lastname;
         this.eyecolor = eyecolor;
         this.age = age;

     }
     
     //memebr method
     public void IntroudeMyself(){
         Console.WriteLine("Hi im {0} {1} {2} {3}",firstname, lastname,eyecolor, age);
     }

    }
}
