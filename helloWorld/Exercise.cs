using System;
using System.Linq;

namespace helloWorld
{
    public class Exercise
    {
        public void exerciseProblems()
        {
            //countDivisible();
            //calculateSum();
            //guessNumber();
            maxInputNumber();
        }

        public static void maxInputNumber()
        {
            Console.Write("Enter a series of numbers seperated by comma : ");
            var userInput = Console.ReadLine();
            string[] inputNumbers = userInput.Split(',');

            int[] numbers = Array.ConvertAll(inputNumbers, int.Parse);
            Console.WriteLine(numbers.Max());
        }

        public static void guessNumber()
        {
            var number = new Random();
            int trueNumber = number.Next(1, 10);
            var guessAttempt = 3;
            Console.WriteLine("True Number is {0} ", trueNumber);
            for (int i = 1; i <= guessAttempt; i++)
            {
                Console.Write("Enter the number to guess : ");
                int guessNumber = Convert.ToInt32(Console.ReadLine());
                if(guessNumber == trueNumber)
                {
                    Console.WriteLine("Congratulations! You guessed it right.");
                    break;
                }

                if(guessNumber != trueNumber && i == guessAttempt)
                    Console.Write("Sorry! No more chance is left.You lost the game.");
            }
            
        }

        public static void countDivisible()
        {
            var count = 0;
            for(var i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("{0} numbers are divisible by 3 between 1 and 100", count);
        }

        public static void calculateSum()
        {
            var isExit = false;
            var count = 0;
            while(!isExit)
            {
                Console.Write("Enter any number or ok to exit : ");
                var input = Console.ReadLine();
                if(input == "ok")
                {
                    isExit = true;
                } else
                {
                    count += Convert.ToInt32(input);
                }
            }
            Console.WriteLine("Total sum of entered numbers are {0}.", count);
        }
    }
}
