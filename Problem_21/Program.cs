using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_21
{
    class Program
    {
        /*
         * Amicable numbers
         * Problem 21
         * a working work in progress
         */
        static void Main(string[] args)
        {
            int j, a, b, end;
            long sum = 0;
            int sum1, sum2;
            for (a = 1; a < 10000; a++)
            {
                for (b = a; b < a + (int)(a * 0.3) && b <= 10000; b++)
                {
                    for (j = 1, sum1 = 1; j < a / 2; j++, sum1 += (a % j == 0) ? j : 0) ;
                    if (sum1 == b)
                    {
                        end = b % 2 == 0 ? b / 2 : (int)Math.Sqrt(b);
                        for (j = 1, sum2 = 1; j <= end; j++, sum2 += (b % j == 0) ? j : 0) ;
                        if (sum1 > 1 && sum2 > 1 && sum1 == b && sum2 == a && a != b)
                        {
                            sum += a + b;
                            Console.WriteLine(a);
                            Console.WriteLine(b);
                        }                   
                    }
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
