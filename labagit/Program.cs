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
            double res2 = A - B;
            Console.WriteLine("Результат вычитания А и В - " + Convert.ToString(res2));
            double res3 = A * B;

            Console.WriteLine("Результат умножения А и В - " + Convert.ToString(res3));
        }
    }
}
