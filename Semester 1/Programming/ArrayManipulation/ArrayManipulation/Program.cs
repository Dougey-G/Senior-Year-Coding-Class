using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];
            int seed = 1234;
            Random rand = new Random(seed);

            //Apply random values of 0-9 to the array. Note: This does not prevent duplicates
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
            }


            int temp = array[0];
            array[0] = array[1];
            array[1] = temp;

            //The following can be used to test your implementations. Uncomment each line as you go to test.
            //NOTE: You don't have to do each line sequentially. For example, implementing the FindMin and FindMax methods
            //will be very useful for your FindRange method. Hint... Hint...

            Console.WriteLine("UNSORTED: ");
            PrintArray(array);
            Console.WriteLine("BUBBLE SORTED: ");
            PrintArray(BubbleSort(array));
            Console.WriteLine("SELECTION SORTED: ");
            PrintArray(SelectionSort(array));
            Console.WriteLine("MEAN: " + FindMean(array));
            Console.WriteLine("MEDIAN: " + FindMedian(SelectionSort(array)));
            Console.WriteLine("RANGE: " + FindRange(array));
            Console.WriteLine("MODE: " + FindMode(array));
            Console.WriteLine("MAX: " + FindMax(array));
            Console.WriteLine("MIN: " + FindMin(array));
        }

        /// <summary>
        /// Prints the array in | x | y | z | a | b | c | format
        /// </summary>
        /// <param name="array">The array to be printed</param>
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("| " + array[i] + " ");
            }
            Console.WriteLine("|");
        }

        /// <summary>
        /// Implements a bubble sort algorithm to sort the array
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <returns>The sorted array</returns>
        public static int[] BubbleSort(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);

            int n = mutatedArray.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i <= n - 1; i++)
                {
                    if (mutatedArray[i - 1] > mutatedArray[i])
                    {
                        int temp = mutatedArray[i];
                        mutatedArray[i] = mutatedArray[i - 1];
                        mutatedArray[i - 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
            return mutatedArray;
        }



        /// <summary>
        /// Implements a selection sort algorithm to sort the array
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <returns>The sorted array</returns>
        public static int[] SelectionSort(int[] array)
        {
            int n = array.Length;

            bool swapped;
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);

            /* advance the position through the entire array */
            /*   (could do j < n-1 because single element is also min element) */

            for (int j = 0; j < n - 1; j++)
            {
                /* find the min element in the unsorted a[j .. n-1] */
                int min = j;
                /* assume the min is the first element */

                /* test against elements after j to find the smallest */
                for (int i = j + 1; i < n; i++)
                {
                    /* if this element is less, then it is the new minimum */
                    if (mutatedArray[i] < mutatedArray[min])
                    {
                        min = i;
                    }
                }

                if (min != j)
                {
                    int temp = mutatedArray[min];
                    mutatedArray[min] = mutatedArray[j];
                    mutatedArray[j] = temp;
                }
                
            }
            return mutatedArray;
        }
        //throw new NotImplementedException();




        /// <summary>
        /// Finds the mean (average) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The mean</returns>
        public static float FindMean(int[] array)
        {
            float num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                num += array[i];
            }
            num = num / array.Length;

            return num;
        }

        /// <summary>
        /// Finds the median (middle element of sorted array) of the array
        /// In the case that the array is an even length, average the two middle elements
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The median</returns>
        public static float FindMedian(int[] mutatedarray)
        {

            if (mutatedarray.Length % 2 == 0)
            {
                int f = mutatedarray.Length / 2;
                int m = mutatedarray.Length / 2 - 1;
               
                return (((float) mutatedarray[m] + (float) mutatedarray[f]) / 2);
            }
            else
            {
                int n = mutatedarray.Length / 2 - 1;
                return mutatedarray[n];
            }
        }

        /// <summary>
        /// Finds the range (highest value - lowest value) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The range</returns>
        public static int FindRange(int[] mutatedarray)
        {
            int min = FindMin(mutatedarray);
            int max = FindMax(mutatedarray);

            return max - min;
        }

        /// <summary>
        /// Finds the mode (most common occuring element) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The mode</returns>
        public static int FindMode(int[] mutatedarray)
        {
            int mode = mutatedarray[0];

            Dictionary<int, int> counts = new Dictionary<int, int>();

            int result = int.MinValue;
            int max = int.MinValue;
            foreach (int key in counts.Keys)
            {
                if (counts[key] > max)
                {
                    max = counts[key];
                    result = key;
                }
            }
            return mode;
        }

        /// <summary>
        /// Finds the maximum value inside the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The maximum value</returns>
        public static int FindMax(int[] mutatedarray)
        {
            int[] array = new int[mutatedarray.Length];
            mutatedarray.CopyTo(array, 0);

            int max = mutatedarray[0];
            for (int i = 0; i < mutatedarray.Length; i++)
            {
                if (max < mutatedarray[i]) max = mutatedarray[i];
            }
            return max;
        }

        /// <summary>
        /// Finds the minimum value inside the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The minimum value</returns>
        public static int FindMin(int[] mutatedarray)
        {

            int min = mutatedarray[0];

            for (int i = 0; i < mutatedarray.Length; i++)
            {
                if (min > mutatedarray[i]) min = mutatedarray[i];
            }
            return min;
        }
    }
}





