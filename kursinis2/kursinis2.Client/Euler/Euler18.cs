﻿using System.Numerics;

namespace kursinis2.Client.Euler
{
    public sealed class Euler18 : EulerFormat, EulerInterface
    {
        public string? description { get; set; }
        public new string? ans { get; set; }
        public new int num { get; set; }

        public Euler18(string description)
        {
            this.description =
                description;
            base.ans = this.ans = answer().ToString();
            base.num = this.num = 18;
        }

        public static long answer()
        {
            int[][] triangle = {
            new int[] {75},
            new int[] {95, 64},
            new int[] {17, 47, 82},
            new int[] {18, 35, 87, 10},
            new int[] {20, 04, 82, 47, 65},
            new int[] {19, 01, 23, 75, 03, 34},
            new int[] {88, 02, 77, 73, 07, 63, 67},
            new int[] {99, 65, 04, 28, 06, 16, 70, 92},
            new int[] {41, 41, 26, 56, 83, 40, 80, 70, 33},
            new int[] {41, 48, 72, 33, 47, 32, 37, 16, 94, 29},
            new int[] {53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14},
            new int[] {70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57},
            new int[] {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48},
            new int[] {63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31},
            new int[] {04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}
        };

            for (int row = triangle.Length - 2; row >= 0; row--)
            {
                for (int col = 0; col < triangle[row].Length; col++)
                {
                    triangle[row][col] += Math.Max(triangle[row + 1][col], triangle[row + 1][col + 1]);
                }
            }
            return triangle[0][0];
        }


    }
}
