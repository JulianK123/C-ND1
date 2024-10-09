using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace kursinis2.Client.Euler
{
    public static class FactorialHelper
    {
        public static Dictionary<int, BigInteger> Factorials;

        //Statinis konnstruktorius faktorialams skičiuoti
        static FactorialHelper()
        {
            Factorials = 
                new Dictionary<int, BigInteger>();
            BigInteger factorial = 1;

            Factorials[0] = 1; // 0! is 1
            for (int i = 1; i <= 100; i++)
            {
                factorial *= i;
                Factorials[i] = 
                    factorial;
            }
        }

        public static BigInteger GetFactorial(int n)
        {
                return Factorials[n];
        }
    }
    public sealed class Euler20 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }
       


        public Euler20(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 20;
        }

        public static long answer()
        {

            BigInteger factorial100 = FactorialHelper.GetFactorial(100);

            int sumOfDigits = SumOfDigits(factorial100);
            return sumOfDigits;


            int SumOfDigits(BigInteger number)
            {
                int sum = 0;
                foreach (char digit in number.ToString())
                {
                    sum += digit - '0';
                }
                return sum;
            }
        }
    }
}
