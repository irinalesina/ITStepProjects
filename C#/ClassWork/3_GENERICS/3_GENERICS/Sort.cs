using System;
using System.Collections.Generic;



namespace _3_GENERICS
{
    public static class Sort<T> where T:IComparable
    {
        public static T[] BubbleSort(T[] array, int from, int to, ref int time)
        {
            int i, j;
            T helper;
            for (i = from; i < to; i++)
            {
                for (j = from; j < to - 1 - i; j++)
                {
                    time++;
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        helper = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = helper;
                    }
                }
            }

            return array;
        }

        public static T[] QuickSort(T[] array, int left, int right, ref int time)
        {
            if (left < right)
            {
                int index = Partition(array, left, right, ref time);
                QuickSort(array, left, index - 1, ref time);
                QuickSort(array, index + 1, right, ref time);
            }
            return array;
        }

        static int Partition(T[] array, int left, int right, ref int time)
        {
            int i = left;
            while (array[i].CompareTo(array[right]) < 0)
            {
                time++;
                i++;
            }
            int j;
            T temp;
            for (j = i; j < right; j++)
            {
                time++;
                if (array[j].CompareTo(array[right]) < 0)
                {
                    temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                    i++;
                }
            }
            temp = array[i];
            array[i] = array[right];
            array[right] = temp;
            return i;
        }
       
    }
}
