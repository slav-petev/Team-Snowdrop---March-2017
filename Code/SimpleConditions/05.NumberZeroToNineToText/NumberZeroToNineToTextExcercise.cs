﻿using System;

namespace _05.NumberZeroToNineToText
{
    class NumberZeroToNineToTextExercise
    {
        static void Main(string[] args)
        {
            var number = int.Parse(
                Console.ReadLine());

            if (number >= 10)
            {
                Console.WriteLine("number too big");
            }
            else if (number == 1)
            {
                Console.WriteLine("one");
            }
            else if (number == 2)
            {
                Console.WriteLine("two");
            }
            else if (number == 3)
            {
                Console.WriteLine("three");
            }
            else if (number == 4)
            {
                Console.WriteLine("four");
            }
            else if (number == 5)
            {
                Console.WriteLine("five");
            }
            else if (number == 6)
            {
                Console.WriteLine("six");
            }
            else if (number == 7)
            {
                Console.WriteLine("seven");
            }
            else if (number == 8)
            {
                Console.WriteLine("eight");
            }
            else if (number == 9)
            {
                Console.WriteLine("nine");
            }
        }
    }
}
