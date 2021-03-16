using System;

namespace Zad3Es_lev
{
    public class Solution
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) index = i;
            }
            if (index == 0 && target != nums[0])
            {
                for (int i = 0; i < (nums.Length - 1); i++)
                {
                    if (nums[i] < target && nums[i + 1] > target) index = i + 1;
                }
                if (nums[nums.Length - 1] < target) index = nums.Length;
                if (nums[0] < target) index = 0;
            }
            return index;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int size = 0;
            try
            {
                while (size < 1 || size > 104)
                {
                    size = Convert.ToInt32(Console.ReadLine());
                    if (size < 1 || size > 104) Console.WriteLine("Введите корректное значение");

                }
            }
            catch
            {
                Console.WriteLine("Введите корректное значение");
            }
            int[] nums = new int[size];

            Console.WriteLine("Ввод массива:");
            for (int i = 0; i < size; i++)
            {
                try
                {
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                    while (nums[i] < -104 || nums[i] > 104)
                    {
                        Console.WriteLine("Введите корректное значение");
                        nums[i] = Convert.ToInt32(Console.Read());
                    }
                }
                catch
                {
                    Console.WriteLine("Введите корректное значение");
                }
            }

            Console.WriteLine("Введите искомое число");
            int target = 105;
            try
            {
                while (target < -104 || target > 104)
                {
                    target = Convert.ToInt32(Console.ReadLine());
                    if (target < -104 || target > 104) Console.WriteLine("Введите корректное значение");

                }
            }
            catch
            {
                Console.WriteLine("Введите корректное значение");
            }

            int index = SearchInsert(nums, target);
            Console.WriteLine("Индекс введенного числа - ", index);
        }
    }
}
