using System;

namespace _27.methodMultiplicationSumOfNumbers
{
    class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var result = GetMultipleOfOddEvenDigits(num);
            Console.WriteLine(result);
            //Console.WriteLine(SumOddDigits(-234513));
        }
        private static long GetMultipleOfOddEvenDigits(int num)
        {
            var oddSum = SumOddDigits(num);
            var evenSum = SumEvenDigits(num);
            return oddSum * evenSum;
        }
        private static long SumOddDigits(int num )
        {
            long sum = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                var digit = num % 10; //tekes the last digit of the number
                if(digit % 2 != 0)
                   sum = sum + digit; //sum += digit;
                num = num / 10; //we take only the whole int part of the number devision-> 501(/10, we remove number 1) ->50 
                //We remove the last number , we remuve the reminder, to get the new number;

            }
            return sum;
        }
        private static long SumEvenDigits(int num )
        {
            long sum = 0;
            num = Math.Abs(num);
            
            while (num > 0)
            {
                var digit = num % 10;
                if (digit % 2 == 0)
                    sum = sum + digit;
                num = num / 10;

            }
            return sum;

        }



    }
}
