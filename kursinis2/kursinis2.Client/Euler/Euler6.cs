namespace kursinis2.Client.Euler
{
    public sealed class Euler6 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler6(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 6;
        }

        public static long answer()
        {
            int n = 100;

            long sumOfSquares, squareOfSum;

            CalculateSumAndSquare(n, out sumOfSquares, out squareOfSum);

            long difference = squareOfSum - sumOfSquares;

            return difference;

            //čia naudojamas out statement, kad išėjime gauti daugiau už 1 kintamajį
            void CalculateSumAndSquare(int n, out long sumOfSquares, out long squareOfSum)
            {                 
                long sum = 0;
                sumOfSquares = 0;

                for (int i = 1; i <= n; i++)
                {
                    sumOfSquares += i * i; 
                    sum += i;              
                }
                squareOfSum = sum * sum;
            }
        }

    }
}
