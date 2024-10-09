using System.Numerics;

namespace kursinis2.Client.Euler
{
    public sealed class Euler22 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler22(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 22;
        }

        public static long answer()
        {
            string namesInput = "\"MARY\",\"JOHN\",\"PETER\",\"COLIN\",\"JANE\",\"ANNA\",\"BETH\"";

            string[] names = namesInput.Split(',')
                                        .Select(name => name.Trim('"'))
                                        .ToArray();

            Array.Sort(names);

            long totalScore = 0;

            for (int i = 0; i < names.Length; i++)
            {
                int nameScore = CalculateNameScore(names[i]);
                totalScore += nameScore * (i + 1); 
            }

            return totalScore;

          
            int CalculateNameScore(string name)
            {
                return name.Sum(c => c - 'A' + 1); 
            }
        }


        }
    }

