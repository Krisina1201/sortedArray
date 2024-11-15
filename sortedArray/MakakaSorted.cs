using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedArray
{
    internal class MakakaSorted
    {
        public void returnMakaka()
        {
            Console.WriteLine("Введите целочисленные числа без пробела, через запятую:");
            string[] nums = Console.ReadLine().Split(',');
            int[] array = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                // Проверяем, является ли строка числом
                if (int.TryParse(nums[i], out array[i]) == false)
                {
                    Console.WriteLine($"'{nums[i]}' не является допустимым целым числом.");
                    return; // Выход из программы при ошибочном вводе
                }
            }
            //вызывем метод который перебирает значения, пока он не будет отсортирован
            while (check(array) != true)
            {
                sortingWithBananas(array);
            }
            Console.WriteLine("Отсортированный массив: ");
            foreach (int n in array)
            {
                Console.Write(n + " ");
            }
        }

        //Цикл который перебирает все значения в списке, и возращает тру фолс соответсвено
        public static Boolean check(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    return false;
                }
            }
            return true;
        }

        //Проходит по всем значениям списка, рандомно выбирает один индекс и меняет его с текущим значением
        public static void sortingWithBananas(int[] array)
        {
            Random randomNum = new Random();
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                int j = randomNum.Next(array.Length);
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}
