using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace consecutiveArray
{
    /*
     * Given an unsorted array. Find the length of the longest consecutive subsequence in the array
     * ex: [4,2,1,6,5] => 2: [4,5,6]
     *     [5,5,1,3]   => 1 [1] [5] [3]
     */
    class Program
    {
        /*
         * The idea is to only check the left most element.  ( The left most element means the element that has no number less than it, 
         * consider the example above, 4 and 1 are the left most element.
         * Doing this will cut down the run time because if we already check 1 and 4, there's no point of checking 2 and 5 and 6.
         * 
         * 1. Create a hashset
         * 2. for loop iterates through every element
         * 3. check if the current number is the left most number
         *    if it is not, run a while loop to check if the next number is consecutive
         * 
         */
        public static int consecutiveArray(int[] arr)
        {
            HashSet<int> map = new HashSet<int>();
            int max = 0;
            // ex: [4,2,1,6,5] => 2: [4,5,6]
            foreach (int x in arr)
            {
                map.Add(x);
            }
           
            foreach (int x in map)
            {
                if (map.Contains(x - 1))
                {
                    continue;
                }

                int length = 0; int temp = x;
                while (map.Contains(temp))
                {
                     length++;
                     temp++;
                }
                 max = Math.Max(max, length);
            }
            return max;
        }
         
        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 7 };
            Console.WriteLine("result: " + consecutiveArray(arr));
            Console.ReadLine();
        }
    }
}
