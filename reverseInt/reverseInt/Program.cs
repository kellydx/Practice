using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseInt
{
    /*Given a 32-bit signed integer, reverse digits of an integer.
    // Questions: if the num are overflow, what do we return?
    // is negative number considered?
    // ex: 1234 % 10 => 4
           1234 / 10 = 123 
           123  % 10 => 3
           123 / 10 = 12
           .... 2
           .... 1
           output => 4321
           pop = 4,3,2,1
           rev = 0;
           rev = rev*10 + pop; = 4
           rev = 4*10+3 = 43

        OVERFLOW:v  int 32: -2^31 = ....... - ; 2^31-1
        rev*10 + pop >= max
        rev*10 >= max => rev > max/10 => overflow for sure
        - if rev > max/10
        - if rev = max/10 then overflow if pop > 7
        - if rev = min/10 then overflow if pop > -8
    */
    class Program
    {
        public static int reverseNum(int num)
        {
            int pop, rev = 0;

            while (num != 0)
            {
                pop = num % 10;
                num = num / 10;
                if (rev > int.MaxValue/10 || rev == int.MaxValue/10 && pop > 7)
                {
                    return 0;
                }

                if (rev < int.MinValue / 10 || rev == int.MinValue / 10 && pop < -8)
                {
                    return 0;
                }

                rev = rev * 10 + pop;
                
            }
            return rev;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("The result is" + reverseNum(321));
            Console.ReadLine();
        }
    }
}
