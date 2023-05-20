using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayEvenOdd = new int[10];

            Console.WriteLine("Enter the 10 values to check Odd or Even");

            for(int i =0; i<ArrayEvenOdd.Length;i++)
            {
                ArrayEvenOdd[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(" Entered Values are ");

            for (int j = 0; j < ArrayEvenOdd.Length; j++)
            {
                if(ArrayEvenOdd[j] % 2 == 0)
                {
                    Console.WriteLine(ArrayEvenOdd[j] + " is an EVEN number");
                }
                else
                {
                    Console.WriteLine(ArrayEvenOdd[j] + " is an ODD number");
                }
            }
            Console.ReadLine();

        }
    }
}
