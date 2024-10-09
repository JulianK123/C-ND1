using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursinis2.Client.Euler
{

    public sealed class Euler23 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler23(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 23;
        }

        public static long answer()
        {
            const int limit = 28123;
            List<int> abundantNumbers = new List<int>();

            for (int i = 1; i < limit; i++)
            {
                if (IsAbundant(i))
                {
                    abundantNumbers.Add(i);
                }
            }

            bool[] canBeWrittenAsAbundantSum = new bool[limit + 1];

            for (int i = 0; i < abundantNumbers.Count; i++)
            {
                for (int j = i; j < abundantNumbers.Count; j++)
                {
                    int sum = abundantNumbers[i] + abundantNumbers[j];
                    if (sum <= limit)
                    {
                        canBeWrittenAsAbundantSum[sum] = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            long totalSum = 0;
            for (int i = 1; i <= limit; i++)
            {
                if (!canBeWrittenAsAbundantSum[i])
                {
                    totalSum += i;
                }
            }

            return totalSum;

            bool IsAbundant(int n)
            {
                int sumOfDivisors = 0;
                for (int i = 1; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        sumOfDivisors += i;
                    }
                }
                return sumOfDivisors > n;
            }
        }
    }
}
