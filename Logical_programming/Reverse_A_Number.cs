using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programming
{
    public class Reverse_A_Number
    {
        public void ReverseNumber()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter a number: ");
            n= int.Parse(Console.ReadLine());


            while (n!=0)
            {
                rem=n%10;
                reverse=reverse*10+rem;
                n/=10;
            }
            Console.WriteLine("Reversed Number: "+reverse);
        }
    }
}
