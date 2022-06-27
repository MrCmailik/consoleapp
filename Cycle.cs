using System;
namespace _3.console
{
    internal class Cycle
    {
        internal static void Run()
        {
            // Пример счёта до десяти через разные циклы
            #region WhileExample
            /*int n = 0;
            while (n <= 10)
            {
                   Console.WriteLine(n);
                   n++;
            }
            n = 0;
            Console.WriteLine("---------------");
            */
            #endregion
            #region ForeachExample
            /*
            float[] ns = {1,2,3,4.4f,5,6,7,8f,9,0f}; //Массив дробей чисел
            foreach (float n in ns)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("---------------");
            */
            #endregion
            #region DowhileEample
            /*
            int n = 0;
            do
            {
                Console.WriteLine(n);
                n++;
            } while (n <= 10);
            Console.WriteLine("---------------");
            */
            #endregion
            #region ForExample
            for (int n = 0; n <= 10; n++)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("---------------");
            #endregion
        }
    }
}