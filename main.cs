using System;
//main
class MainClass {
  public static void Main (string[] args) {
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
    //If statement
    Console.WriteLine("Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it. She didn't know the use of a book without pictures in it, or even a conversation.");
    Console.WriteLine("Please search for and enter a string, within this string.");
    string alice = Console.ReadLine();
    if (alice == alice)
    {
      Console.WriteLine("true");
    }
  }
}