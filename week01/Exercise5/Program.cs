using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
         DisplayWelcomeMessage();//1. show welcome message
        string userName = GetUserName();//2. get user name
        int favoriteNumber = GetFavoriteNumber();//3. get favorite number
        int squaredNumber = SquareNumber(favoriteNumber);//4. square the number
        DisplayResult(userName, squaredNumber);//5. display result
        
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string GetUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }
        static int GetFavoriteNumber()
        {
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }
        static int SquareNumber(int number)
        {
            return number * number;
        }
        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}.");
        }
        


    }
}
