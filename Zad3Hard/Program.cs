using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad3Hard
{
    class Program
    {
        public static int Trap(int[] height)
        {
            int counter = 0;
            List<int> index_list = new List<int>();
            while (height.Max() != 0)
            {
                for (int i = 0; i < height.Length; i++)
                {
                    if (height[i] == height.Max())
                    {
                        index_list.Add(i);
                        height[i] -= 1;
                    }
                }
                if (index_list.Count > 1)
                {
                    for (int i = 1; i < index_list.Count; i++)
                    {
                        if ((index_list[i] - index_list[i - 1]) > 1) counter += (index_list[i] - index_list[i - 1] - 1);
                    }
                    index_list.Clear();
                }
                else
                {
                    index_list.Clear();
                }
            }

            return counter;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int size = 106;
            try
            {
                while (size <= -1 || size >= 106)
                {
                    size = Convert.ToInt32(Console.ReadLine());
                    if (size <= -1 || size >= 106) Console.WriteLine("Введите корректное значение");
                }
            }
            catch
            {
                Console.WriteLine("Введите корректное значение");
            }
            int[] height = new int[size];

            Console.WriteLine("Ввод массива:");
            for (int i = 0; i < size; i++)
            {
                try
                {
                    height[i] = Convert.ToInt32(Console.ReadLine());
                    while (height[i] <= -1 || height[i] >= 313)
                    {
                        Console.WriteLine("Введите корректное значение");
                        height[i] = Convert.ToInt32(Console.Read());
                    }
                }
                catch
                {
                    Console.WriteLine("Введите корректное значение");
                }
            }

            int traped_water = Trap(height);
            Console.WriteLine(traped_water.ToString() + " Единиц воды было получено");
        }
    }
}
