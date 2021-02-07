using System;

namespace Console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine ("Greetings, " + name);
            //Area of desired rectangle
            Console.WriteLine("Please enter a random length of a rectangle: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a random width: ");
            int width = int.Parse(Console.ReadLine());
            int area = length * width;
            Console.WriteLine("Your rectangle's area is " + area);
            //Miles per gallon
            Console.WriteLine("Please enter your number of miles driven: ");
            int miles = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your number of gallons: ");
            int gallons = int.Parse(Console.ReadLine());
            Console.WriteLine("You drove " + miles + " miles per " + gallons + " gallons.");
        }
    }
}
