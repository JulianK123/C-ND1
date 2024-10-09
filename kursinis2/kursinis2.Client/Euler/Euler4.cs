using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursinis2.Client.Euler
{
    public sealed class Euler4 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler4(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 4;
        }

        public static long answer()
        {
            int largestPalindrome = 0;

            //Range tipas 0.5
            foreach (var i in Enumerable.Range(100, 900))
            {
                foreach (var j in Enumerable.Range(100, 900))
                {
                    int product = i * j;
                    if (IsPalindrome(product) && product > largestPalindrome)
                    {
                        largestPalindrome = product;
                    }
                }
            }

            return largestPalindrome;
        }

        private static bool IsPalindrome(int number)
        {
            string str = number.ToString();
            return str == new string(str.Reverse().ToArray());
        }
    }
    }

