using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedArray
{
    internal class BumblSorted
    {
        public void ReturnBumbl()
        {
            Console.WriteLine("Введите целочисленные числа без пробела, через запятую:");
            string[] nums = Console.ReadLine().Split(',');
            int[] numsArray = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                // Проверяем, является ли строка числом
                if (int.TryParse(nums[i], out numsArray[i]) == false)
                {
                    Console.WriteLine($"'{nums[i]}' не является допустимым целым числом.");
                    return; // Выход из программы при ошибочном вводе
                }
            }

            BubbleSort(numsArray); // Сортируем массив
            Console.WriteLine("Отсортированные числа:");
            foreach (int n in numsArray)
            {
                Console.Write(n + " ");
            }
        }
        static void BubbleSort(int[] array)
        {
            // Перебор элементов массива 
            bool swapped;

            for (int i = 0; i < array.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    Console.WriteLine(array[j]);
                    // Если число, которое идет раньше, больше идущего далее, их значения меняются
                    if (array[j] > array[j + 1])
                    {
                        // Меняем местами
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break; // Если не было обменов, массив уже отсортирован
                }
            }
        }
    }
}
