using System;
using System.Text;
using System.Threading.Tasks;

namespace calculator_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double memory = 0; // Память калькулятора
            string value;
            
            do
            {
                Console.WriteLine("\n=== КАЛЬКУЛЯТОР ===");
                Console.WriteLine("Доступные операции:");
                Console.WriteLine("+, -, *, /, % - основные операции");
                Console.WriteLine("1/x - обратное число");
                Console.WriteLine("x^2 - квадрат числа");
                Console.WriteLine("sqrt - квадратный корень");
                Console.WriteLine("m+ - добавить в память");
                Console.WriteLine("m- - вычесть из памяти");
                Console.WriteLine("mr - показать память");
                Console.WriteLine("clear - очистить память");
                Console.WriteLine("===================");

                Console.Write("Выберите операцию: ");
                string operation = Console.ReadLine().ToLower();

                double num1, num2;
                double result = 0;

                if (operation == "+")
                {
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 + num2;
                    Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                }
                else if (operation == "-")
                {
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 - num2;
                    Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                }
                else if (operation == "*")
                {
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 * num2;
                    Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                }
                else if (operation == "/")
                {
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 / num2;
                    Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                }
                else if (operation == "%")
                {
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 % num2;
                    Console.WriteLine($"Результат: {num1} % {num2} = {result}");
                }
                else if (operation == "1/x")
                {
                    Console.Write("Введите число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = 1 / num1;
                    Console.WriteLine($"Результат: 1 / {num1} = {result}");
                }
                else if (operation == "x^2")
                {
                    Console.Write("Введите число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = num1 * num1;
                    Console.WriteLine($"Результат: {num1}² = {result}");
                }
                else if (operation == "sqrt")
                {
                    Console.Write("Введите число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = Math.Sqrt(num1);
                    Console.WriteLine($"Результат: √{num1} = {result}");
                }
                else if (operation == "m+")
                {
                    Console.Write("Введите число для добавления в память: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    memory += num1;
                    Console.WriteLine($"Добавлено в память: {num1}");
                    Console.WriteLine($"Текущее значение памяти: {memory}");
                }
                else if (operation == "m-")
                {
                    Console.Write("Введите число для вычитания из памяти: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    memory -= num1;
                    Console.WriteLine($"Вычтено из памяти: {num1}");
                    Console.WriteLine($"Текущее значение памяти: {memory}");
                }
                else if (operation == "mr")
                {
                    Console.WriteLine($"Текущее значение памяти: {memory}");
                }
                else if (operation == "clear")
                {
                    memory = 0;
                    Console.WriteLine("Память очищена");
                }
                else
                {
                    Console.WriteLine("Неверная операция!");
                }

                Console.Write("Хотите продолжить? (y/n): ");
                value = Console.ReadLine().ToLower();
            }
            while (value == "y" || value == "д");
        }
    }
}