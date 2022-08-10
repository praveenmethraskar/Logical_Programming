using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programming
{
    public class Coupon_Number
    {
        public void Coupon()
        {
            Console.WriteLine("Enter The number of ditinct coupons needed");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int[] coupons = new int[number];
            Random r = new Random();
            int generated = 0;

            while(i < number)
            {
                int randomnumber = r.Next(number+1);
                generated++;
                Console.WriteLine("Generated random number is :" + randomnumber);
                if(coupons.Contains(randomnumber))
                {
                    continue;
                }
                else
                {
                    coupons[i] = randomnumber;
                }
                i++;
            }
            foreach(int coupon in coupons)
            {
                Console.Write(coupon + " ");
            }
            Console.WriteLine("\n RAndom numbers needed to generate " + number + " number o coupons are: "+generated);


        }
    }
}
