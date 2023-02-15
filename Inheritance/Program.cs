using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird myBird= new Bird();
            myBird.CanFly = true;
            myBird.EatsMeat = true;
            myBird.ears = 0;
            myBird.IsSmall = true;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile myReptile = new Reptile();
            myReptile.HasShell = true;
            myReptile.LivesInWater = true;
            myReptile.IsLarge = true;
            myReptile.legs = 0;
            Console.WriteLine("Properties of reptile");
            Console.WriteLine(myReptile.HasShell);
            Console.WriteLine(myReptile.LivesInWater);
            Console.WriteLine(myReptile.IsLarge);
            Console.WriteLine(myReptile.legs);
            Console.WriteLine();
            Console.WriteLine("Properties of bird");
            Console.WriteLine(myBird.eatsMeat);
            Console.WriteLine(myBird.CanFly);
            Console.WriteLine(myBird.ears);
            Console.WriteLine(myBird.IsSmall);

        }
        
    }
}
