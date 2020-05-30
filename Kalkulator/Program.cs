using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте знак:\n(/ деление;* умножение;- вычитание;+ сложение)");
            var znak = Console.ReadLine();
            if (znak == "-")
                Console.WriteLine($"Результат {a - b}");
            else if (znak == "+")
                Console.WriteLine($"Результат {a + b}");
            else if (znak == "/")
                Console.WriteLine($"Результат {a / b}");
            else if (znak == "*")
                Console.WriteLine($"Результат {a * b}");
            Console.ReadKey();






        }
    }
}
