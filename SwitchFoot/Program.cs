using System;

namespace SwitchFoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            var subject = Console.ReadLine();
            switch (subject)
            {
                case "algebra":
                    Console.WriteLine("You must be right minded");
                    break;

                case "English":
                    Console.WriteLine("You must be left minded");
                    break;

                case "calculus":
                    Console.WriteLine("You must be out of your mind");

                    break;
                case "golf":
                    Console.WriteLine("You must be a great student");
                    break;
                default:
                    Console.WriteLine($"Really? You need to get out more often");
                    break;

            }
            




            
        }
    }
}
