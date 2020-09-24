using System;

namespace Modellering_Stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Stuff s1 = new Stuff(5,6,true);
            Stuff s2 = new Stuff(9,1,false);
            Stuff s3 = new Stuff(3,10,true);
            Stuff s4 = new Stuff(7,2,false);
            System.Console.WriteLine( $"Health: {s1.getHealth()} Shield: {s1.getShield()} Moving: {s1.isMoving()}" );
            System.Console.WriteLine( $"Health: {s2.getHealth()} Shield: {s2.getShield()} Moving: {s2.isMoving()}" );
            System.Console.WriteLine( $"Health: {s3.getHealth()} Shield: {s3.getShield()} Moving: {s3.isMoving()}" );
            System.Console.WriteLine( $"Health: {s4.getHealth()} Shield: {s4.getShield()} Moving: {s4.isMoving()}" );
            Console.ReadLine();
        }
    }
}
