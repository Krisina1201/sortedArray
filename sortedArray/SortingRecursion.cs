using System;

namespace sortedArray
{
    internal class SortingRecursion
    {
        public void ReturnRecursion()
        {
            int[] array = { 9, 5, 4, 3, 2, 1 };
            int[] numsArray = SeparationNum(array);
        

            // Если массив отсортирован, выводим его
            if (CheckSorted(numsArray))
            {
                Console.WriteLine($"Отсортированный массив: {string.Join(", ", numsArray)}");
            }
            else
            {
                // Если не отсортирован, вызываем метод еще раз
                ReturnRecursion();
            }
        }

        static int[] SeparationNum(int[] array)
        {
            if (array.Length < 2)
            {
                return array; // Возвращаем массив, если он содержит менее 2 элементов
            }

            int pivot = array[0];
            int leftCount = 0;
            int rightCount = 0;

            // Сначала подсчитаем количество элементов для левой и правой части
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < pivot)
                {
                    leftCount++;
                }
                else
                {
                    rightCount++;
                }
            }

            // Создаем новые массивы для левой и правой частей
            int[] left = new int[leftCount];
            int[] right = new int[rightCount];

            // Заполняем левые и правые массивы
            leftCount = 0;
            rightCount = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < pivot)
                {
                    left[leftCount++] = array[i];
                }
                else
                {
                    right[rightCount++] = array[i];
                }
            }

            // Рекурсивно сортируем левые и правые массивы
            int[] sortedLeft = SeparationNum(left);
            int[] sortedRight = SeparationNum(right);

            // Объединяем отсортированные массивы
            int[] bigMassiv = new int[sortedLeft.Length + sortedRight.Length + 1];
            Array.Copy(sortedLeft, bigMassiv, sortedLeft.Length);
            bigMassiv[sortedLeft.Length] = pivot; // Вставляем опорный элемент
            Array.Copy(sortedRight, 0, bigMassiv, sortedLeft.Length + 1, sortedRight.Length);

            return bigMassiv;
        }

        // Метод проверки отсортированности массива
        public static bool CheckSorted(int[] array)
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
    }
}
