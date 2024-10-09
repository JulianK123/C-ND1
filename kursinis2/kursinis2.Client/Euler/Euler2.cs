using System.Collections.Generic;
using System.Linq;

namespace kursinis2.Client.Euler
{
    public sealed class Euler2 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }
    
        public Euler2(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 2;
        }


        public static long answer()
        {
            
            int limit = 4000000;
            var fibonacci = GenerateFibonacci(limit);
            // lambda funkcija 1.5b
            var evenFibonacciSum = fibonacci.Where(x => x % 2 == 0).Sum();


            //System.Collections.Generic biblioteka 1b
            static IEnumerable<int> GenerateFibonacci(int limit)
            {
                int a = 1, b = 2;
                while (a <= limit)
                {
                    yield return a;
                    var temp = a;
                    a = b;
                    b = temp + b;
                }
            }
        
            return evenFibonacciSum;
        }
    }
}
