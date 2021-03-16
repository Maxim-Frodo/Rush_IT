using System;
using System.Collections.Generic;

namespace Zad3med
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list1 = new List<int>();
            Console.WriteLine("Ввод 1 числа (введите не цифру для завершения):");
            while (1 == 1)
            {
                if (list1.Count == 100)
                {
                    Console.WriteLine("Достигнут лимит вводимых чисел");
                    break;
                }

                string temp = Console.ReadLine();
                int www;
                if (!int.TryParse(temp, out www))
                {
                    if (list1.Count == 0) Console.WriteLine("Массив пуст");
                    else break;
                }
                else
                {
                    int num = Convert.ToInt32(temp);
                    if (num < 0 || num > 9)
                    {
                        Console.WriteLine("Введите корректное значение");
                    }
                    else list1.Add(num);
                }
            }

            List<int> list2 = new List<int>();
            Console.WriteLine("Ввод 2 числа (введите не цифру для завершения):");
            while (1 == 1)
            {
                if (list2.Count == 100)
                {
                    Console.WriteLine("Достигнут лимит вводимых чисел");
                    break;
                }

                string temp = Console.ReadLine();
                int www;
                if (!int.TryParse(temp, out www))
                {
                    if (list2.Count == 0) Console.WriteLine("Массив пуст");
                    else break;
                }
                else
                {
                    int num = Convert.ToInt32(temp);
                    if (num < 0 || num > 9)
                    {
                        Console.WriteLine("Введите корректное значение");
                    }
                    else list2.Add(num);
                }
            }

            int value1 = 0, value2 = 0;
            for (int i=list1.Count-1; i>=0; i--)
            {
                value1 += list1[i];
                value1 *= 10;
            }
            value1 /= 10;

            for (int i = list2.Count - 1; i >= 0; i--)
            {
                value2 += list2[i];
                value2 *= 10;
            }
            value2 /= 10;

            int value3 = value1 + value2;

            while (value3>0)
            {
                Console.Write(value3 % 10);
                if (value3 >= 10) Console.Write(", ");
                value3 /= 10;
            }
        }
    }
}
