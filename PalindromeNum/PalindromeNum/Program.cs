using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNum
{
    class Program
    {
        public static bool isPalindrome(int num)
        {
            /*can it be negative number?
            // ouput is boolean?
            // what if the number is < 10 => false

            first thing come in mind is to convert the num into a string and check if the string is a palindrome, but this requires extra space.
            Second thing is to reverse the number itself, and then compare it with the original number, but if overflow happens, it'll fail
            the only option is to devide the number by half, reverse half of the number and then compare it to the first half, this would prevend overflow.

            1221 =>12 = 12=>true
            12221
            egde case: 
            - all negative number is not palindrome because - != num;
            - 0 is a palindrome
            - any num ends with 0 must have a zero at the beginning to match, and this is not the case except for 0
            */

            // take care of the edge cases

            if (num < 0 || (num % 10 == 0 && num != 0))
            {
                return false;
            }

            int rev = 0;
            while (num > rev)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            // rev == num: when the number of digit is even ex 1221
            //// rev == num: when the number of digit is odd ex 12221
            return rev == num || num == rev / 10;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The result is" + isPalindrome(1221));
            Console.ReadLine();
        }
    }
}
