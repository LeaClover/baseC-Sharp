using System;

namespace Seminar1 {
    internal class Program {
        private static void Main(string[] args) {
            if(args.Length > 1) {
                /* Сложение аргументов*/

                /*int num1 = int.Parse(args[0]);
                int num2 = int.Parse(args[1]);

                int sum = num1 + num2;

                Console.WriteLine($"{num1} + {num2} = {sum}");*/

                /* Перебор аргументов и вывод в консоль */

                /*foreach (var item in args) {
                    Console.Write($"{item}, ");
                }*/

                /*Console.WriteLine(string.Join(", ", args));*/

                /* Поиск среднего арифметического числа */

                /*    int sum = 0;
                    foreach (string arg in args) 
                    {
                        sum += int.Parse(arg);
                    }
                    int avg = sum / args.Length;
                    Console.WriteLine(avg);*/

                /* Другой вариант поиска среднего арифметического числа */

                /* int[] array = Array.ConvertAll(args, int.Parse);

                 int avg = array.Sum() / args.Length;

                 Console.WriteLine($"AVG = {avg}");*/

                int[] arr = Array.ConvertAll(args, int.Parse);

                int min = int.MaxValue;

                foreach (int numb in arr)
                {
                    if (min > numb) {
                        min = numb;
                    }
                }
                Console.WriteLine(min);

            } else {
                Console.WriteLine("Need args");
            }
        }
    }
}