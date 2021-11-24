using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIXMachulaDZ5._1
{
    class Program
    {
       
        static void calculations(int[] nums, out int oddSum, out int count)
        {
            Console.WriteLine("Написать метод, который для произвольного одномерного массива из целочисленных элементов вычисляет и возвращает количество четных положительных элементов и сумму нечетных элементов.");
            Console.WriteLine("Результат вернуть через out -параметры метода.");
            int cnt = 0;
            int ods = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0 && nums[i] != 0)
                {

                    cnt++;
                }
                else
                {
                    ods = ods + nums[i];
                }
            }
            oddSum = ods;
            count = cnt;
        }

        static void Main(string[] args)
        {
            int[] nums = { 6, 2, 1, 5, 0, 6, 5, 4, 3, 7 };
            calculations(nums, out int os, out int cnt);
            Console.WriteLine(cnt);
            Console.WriteLine(os);
        }

    }
}

