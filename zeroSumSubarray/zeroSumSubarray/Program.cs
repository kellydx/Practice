using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace zeroSumSubarray
{
    class Program
    {
        /*
         * Given an array of int. Return all sub array with sum = 0;
         * [ 1,  2,  -5,  1,  2,  -1] return [2, -5, 1, 2]
         *   1   3   -2  -1   1    0
         *   Do following for each element in the array
         *   Maintain sum of elements encountered so far in a variable (say sum).
         *   If current sum is 0, we found a subarray starting from index 0 and ending at index current index
         *   Check if current sum exists in the hash table or not.
         *   If current sum exists in the hash table, that means we have subarray(s) present with 0 sum that ends at current index.
         *   Insert current sum into the hash table
         */

        public static void subArraySumsZero(int[] seed)
        {
            //int[] seed = new int[] { 1, 2, 3, 4, -9, 6, 7, -8, 1, 9 };
            int currSum = 0;
            Hashtable sumMap = new Hashtable();
            for (int i = 0; i < seed.Length; i++)
            {
                currSum += seed[i];
                if (currSum == 0)
                {
                    Console.WriteLine("subset : { 0 - " + i + " }");
                }
                else if (sumMap[currSum] != null)
                {
                    Console.WriteLine("subset : { "
                                        + ((int)sumMap[currSum] + 1)
                                        + " - " + i + " }");
                    sumMap.Add(currSum, i);
                }
                else
                    sumMap.Add(currSum, i);
            }
            Console.WriteLine("HASH MAP HAS: " + sumMap);
        }

        private static void print(List<int[]> result)
        {
            Console.WriteLine("Sub array from " );
            foreach (int[] arr in result)
            {
                Console.Write(arr[0] + "to  " + arr[1]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {                                               
            int[] arr = { 1, 2, 3, 4, -9, 6, 7, -8, 1, 9 };
            //print(zeroSum(arr));
            subArraySumsZero(arr);
        }
    }
}
