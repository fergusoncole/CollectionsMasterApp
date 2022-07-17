using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsMasterConsoleUI
{
    internal class Methods
    {
        public static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 ==0)
                {
                    numbers[i] = 0;
                }

            }
            
        }

        public static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(x => x % 2 != 0);
        }

        public static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool wasfound = false;
            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine("You found the Number!");
                wasfound = true;
                break;
            }

        }

        public static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 50));
            }

        }

        public static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }

        }

        public static void ReverseArray(int[] array)
        {
            int temp = 0;
            int lastIndex = array.Length - 1;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[lastIndex - i];
                array[lastIndex - i] = temp;
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        public static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
