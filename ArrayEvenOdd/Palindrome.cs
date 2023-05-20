using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEvenOdd
{
    class Palindrome
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Please enter the number to check Palindrome");
            int num = Convert.ToInt32(Console.ReadLine());
            Palindrome(num);
            Console.ReadLine();
        }

        static void Palindrome(int value)
        {
            int rem = 0 ,newVal=0, custValue= value;
            while (value > 0)
            {
                rem = value % 10;
                newVal = newVal * 10 + rem;
                value = value / 10;
            }

            var result = newVal == custValue ? "Palindrome" : "Not Palindrome";

            Console.WriteLine(result);

        }
           
    }
}
