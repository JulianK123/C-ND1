using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursinis2.Client.Euler
{

    public sealed class Euler15 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler15(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 15;
        }

        public static long answer()
        {
            int gridSize = 20;
            long numberOfPaths = CalculatePaths(gridSize);
            return numberOfPaths;

            long CalculatePaths(int n)
            {
                long result = 1;

                for (int i = 0; i < n; i++)
                {
                    result = result * (2 * n - i) / (i + 1);
                }

                return result;
            }
        }
    }
}
