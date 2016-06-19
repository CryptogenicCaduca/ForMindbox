using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle
    {
        /// <summary>
        /// Calculate square of triangle by three sides
        /// </summary>
        /// <param name="a">First side</param>
        /// <param name="b">Second side</param>
        /// <param name="c">Third side</param>
        /// <returns>if values are wrong then returns 0 else returns square of triangle</returns>
        public double Square(double a, double b, double c)
        {
            //Check input
            if ((a + b <= c) || (a + c <= b) || (c + b <= a) ||
                (a <= 0) || (b <= 0) || (c <= 0))
                return 0;
            double pd2 = (a + b + c)/2;
            double s = Math.Sqrt((pd2*(pd2 - a)*(pd2 - b)*(pd2 - c)));
            return s;
        }
    }
}
