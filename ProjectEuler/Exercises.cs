using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Exercises
    {
        public static int SumOfMultiples(int max)
        {
            int sum = 0;
            for (int i = 0; i < max; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static long EvenFibonacci(int limit)
        {
            long fib1 = 1;
            long fib2 = 1;
            long value = 0;
            //sum = sum of even fib values
            long sum = 0;

            //loop till values < 4 million
            while(value < limit)
            {
                //value is even  ie no remainder then add to sum
                if(value % 2 == 0)
                {
                    sum += value;
                }
                //add fib 1 and 2 assign to value
                value = fib1 + fib2;
                fib2 = fib1;
                fib1 = value;
            }
            return sum;
        }

        public static long SumSquareDiff(int max)
        {
            long sumOfSquares = 0;
            long total = 0;
            
            for(int i=1; i<=max; i++)
            {
                sumOfSquares +=(long)Math.Pow(i, 2);
            }

            for(int j=0; j<=max; j++)
            {
                total += j;
            }
            long sumSquared = (long)Math.Pow(total, 2);
            long difference = sumSquared - sumOfSquares;
            return difference;

        }

        public static int LargestPalindromeProduct()
        {
            int maxPalindrome = 0;
            int product = 0;
            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    product = i * j;
                    if(isPalindrome(product) && product > maxPalindrome)
                    {
                        maxPalindrome = product;
                    }
                }
            }
            return maxPalindrome;
        }
        //Check if number is palindrome
        public static bool isPalindrome(int num)
        {
            string reversed = "";
            //get the forward number passed in converted to char array and reverse it
            char[] arrNum = num.ToString().ToCharArray();
            Array.Reverse(arrNum);
            reversed = new string(arrNum);

            if(reversed == num.ToString())
            {
                return true;
            } 
            return false;
            
        }
     
    }
    
        

    
}
