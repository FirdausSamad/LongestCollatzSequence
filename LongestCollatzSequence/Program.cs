using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCollatzSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int max=0, sum = 1,n,j, maxStartNumber=0;
           for (int i = 1; i <= 1000000; i++)
           {
                 n = i;
                j = i;
                while (n > 1)
                {
                    if (n % 2 == 0)
                    {
                        n = n / 2;
                    }
                    else if (n % 2 != 0)
                    {
                        n = 3 * n + 1;
                    }
                    sum = sum + 1;
                }
                if(sum>max)
                {
                    maxStartNumber = j;
                    max = sum;
                }
                sum = 1;
               
           }
            Console.WriteLine("Longest Collatz Sequence\n");
            Console.WriteLine("Start Number : {0}",maxStartNumber);
            Console.WriteLine("Longest Sequence : {0}",max);
            Console.ReadLine();
        }
    }
}
