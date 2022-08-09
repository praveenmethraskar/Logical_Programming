using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programming
{
    public class Prime_Number
    {
        public void PrimeNumber()
        {
            int n, m = 0, flag = 0;
            Console.WriteLine("Enter the Number to check Prime or Not");

            n=Int32.Parse(Console.ReadLine());

            m=n/2;
            for(int i=2;i<m;i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Number is not prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Number is Prime");
            }
        }

    }
}
