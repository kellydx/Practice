using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeSum
{
    /* Given a set of int, return all set of three number add up to 0
     * ex: [-1,0,1,2,-1,-4] => [-1, -1,2], [-1,0,1]
     * Approach: set 3 pointers, 1 to the current num, a start to the next num, and an end pointer points to the last num
     * [-1,   0,   1,   2,   -1,   -4]
     *  cur  start                 end
     * for every num in arr, check if there's any pair in range start to end add up to the inverse of arr[i]
     * if the sum is too big, decrease the end, if it's otherwise too small, increase the start index.
     * Note: the array must be sorted first.
     */
    class Program
    {
        public static List<int[]> threeSum (int[] arr)
        {
            if(arr.Length < 3)
            {
                throw new IllegalException("no solution");
                return;
            }

            List<int[]> result = new List<int[]>();
            int start, end, sum;
            Array.Sort(arr);
            //[-4, -1, -1, 0,  1,   2]  [-1, -1,2], [-1,0,1]
            for ( int i=0; i< arr.Length - 3; i++)
            {
                start = i + 1; end = arr.Length - 1;
                if (i == 0 || arr[i] > arr[i - 1]){
                    while (start < end)
                    {
                        sum = arr[i] + arr[start] + arr[end];
                        if (sum == 0)
                        {
                            result.Add(new int[] { arr[i], arr[start], arr[end] });
                        }

                        if (sum < 0)
                        {
                            int currentStart = start;
                            while (arr[start] == arr[currentStart] && start < end)
                            {
                                start++;
                            }
                        }
                        else
                        {
                            int currentEnd = end;
                            while (arr[end] == arr[currentEnd] && start < end)
                            {
                                end--; 
                            }
                        }
                    }
                }
            }
            return result;
        } 

        public static void printArray(List<int[]> result)
        {
            foreach (int[] set in result)
            {
                Console.WriteLine("Set ");
                foreach (int x in set)
                {
                    Console.Write(x+"  ");
                }
               
            }
                
        }
        static void Main(string[] args)
        {
            int[] arr = { 0,0,0};
            Console.WriteLine("The result is ");
            //List<int[]> result = threeSum(arr);
            printArray(threeSum(arr));
            Console.ReadLine();
        }
    }
}
