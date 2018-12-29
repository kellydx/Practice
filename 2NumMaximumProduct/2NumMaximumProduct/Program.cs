using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2NumMaximumProduct
{
    class Program
    {
        /*
         * Given an array with both +ive and -ive integers, return a pair with highest product.
            Examples :

            Input: arr[] = {1, 4, 3, 6, 7, 0}  
            Output: {6,7}  

            Input: arr[] = {-1, -3, -4, 2, 0, -5} 
            Output: {-4,-5} 
            Brute force
            - have a max var to keep trach of max
            run for loop thru each num
            another for loop and calculate product
            take max of current product and max
         */

            public static int[] maximumProduct( int[] arr)
        {

            if (arr.Length < 2)
            {
                Console.WriteLine("No pairs exists\n"); 
                return null;
            }

            int  a= arr[0], b=arr[1];
            for(int i=0; i< arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                   if( arr[i] * arr[j]> a*b)
                    a = arr[i]; b = arr[j]; 
                }
            }
            return new int[] { a, b };
        }

        //have 4 vars to keep track of max1, max2, min1, min2
        public static int[] maximumProductOptimal(int[] arr)
        {
            int max1 = arr[0], max2 = int.MinValue;
            int min1 = arr[0], min2 = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if( arr[i]> max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }

                else if (arr[i]> max2)
                {
                    max2 = arr[i];
                }

                if (arr[i] < min1)
                {
                    min2 = min1;
                    min1 = arr[i];
                }

                else if (arr[i] < min2)
                {
                    min2 = arr[i];
                }

               
            }
            return (max1 * max2 > min1 * min2 ? new int[] { max1, max2 } : new int[] { min1, min2 });

        }
            static void Main(string[] args)
        {
            int[] arr= { 1, 4, 3, 6, 7, 0 };
            Console.WriteLine("Optimal");
            int[] result = maximumProductOptimal(arr);
            foreach( int x in result)
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
