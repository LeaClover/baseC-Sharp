using System;

namespace HomeWork1 {
    internal class Program {
        private static void Main(string[] args) {

            if(args.Length == 3) {
                /*Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a* b, введенные из командной строки, и выводящую результат выполнения на экран.*/
                double result = 0;

                if (args[1] == "+") {
                    result = double.Parse(args[0]) + double.Parse(args[2]);
                    Console.WriteLine($"{args[0]} + {args[2]} = {Math.Round(result, 2)}");
                } else if (args[1] == "-") {
                    result = double.Parse(args[0]) - double.Parse(args[2]);
                    Console.WriteLine($"{args[0]} - {args[2]} = {Math.Round(result, 2)}");
                } else if (args[1] == "*") {
                    result = double.Parse(args[0]) * double.Parse(args[2]);
                    Console.WriteLine($"{args[0]} * {args[2]} = {Math.Round(result, 2)}");
                } else if (args[1] == "/") {
                    if (args[2] != "0") {
                        result = double.Parse(args[0]) / double.Parse(args[2]);
                        Console.WriteLine($"{args[0]} * {args[2]} = {Math.Round(result, 2)}");
                    } else {
                        Console.WriteLine("Error. Division by zero");
                    }

                } else {
                    Console.WriteLine("Error. Need view: number (+-*/) number");
                }
            }
        }
    }
}