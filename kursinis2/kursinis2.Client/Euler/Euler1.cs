namespace kursinis2.Client.Euler
{ 
    //sealed 0.5b
    public sealed class Euler1 : EulerFormat, EulerInterface 
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler1(string description)
        { 
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 1;
        }

        public static long answer()
        {
            int Accumulator = default;

            for (int i = 3; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Accumulator+= i;
                }
            }
            
            return Accumulator;
        }
    }
}
