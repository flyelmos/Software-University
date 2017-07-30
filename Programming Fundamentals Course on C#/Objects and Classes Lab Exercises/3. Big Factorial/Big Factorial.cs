﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _3.Big_Factorial
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}