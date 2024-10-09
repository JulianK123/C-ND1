using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursinis2.Client.Euler
{

    //abs. klasė 0.5b
    public abstract class EulerFormat
    {

        public string ans;
        public int num;

        //IFormattable implemetacija 1b
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return $"Result of {num} Eulers Problem is: {ans}";
        }
    }
}
