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
                i++;
                Console.Write("Full ");
            }
            while (i <= StarRating);
            decimal Decimal = Convert.ToDecimal((StarRating - i) + 1);
            if (Decimal > 0)
            {
                Console.Write("Half ");
            }
            else
            {
                Console.Write("Empty ");
            }

            //Create something that subtracts 5 from user input
            decimal Reduce = 5 - StarRating;

            //Create another loop that completes the code
            for (decimal j = 1; j < Reduce; j++)
            {
                Console.Write("Empty ");
            }
        }
    }
}
