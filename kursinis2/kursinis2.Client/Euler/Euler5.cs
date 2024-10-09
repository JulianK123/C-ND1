namespace kursinis2.Client.Euler
{
    public sealed class Euler5 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler5(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 5;
        }

        public static long answer()
        {
            return FindSmallestMultiple(1, 20);

             int FindSmallestMultiple(int start, int end)
            {
                
                int[] numbers = CreateRange(start, end);

                
                return CalculateLCMRange(numbers);
            }

             int[] CreateRange(int start, int end)
            {
                int[] range = new int[end - start + 1];
                for (int i = 0; i < range.Length; i++)
                {
                    range[i] = start + i;
                }
                return range;
            }

            //čia naudojamas params, kad galėtume įrašyti betkokį kintamujų kiekį (0,5b)
            int CalculateLCMRange(params int[] numbers)
            {
                long lcm = 1; 

                foreach (var number in numbers)
                {
                    
                    lcm = LCM(lcm, number);
                }

                return (int)lcm;
            }

             long LCM(long a, long b)
            {
                return (a * b) / GCD(a, b);  
            }

             long GCD(long a, long b)
            {
                while (b != 0)
                {
                    long temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

        }

    }
}
