using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            while (znak != "+" || znak != "-" || znak != "*" || znak != "/")
            {
                Console.WriteLine("Задайте знак:\n(/ деление;* умножение;- вычитание;+ сложение)");
                znak = Console.ReadLine();
                if (znak == "-")
                    Console.WriteLine($"Результат {a - b}");
                else if (znak == "+")
                    Console.WriteLine($"Результат {a + b}");
                else if (znak == "/")
                    Console.WriteLine($"Результат {a / b}");
                else if (znak == "*")
                    Console.WriteLine($"Результат {a * b}");
                
            }
            Console.ReadKey();






        }
    }
}
