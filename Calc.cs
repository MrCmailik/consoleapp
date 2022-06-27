using System;
namespace _3.console
{
    internal class Calc
    {
        internal static void Run()
        {
            // Ввод чисел
            Console.WriteLine("Введите первое число");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double s = Convert.ToDouble(Console.ReadLine());
            // Выбор операции
            Console.WriteLine("Операции +, -, *, /, %, **");
            string operation = Console.ReadLine();
            // Определения кол-ва знаков для округления
            int lf = Convert.ToString(f).Length;
            int ls = Convert.ToString(s).Length;
            int roundleng = 0;

            if (lf < ls)
            {
                roundleng = ls;
            }
            else
            {
                roundleng = lf;
            }

            // Математические вычисления
            if (operation == "+")
            {
                Console.WriteLine(Math.Round(f+s, roundleng));
            }
            if (operation == "-")
            {
                Console.WriteLine(Math.Round(f-s, roundleng));
            }
            if (operation == "*")
            {
                Console.WriteLine(Math.Round(f*s, roundleng));
            }
            if (operation == "/")
            {
                Console.WriteLine(f/s);
            }
            if (operation == "%")
            {
                Console.WriteLine(Math.Round(f%s, roundleng));
            }
            if (operation == "**")
            {
                Console.WriteLine(Math.Pow(f, s));
            }
            // Обработка исключения
            if (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "%" && operation != "**")
            {
                Console.WriteLine("Ошибончый тип операции");
            }
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
            // Повторный запуск калькулятора
            Run();
        }
    }
}
