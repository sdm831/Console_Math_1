using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Math_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //version 2 from PC
            Console.WriteLine("Привет, Алена, давай посчитаем!");
            string good = "Алена молодец!!!";
            string bad = "!!! Ошибка, правильный ответ: ";
            int ans;
            Random rnd = new Random();
            while (true) {
                int value1 = rnd.Next(4, 20);
                int value2 = rnd.Next(4, 20);
                // Сложение
                Console.WriteLine("Сколько будет" + " " + value1 + " + " + value2);
                ans = Convert.ToInt32(Console.ReadLine());
                if (ans == value1 + value2)
                {
                    Console.WriteLine(good);
                    Console.WriteLine("-----------------------------------------------------------");
                }
                else { 
                    Console.WriteLine(bad + (value1 + value2));
                    Console.WriteLine("-----------------------------------------------------------");
                }
                // Вычитание
                Console.WriteLine("Сколько будет" + " " + value1 + " - " + value2);
                ans = Convert.ToInt32(Console.ReadLine());
                if (ans == value1 - value2)
                {
                    Console.WriteLine(good);
                    Console.WriteLine("-----------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine(bad + (value1 - value2));
                    Console.WriteLine("-----------------------------------------------------------");
                }
            }


            }
    }
}
