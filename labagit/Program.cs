﻿using System;

namespace labagit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводи число А ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вводи число B ");
            double B = Convert.ToDouble(Console.ReadLine());
            double res1 = A + B;
            Console.WriteLine("Результатом сложения А и B будет" + Convert.ToString(res1));
        }
    }
}
