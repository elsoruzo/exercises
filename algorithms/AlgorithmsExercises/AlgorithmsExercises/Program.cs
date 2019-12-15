using System;
using AlgorithmsExercises.SortingAlgorithms.MergeSortModel;

namespace AlgorithmsExercises
{
    class Program
    {

        public static void MergeSortIterative(ref int[] data)
        {
            int currentSize;
            int leftStart;

            for (currentSize = 1; currentSize <= data.Length - 1; currentSize = 2 * currentSize)
            {
                for (leftStart = 0; leftStart < data.Length - 1; leftStart += 2 * currentSize)
                {
                    int mid = leftStart + currentSize - 1;
                    int rightEnd = Math.Min(leftStart + 2 * currentSize - 1, data.Length - 1);

                    Merge(ref data, leftStart, mid, rightEnd);
                }
            }
        }

        private static void Merge(ref int[] data, int left, int mid, int right)
        {
            int i, j, k;
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; i++)
                L[i] = data[left + i];

            for (j = 0; j < n2; j++)
                R[j] = data[mid + 1 + j];

            i = 0;
            j = 0;
            k = left;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    data[k] = L[i];
                    i++;
                }
                else
                {
                    data[k] = R[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                data[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                data[k] = R[j];
                j++;
                k++;
            }
        }

        static void Main(string[] args)

        {

            int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };

            int len = numbers.Length;

            int[] data = new int[] { -1, 25, -58964, 8547, -119, 0, 78596 };
            MergeSortIterative(ref data);



            Console.WriteLine("MergeSort By Iterative Method Debug needed");

            MergeSort.MergeSort_Iterative(numbers, 0, len - 1);

            for (int i = 0; i < 9; i++)

                Console.WriteLine(numbers[i]);


            Console.WriteLine("MergeSort By Iterative Method using ref");

            for (int i = 0; i < data.Length; i++)

                Console.WriteLine(data[i]);
        }
    }
}
