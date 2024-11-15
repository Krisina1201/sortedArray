using System;

namespace sortedArray
{
    internal class BumblSort
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Пузырьклвый метод-1, Метод макаки-2, метод рекурсии-3");
            string num = Console.ReadLine();
            if (num == "1")
            {
                BumblSorted bumbl = new BumblSorted();
                bumbl.ReturnBumbl();
            }
            else if (num == "2")
            {
                MakakaSorted makakaSorted = new MakakaSorted();
                makakaSorted.returnMakaka();
            }
            else if (num == "3")
            {
                SortingRecursion sortingRecursion = new SortingRecursion();
                sortingRecursion.ReturnRecursion();
            }
            else
            {
                Console.WriteLine("Научись читать");
            }
        }
    }
}
