using System;

namespace Logical_programming
{
    public class Program
    { 
        public static void Main(string[] args)
        { 
            bool isrun = true;
            while(isrun)
            {
                Console.WriteLine("Select:\n1)Fibonacii Series \n2)Perfect Number \n3)Prime Number \n4)Reverse A Number");
                int option = Int32.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Fibonacci_Series_child obj = new Fibonacci_Series_child();
                        obj.Series();
                        obj.Display();
                        break;
                    case 2:
                        Perfect_Number perfect_Number = new Perfect_Number();
                        perfect_Number.PerfectNumber();
                        break;
                    case 3:
                        Prime_Number Prime_Number = new Prime_Number();
                        Prime_Number.PrimeNumber();
                        break;
                    case 4:
                        Reverse_A_Number reverse_A_Number = new Reverse_A_Number();
                        reverse_A_Number.ReverseNumber();
                        break ;
                    default:
                        isrun = false;
                        Console.WriteLine("select correct option");
                        break;
                }
            }  
        }
    }
}