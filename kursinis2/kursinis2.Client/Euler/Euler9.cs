namespace kursinis2.Client.Euler
{
    public sealed class Euler9 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler9(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 9;
        }

        public static long answer()
        {
            int targetSum = 1000;
            (int a, int b, int c) = FindPythagoreanTriplet(targetSum);

            long product = a * b * c;
            return product;
            
            (int, int, int) FindPythagoreanTriplet(int targetSum)
            {
                for (int a = 1; a < targetSum / 3; a++)
                {
                    for (int b = a + 1; b < targetSum / 2; b++)
                    {
                        int c = targetSum - a - b;

                        if (a * a + b * b == c * c)
                        {
                            return (a, b, c);
                        }
                    }
                }
                return (0, 0, 0); 
            }

        }

    }
}
