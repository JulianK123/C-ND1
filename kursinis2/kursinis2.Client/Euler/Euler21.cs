using System.Numerics;

namespace kursinis2.Client.Euler
{
    public sealed class Euler21 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler21(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 21;
        }

        public static long answer()
        {
            int limit = 10000;
            int sumOfAmicableNumbers = 0;

            for (int a = 1; a < limit; a++)
            {
                int b = SumOfDivisors(a);
                if (b != a && SumOfDivisors(b) == a)
                {
                    sumOfAmicableNumbers += a;
                }
            }

            return sumOfAmicableNumbers;
            int SumOfDivisors(int n)
            {
                int sum = 0;
                for (int i = 1; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }


        }
    }
}
