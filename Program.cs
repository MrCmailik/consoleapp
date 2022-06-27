/* Пример использования внешних модулей */
using System;

namespace _3.console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Выбор модуля
            int x = 0;
            Console.WriteLine("ЗДрассссьте");
            Console.WriteLine("1.Calc");
            Console.WriteLine("2.Cycle");
            Console.WriteLine("4.Exit");
            
            char oper = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            // Запуск выбранного модуля (или выход)
            switch(oper){
                case '1': Calc.Run(); break;
                case '2': Cycle.Run(); break;
                case '3': checker.run(); break; //secret
                case '4': Console.WriteLine(0/x); break;
                default:Console.WriteLine("Досвидания"); break;
            }






        }
    }
}