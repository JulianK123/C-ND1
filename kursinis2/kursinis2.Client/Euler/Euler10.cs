namespace kursinis2.Client.Euler
{
    public sealed class Euler10 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler10(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 10;
        }

        public static long answer()
        {
            long limit = 2000000;
            long sumOfPrimes = SumOfPrimes(limit);
            return sumOfPrimes;

            long SumOfPrimes(long limit)
            {
                bool[] isPrime = new bool[limit];
                long sum = 0;

                for (long i = 2; i < limit; i++)
                {
                    isPrime[i] = true;
                }

                for (long p = 2; p * p < limit; p++)
                {
                    if (isPrime[p])
                    {
                        for (long multiple = p * p; multiple < limit; multiple += p)
                        {
                            isPrime[multiple] = false;
                        }
                    }
                }

                for (long i = 2; i < limit; i++)
                {
                    if (isPrime[i])
                    {
                        sum += i;
                    }
                }

                return sum;
            }

        }

    }
}
