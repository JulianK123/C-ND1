namespace kursinis2.Client.Euler
{
    public sealed class Euler14 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler14(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 14;
        }

        public static long answer()
        {

            const int limit = 1000000;
            long maxLength = 0;
            long numberWithMaxLength = 0;

            Dictionary<long, long> collatzLengths = new Dictionary<long, long>();

            for (long i = 1; i < limit; i++)
            {
                long length = GetCollatzLength(i, collatzLengths);

                if (length > maxLength)
                {
                    maxLength = length;
                    numberWithMaxLength = i;
                }
            }
            return numberWithMaxLength;

            long GetCollatzLength(long n, Dictionary<long, long> memo)
            {
                if (memo.ContainsKey(n))
                {
                    return memo[n];
                }
                if (n == 1)
                {
                    return 1;
                }

                long next;
                if (n % 2 == 0)
                {
                    next = n / 2;
                }
                else
                {
                    next = 3 * n + 1;
                }

                long length = 1 + GetCollatzLength(next, memo);
                memo[n] = length;

                return length;
            }

        }

        
    }
}
