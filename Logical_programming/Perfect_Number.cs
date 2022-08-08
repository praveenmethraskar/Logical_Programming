using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programming
{
    

    public class Perfect_Number
    {
        int num, sum = 0, i;

        public void PerfectNumber()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Enter A Number");

            num = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if  (num % i == 0)
                {
                    Console.WriteLine(i+" ");
                    sum = sum + i;
                }
            }

            if (sum == num)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not a perfect number");
            }
        }

    }
}
