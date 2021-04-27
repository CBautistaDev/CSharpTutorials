using System;

namespace ClassSectin
{
    class Program
    {
        static void Main(string[] args)
        {
            Human denis = new Human("deniss", "bautista","black",90);
            Human carlos = new Human("Carlos","Bautista","Red",90);
           
            denis.IntroudeMyself();
            carlos.IntroudeMyself();
        }
    }
}
