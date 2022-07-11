using System;
namespace MethodsWithLoopsAndConditionals
{
    public class Methods
    {
        #region Heatin' Up Section

        // Write a method that will print to the console all numbers 1000 through -1000

        public static void OneThousandEitherWay()
        {
            for (int i = 1000; i >= -1000; i--)
                Console.WriteLine($"{i}");
        }

        // Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void ThreeEachTime()
        {
            for (int i = 3; i <= 999; i+=3)
                Console.WriteLine($"{i}");
        }

        // Write a method to accept two integers as parameters and check whether they are equal or not

        public static void EqualOrNot(int x, int y)
        {
            if (x == y) {
                Console.WriteLine("You betcha they're the same!");
            }
            else
                Console.WriteLine("They're clearly not the same number... come on now.");
        }

        // Write a method to check whether a given number is even or odd

        public static void EvenOrOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("you've got youself an even number!");
            }
            else
                Console.WriteLine("Well... that's a little odd");
        }

        // Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative(int x)
        {
            if (x > 0)
            {
                Console.WriteLine("This number is positive");
            }
            else if (x < 0)
            {
                Console.WriteLine("This number is negative");
            }
            else
                Console.WriteLine("This number is neither positive or negative, it is nothing!");
        }

        // Write a method to read the age of a candidate and determine whether they can vote

        public static void CanYouVote(int x)
        {
            if (x > 79)
            {
                Console.WriteLine($"Yeah, sure... you CAN vote at {x}, but should you?");
            }
            else if (x >= 18)
            {
                Console.WriteLine($"You're {x}, you can vote! Get out there! Do your civic duty!");
            }
            else
            {
                Console.WriteLine($"You can't vote, but you will be able to in {18 - x} years, so stay informed!");
            }
        }
        #endregion

        #region Heatin' Up Section

        // Write a method to check if an integer (from the user) is in the range -10 to 10

        //public static int AcceptedRange(int x)
        //    {
        //        Console.Write("Please enter a number");
        //        return Console.ReadLine();

        //        if (x >= -10 && x <= 10)
        //        {
        //            Console.WriteLine($"{x} is between -10 and 10, that is acceptable");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{x} isn't between -10 and 10, get outta here with that!")
        //        }
        //    }

        ////


        // Write a method to display the multiplication table (from 1 to 12) of a given integer

        //public static void MultiplicationTables(int x)
        //{
        //    if (x <= 12 && x >= 1)
        //    {
        //        do
        //        {
        //            Console.WriteLine(x);
        //            x += x;
        //        } while (x < 1000);
        //    }
        //}

        // I misunderstood and was trying to write every multiple of a given number

        public static void MultiplicationTables(int x)
        {
            var twelve = 12;
            
        }


        #endregion
    }
}


