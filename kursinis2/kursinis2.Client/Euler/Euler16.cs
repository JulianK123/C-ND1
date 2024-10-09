using System.Numerics;

namespace kursinis2.Client.Euler
{
    public sealed class Euler16 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler16(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 16;
        }

        public static long answer()
        {
            BigInteger number = BigInteger.Pow(2, 1000);

            string numberString = number.ToString();

            int sumOfDigits = 0;
            foreach (char digit in numberString)
            {
                sumOfDigits += (int)char.GetNumericValue(digit);
            }
            return sumOfDigits;
        }


    }
}
