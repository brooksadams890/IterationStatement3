using System;

namespace ItStatement3
{
    internal class Program
    {
        public static void Print1000s()
        {
            for (var i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintThrees()
        {
            for (var i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }
        public static void TwoIntsEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Those numbers are equal.");
            }
            else
            {
                Console.WriteLine("Those numbers are NOT equal.");
            }
        }

        public static void OddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine($"{number} is odd.");
            }
            else
            {
                Console.WriteLine($"{number} is neither odd nor even.");
            }

        }

        public static void MultiTable()
        {
            bool userResponse;
            int result;

            do
            {
                Console.WriteLine("Enter an integer:");
                userResponse = int.TryParse(Console.ReadLine(), out result);
            } while (!userResponse); 

            for(var x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{x} x {result} = {x * result}");
            }
        }

        public static void AgeCheck()
        {
            bool userAge;
            int result;

            do
            {
                Console.WriteLine("Please enter your age:");
                userAge = int.TryParse(Console.ReadLine(), out result);
            } while (!userAge);

            if(result < 18)
            {
                Console.WriteLine("Very sorry. You are not old enough to vote.");
            }
            else
            {
                Console.WriteLine("Congrats! You can vote.")
            }
        }
        public static void InRange()
        {
            bool userResponse;
            int result;

            do
            {
                Console.WriteLine("Enter an integer.");
                userResponse = int.TryParse(Console.ReadLine(), out result);
            } while (!userResponse);
            
            if(result >= -10 && result <= 10)
            {
                Console.WriteLine($"{result} is between 10 & -10.");
            }
            else
            {
                Console.WriteLine($"{result} is Not between 10 & -10.");
            }
        }

       
        

        public static void PositiveOrNegative(int num)
        {
            if(num > 0)
            {
                Console.WriteLine($"{num} is positive.");
            }
            else if(num < 0)
            {
                Console.WriteLine($"{num} is odd.");
            }
            else
            {
                Console.WriteLine($"{num} is niether positive nor negative.");
            }
        }

       

        static void Main(string[] args)
        {
            //PrintThrees();

            //TwoIntsEqual(75, 50);
            //Console.WriteLine();
            //TwoIntsEqual(5, 5);
            
        }
    }
}
