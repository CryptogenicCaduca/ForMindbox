using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class RightTriangle
    {
        /// <summary>
        /// Calculate square of right-angled triangle by three sides
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
            //Choose catheti
            if (Math.Abs(a*a + c*c - b*b) < Double.Epsilon)
                return a*c/2;
            if (Math.Abs(c*c + b*b - a*a) < Double.Epsilon)
                return c*b/2;
            if (Math.Abs(a*a + b*b - c*c) < Double.Epsilon)
                return a*b/2;
            return 0;
        }
    }
}
