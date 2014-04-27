using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolation
{
    public struct Point
    {
        public double x, y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
    }

    class NewtonInterpolation
    {
        

        double GetVarT(double x0, double distance, double x)
        {
            double result = (x - x0) / (distance);
            return result;
        }

        public double Interpolate(List<Point> nodes, double x)
        {
            DateTime time = DateTime.Now;

            double result = 0;
            for (int k = 0; k < nodes.Count(); k++)
            {
                double t;
                double h = 0;
                
                if (k > 0)
                {
                    h = nodes[k].x - nodes[k-1].x;
                }
                else
                {
                    h = 0;
                }

                t = GetVarT(nodes[0].x, h, x);

                double tmpDiff = ProgressiveDifference(k, nodes) * CountFactor(k, t) / factorial((UInt64)k);
                result += tmpDiff;
            }
            
            return result;
        }

        double CountFactor (double k, double t)
        {
            double result = 1;
            if (k >= 0)
            {
                for (int m = 0; m < k; m++)
                {
                    result *= t - m;
                }
            }
            
            return result;
        }

        double ProgressiveDifference (int k, List<Point> nodes)
        {
            double result = 0;

            for (int i = 0; i <= k; i++)
            {
                result += (double)Math.Pow(-1, k - i) * NewtonSymbol((UInt64)k, (UInt64)i) * nodes[i].y;
            }

            return result;
        }

        int NewtonSymbol(UInt64 n, UInt64 k)
        {
            UInt64 result = factorial(n) / (factorial(k) * factorial(n - k));
            return (int)result;
        }

        public static UInt64 factorial(UInt64 x)
        {
            UInt64 result = 1;
            if (x <= 0)
                return result;

            for (UInt64 i = 1; i <= x; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
