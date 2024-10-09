using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursinis2.Client.Euler
{


    public sealed class Euler12 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler12(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 12;
        }

        //čia nauduojami ?? ir .? operatoriai 0.5b
        public static long answer()
        {

             static long FindFirstTriangularNumberWithDivisors(int limit)
            {
                long triangularNumber = 0;
                int n = 1;

                while (true)
                {
                    triangularNumber = GetTriangularNumber(n);

                    int divisorCount = GetDivisorCount(triangularNumber) ?? 0;
                    if (divisorCount > limit)
                    {
                        return triangularNumber;
                    }
                    n++;
                }
            }

             static long GetTriangularNumber(int n)
            {
                return n * (n + 1) / 2;
            }

             static int? GetDivisorCount(long number)
            {
                if (number <= 0) return null;

                int count = 0;

                for (long i = 1; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        count += 2;
                        if (i * i == number) count--;
                    }
                }
                return count;
            }
            int limit = 500;
            long triangularNumber = FindFirstTriangularNumberWithDivisors(limit);
            return triangularNumber;
        }
    }
}
