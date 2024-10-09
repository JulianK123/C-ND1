namespace kursinis2.Client.Euler
{
    public sealed class Euler3 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }
        public Euler3(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 3;

        }


        public static long answer()
        {
            long number = 600851475143;
            long largestPrimeFactor = 0;

            
            for (long i = 2; i * i <= number; i++)
            {
           
                while (number % i == 0)
                {
                    largestPrimeFactor = i;
                    number /= i; 
                }
            }

            if (number > 2)
            {
                largestPrimeFactor = number;
            }

            return largestPrimeFactor;
        }
    }
}
