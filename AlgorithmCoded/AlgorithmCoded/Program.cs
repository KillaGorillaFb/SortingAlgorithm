using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Developer:  Frankie Barrios
/// Date:       09/08/2018
/// Purpose:    Write the code to implement the Counter Sort algorithm as described in class.  
/// Write a main that will test your sort with at least four different arrays each of length 
/// 50 or more.  One should be all the same data value throughout the array.  Another should 
/// be different data values but already sorted.  Another should be different data values but
/// reverse sorted.  Another should be random data randomly ordered.
/// </summary>

namespace AlgorithmCoded
{
    class Program
    {
        static void Main(string[] args)
        {
            firstAry();
            secondAry();
            thirdAry();
            fourthAry();

        }//End of Main
        static void firstAry()
        {
            //First Array
            int[] frstAry = new int[50]
            {
                    1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                    1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                    1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                    1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                    1, 1, 1, 1, 1, 1, 1, 1, 1, 1
            };

            Console.WriteLine("\n" + "First Array:");
            foreach (int aa in frstAry)
                Console.Write(aa + " ");

            int[] sortedArray = new int[frstAry.Length];

            // find smallest and largest value
            int minVal = frstAry[0];
            int maxVal = frstAry[0];
            for (int i = 1; i < frstAry.Length; i++)
            {
                if (frstAry[i] < minVal) minVal = frstAry[i];
                else if (frstAry[i] > maxVal) maxVal = frstAry[i];
            }

            // init array of frequencies
            int[] counts = new int[maxVal - minVal + 1];

            // init the frequencies
            for (int i = 0; i < frstAry.Length; i++)
            {
                counts[frstAry[i] - minVal]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = frstAry.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[frstAry[i] - minVal]--] = frstAry[i];
            }

            Console.WriteLine("\n" + "First Array Sorted:");
            foreach (int aa in sortedArray)
                Console.Write(aa + " ");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("Press Enter To Process Next Sort");
            Console.Write("\n");
            Console.ReadKey();
        }//End of First Array

        static void secondAry()
        {
            //Second Array
            int[] secAry = new int[50]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
                31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
                41, 42, 43, 44, 45, 46, 47, 48, 49, 50
            };

            Console.WriteLine("\n" + "Second Array:");
            foreach (int aa in secAry)
                Console.Write(aa + " ");

            int[] sortedArray = new int[secAry.Length];

            // find smallest and largest value
            int minVal = secAry[0];
            int maxVal = secAry[0];
            for (int i = 1; i < secAry.Length; i++)
            {
                if (secAry[i] < minVal) minVal = secAry[i];
                else if (secAry[i] > maxVal) maxVal = secAry[i];
            }

            // init array of frequencies
            int[] counts = new int[maxVal - minVal + 1];

            // init the frequencies
            for (int i = 0; i < secAry.Length; i++)
            {
                counts[secAry[i] - minVal]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = secAry.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[secAry[i] - minVal]--] = secAry[i];
            }

            Console.WriteLine("\n" + "Second Array Sorted:");
            foreach (int aa in sortedArray)
                Console.Write(aa + " ");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("Press Enter To Process Next Sort");
            Console.Write("\n");
            Console.ReadKey();
        }//End of Second Array

        static void thirdAry()
        {
            //Third Array
            int[] thrdAry = new int[50]
            {
                50,49,48,47,46,45,44,43,42,41,40,
                39,38,37,36,35,34,33,32,31,30,
                29,28,27,26,25,24,23,22,21,20,
                19,18,17,16,15,14,13,12,11,
                10,9,8,7,6,5,4,3,2,1
            };

            Console.WriteLine("\n" + "Third Array:");
            foreach (int aa in thrdAry)
                Console.Write(aa + " ");

            int[] sortedArray = new int[thrdAry.Length];

            // find smallest and largest value
            int minVal = thrdAry[0];
            int maxVal = thrdAry[0];
            for (int i = 1; i < thrdAry.Length; i++)
            {
                if (thrdAry[i] < minVal) minVal = thrdAry[i];
                else if (thrdAry[i] > maxVal) maxVal = thrdAry[i];
            }

            // init array of frequencies
            int[] counts = new int[maxVal - minVal + 1];

            // init the frequencies
            for (int i = 0; i < thrdAry.Length; i++)
            {
                counts[thrdAry[i] - minVal]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = thrdAry.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[thrdAry[i] - minVal]--] = thrdAry[i];
            }

            Console.WriteLine("\n" + "Third Array Sorted:");
            foreach (int aa in sortedArray)
                Console.Write(aa + " ");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("Press Enter To Process Next Sort");
            Console.Write("\n");
            Console.ReadKey();
        }//End of Third Array

        static void fourthAry()
        {
            //Fourth Array
            int[] frAry = new int[50]
            {
                9, 4, 2, 7, 1, 1, 4, 2, 6, 9,
                9, 4, 2, 7, 1, 1, 4, 2, 6, 9,
                9, 4, 2, 7, 1, 1, 4, 2, 6, 9,
                9, 4, 2, 7, 1, 1, 4, 2, 6, 9,
                9, 4, 2, 7, 1, 1, 4, 2, 6, 9
            };

            Console.WriteLine("\n" + "Fourth Array:");
            foreach (int aa in frAry)
                Console.Write(aa + " ");

            int[] sortedArray = new int[frAry.Length];

            // find smallest and largest value
            int minVal = frAry[0];
            int maxVal = frAry[0];
            for (int i = 1; i < frAry.Length; i++)
            {
                if (frAry[i] < minVal) minVal = frAry[i];
                else if (frAry[i] > maxVal) maxVal = frAry[i];
            }

            // init array of frequencies
            int[] counts = new int[maxVal - minVal + 1];

            // init the frequencies
            for (int i = 0; i < frAry.Length; i++)
            {
                counts[frAry[i] - minVal]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = frAry.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[frAry[i] - minVal]--] = frAry[i];
            }

            Console.WriteLine("\n" + "Fourth Array Sorted:");
            foreach (int aa in sortedArray)
                Console.Write(aa + " ");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("Press Enter To Process Next Sort");
            Console.Write("\n");
            Console.ReadKey();
        }//End of Fourth Array
    }//End of Class
}//End of Solution

