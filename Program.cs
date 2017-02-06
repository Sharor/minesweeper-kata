using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(Tests.NoUnitTests())
            {
                Console.WriteLine("Hello Minesweeper Kata!");
            } 
            else
            {
                Console.WriteLine("This is my current implementation of a unit test failing!");
            }
        }
    }
}
