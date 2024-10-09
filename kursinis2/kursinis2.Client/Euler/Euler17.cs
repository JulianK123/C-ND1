using System.Numerics;

namespace kursinis2.Client.Euler
{
    public sealed class Euler17 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler17(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 17;
        }

        public static long answer()
        {

            int totalLetterCount = 0;

            for (int i = 1; i <= 1000; i++)
            {
                string word = NumberToWords(i);
                totalLetterCount += CountLetters(word);
            }
            return totalLetterCount;

            string NumberToWords(int number)
            {
                if (number == 1000) return "one thousand";

                string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                string words = "";

                if (number >= 100)
                {
                    words += ones[number / 100] + " hundred";
                    if (number % 100 != 0)
                    {
                        words += " and ";
                    }
                }

                number %= 100;

                if (number < 20)
                {
                    words += ones[number];
                }
                else
                {
                    words += tens[number / 10];
                    if (number % 10 != 0)
                    {
                        words += "-" + ones[number % 10];
                    }
                }

                return words.Trim();
            }

            static int CountLetters(string word)
            {
                int letterCount = 0;
                foreach (char c in word)
                {
                    if (char.IsLetter(c))
                    {
                        letterCount++;
                    }
                }
                return letterCount;
            }
        }
    }
}
