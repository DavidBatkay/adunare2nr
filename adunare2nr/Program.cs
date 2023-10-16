using System;

namespace adunare2nr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checked
            { int a;
              int b;
                Console.Write("a= ");
                a = int.Parse(Console.ReadLine());
                //a = Int32.MaxValue;  check for error
                Console.Write("b= ");
                b = int.Parse(Console.ReadLine());

                if (Int32.MaxValue - a <=b)
                {
                   
                    Console.WriteLine("overflow!");

                }
                else 
                {
                    Console.WriteLine("Suma numerelor = " + (a + b));
                }
               
            }
        }
    }
}