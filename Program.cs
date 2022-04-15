using System;

namespace Star_Rating_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type your number and press enter
            Console.Write("Enter a number between 1 to 5: ");

            //Create a variable and get user input from the keyboard and store it in the variable
            decimal StarRating = Convert.ToDecimal(Console.ReadLine());
            decimal i = 1;

            //Create a loop to print output
            do
            {
                Console.Write("Full ");
                i++;
            }
            while (i <= StarRating);
            {
                Console.Write("Half ");
            }
        }
    }
}
