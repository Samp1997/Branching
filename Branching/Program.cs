using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int weightMax = 50;
            int widthMax = 50;
            int heightMax = 50;
            int lengthMax = 50;

            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("hi,  " + name + " welcome to package express. please follow the instructions below");

            Console.WriteLine(name + "How much does your package weigh?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            
            

            if (packageWeight == weightMax)
            {
                Console.WriteLine("Package is good to send.");
            }
            else if (packageWeight > weightMax)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");

            }
            Console.WriteLine( name + "  what is the width of this package?");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            
            if (packageWidth > widthMax)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            }
            Console.WriteLine(name + "  what is the height of this package?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            if (packageHeight > heightMax)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            }

            Console.WriteLine(name + "  what is the length of this package?");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            if (packageLength > lengthMax)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            }

            Console.WriteLine("Your estimated total for shipping this package is:" + packageHeight * packageWeight * packageLength + "$");


            

            
        }
    }
}
