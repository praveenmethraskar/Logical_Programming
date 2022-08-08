using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programming
{
    public class Fibonacci_Series
    {
        public void Series()
        {
            Console.WriteLine("We are Calculating Fibonacii Series");
        }
    }

    public class Fibonacci_Series_child : Fibonacci_Series
    {
        public void Display()
        {
             

            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1+" "+n2+" "); //printing 0 and 1  


            for (i=2; i<number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3=n1+n2;
                Console.Write(n3+" ");
                n1=n2;
                n2=n3; 
            }
        }
    }
}
