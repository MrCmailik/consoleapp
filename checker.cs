/* Не трогайте это, оно и так не работает */
using System;

namespace _3.console{
    internal class checker{
        internal static void run(){
            string[] names = {"Алексей", "Мария", "Илья", "Артём"};
            string psswrd = "1230";
            Console.WriteLine("Введите логин");
            string log = Console.ReadLine();
            string key = " ";
            foreach (string name in names){
                if (name.Equals(log)){
                    Console.WriteLine("Логин верный, введите пароль");
                    key = Console.ReadLine();
                    if (key.Equals(psswrd)){
                        Console.WriteLine("Вход выполнен!"); break;
                    }
                    else {Console.WriteLine("Пароль-- Неправильный пароль!"); break;}
                }
                else
                {
                    Console.WriteLine("Неправильный логин!"); break;
                }
            }
        }
    }
}