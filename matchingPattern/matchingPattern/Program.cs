using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace matchingPattern
{
    class Program
    {
        /* brute force
         * Sort the array
         * All duplicate elements will be next to each other
         * simply run a for loop to check  
        */
        public static List<int> findDup(int[] num)
        {
            List<int> result = new List<int>();
            Array.Sort(num);
            for( int i=0; i< num.Length-1; i++)
            {
                if( num[i] == num[i + 1])
                {
                    result.Add(num[i]);
                }
            }
            return result;
        }
        //print list
        public static void printList(List<int> result)
        {
            foreach( int x in result)
            {
                Console.Write(x + "  ");
            }
        }
       
        /* Method 2: use a count array
         * Create a count array to keep track of the count of each number
         * At the end print out all number has the count of 2 in count[]
        */
        public static List<int> findDup1(int[] arr)
        {
            int[] count = new int[arr.Length];
            List<int> result = new List<int>();
            for(int i=0; i< arr.Length; i++)
            {
                count[arr[i]]++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (count[i] == 2)
                {
                    result.Add(i);
                }
            }
            return result;
        }
        //MEthod 3: use a hashtable
        public static List<int> findDup3(int[] arr)
        {
            Hashtable map= new Hashtable();
            List<int> result = new List<int>();
            for( int i=0; i< arr.Length; i++)
            {
                if (!map.ContainsKey(arr[i]))
                {
                    map.Add(arr[i], 1);
                }
                else
                {
                    map[arr[i]] = (int)map[arr[i]] + 1;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if ((int)map[arr[i]] == 2 && !result.Contains(arr[i]))
                {
                    result.Add(arr[i]);
                }

            }
            return result;

        }
        static void Main(string[] args)
        {
            int[] num = {1,2,3,3,4,4,5 };
            List<int> result = new List<int>();
            result = findDup3(num);
            Console.WriteLine("Result ***");
            printList(result);
            Console.ReadLine();
        }
    }
}


