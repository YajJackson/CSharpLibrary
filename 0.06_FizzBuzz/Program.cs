﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


            // using ternary

            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(
            //        i % 15 == 0 ? "FizzBuzz" :
            //        i % 5 == 0 ? "Buzz" :
            //        i % 3 == 0 ? "Fizz" :
            //        i.ToString()
            //    );
            //}
        }
    }
}
