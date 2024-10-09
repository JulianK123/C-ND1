namespace kursinis2.Client.Euler
{
    public sealed class Euler7 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler7(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 7;
        }

        public static long answer()
        {
            int targetPrimeIndex = 10001;
            int primeCount = 1;
            int number = 1;

            while (primeCount < targetPrimeIndex)
            {
                number += 2;

                if (IsPrime(number))
                {
                    primeCount++;
                }
            }
            return number;

            static bool IsPrime(int number)
            {
                if (number == 2) return true;

                //tikriname ar number is a prime naudojant bitinę operaciją 0.5b
                if ((number & 1) == 0) return false;

                for (int i = 3; i <= Math.Sqrt(number); i += 2)
                {
                    if (number % i == 0) return false;
                }
                return true; 
            }
        }

    }
}
