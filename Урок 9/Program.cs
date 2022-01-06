using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор целых чисел. Что хотите посчитать?");
            Console.Write("Введите 1 число: ");
            int a, b, c;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите 2 число: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите номер операции: ");
                Console.WriteLine("\t1 - Сложение\r\n\t2 - Вычитание\r\n\t3 - Умножение\r\n\t4 - Деление");
                Console.Write("Ваш выбор: ");
                c = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введите число верно");
                Console.ReadKey();
                return;
            }
            while (true)
            {
                if (c == 0 || c >= 5 || c < 0)
                {
                    Console.WriteLine("Введено неверное число.\r\nВведите еще раз число от 1 до 4.");
                    Console.Write("Ваш выбор: ");
                    c = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            switch (c)
            {
                case 1:
                    {
                        Console.WriteLine("Складываю, секундочку");
                        Console.WriteLine("Сумма чисел = {0}", a + b);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Вычитаю, секундочку");
                        Console.WriteLine("Разность чисел = {0}", a - b);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Умножаю, секундочку");
                        Console.WriteLine("Произведение чисел = {0}", a * b);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Делю, секундочку");

                        try
                        {
                            Console.WriteLine("Частное = {0}", a / b);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Ошибка!");
                            Console.WriteLine(ex.Message);
                        }


                        break;
                    }
                default:
                    break;
            }

            Console.ReadKey();

        }
    }
}

