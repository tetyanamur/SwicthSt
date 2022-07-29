using System;

namespace SwitchSt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var response = Console.ReadLine();
            switch (response)
            {
                case "Literature":
                    Console.WriteLine($"Literature is for erudites");
                    break;
                case "Science":
                    Console.WriteLine("Science teaches about nature");
                    break;
                case "Math":
                    Console.WriteLine("Math shows students how to read numbers");
                    break;
                case "Art":
                    Console.WriteLine("Art is great to develop creativity");
                    break;
                case "History":
                    Console.WriteLine("History is very informative regarding time");
                    break;
                default:
                    Console.WriteLine("Awesome. This is a new subject for me to learn about");
                    break ;
            }
        }
    }
}
