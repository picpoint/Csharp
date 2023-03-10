using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите команду: ");
            Console.WriteLine("1 - Сложить числа");
            Console.WriteLine("2 - Вычисть числа");
            Console.WriteLine("3 - Умножить числа");
            Console.WriteLine("4 - Разделить числа");
            Console.WriteLine("5 - Завершить программу");

            Console.WriteLine();

            int numbCommand = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (numbCommand == 5)
            {
                Console.WriteLine("Всего доброго!!!");
                Console.ReadKey();
                return;
            }
            
            if (numbCommand != 1 && numbCommand != 2 && numbCommand != 3 && numbCommand != 4 && numbCommand != 5)
            {
                Console.WriteLine("Введена неизвестная команда ...");
                Console.ReadKey();
                return;
            }

            Console.Write("Введите первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());
            
            
            if (numbCommand == 1)
            {
                Console.WriteLine($"Результат сложения: {x + y}");
            }
            else if (numbCommand == 2) 
            {
                Console.WriteLine($"Результат вычитания: {x - y}");
            } else if (numbCommand == 3) 
            {
                Console.WriteLine($"Результат умножения: {x * y}");
            } else if (numbCommand == 4) 
            {
                Console.WriteLine($"Результат деления: {x / y}");
                Console.WriteLine($"Остаток деления: {x % y}");
            }             
            
            Console.ReadKey();
        }
    }
}
