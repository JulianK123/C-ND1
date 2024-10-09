using System.Numerics;

namespace kursinis2.Client.Euler
{
    public sealed class Euler19 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler19(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 19;
        }

        public static long answer()
        {
            int sundaysOnFirst = 0;

            int dayOfWeek = 2;
            int startYear = 1901;
            int endYear = 2000;

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int year = startYear; year <= endYear; year++)
            {
                for (int month = 0; month < 12; month++)
                {
                    if (dayOfWeek == 0)
                    {
                        sundaysOnFirst++;
                    }

                    dayOfWeek += daysInMonth[month];

                    if (month == 1 && IsLeapYear(year))
                    {
                        dayOfWeek++;
                    }

                    dayOfWeek %= 7;
                }
            }
            return sundaysOnFirst;

            bool IsLeapYear(int year)
            {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        return year % 400 == 0;
                    }
                    return true;
                }
                return false;
            }
        }


    }
}
