using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolation
{
    public struct Point
    {
        public double x;
        public double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

    }

    class NewtonChebyshevInterpolation
    {
        public static double HornerScheme(List<double> tabA, double x)
        {
            double result = tabA[0];
            for (int i = 1; i < tabA.Count(); i += 1)
            {
                result = result * x + tabA[i];
            }
            return result;
        }

        double DifferentialQuotient(Point p1, Point p2)
        {
            return (p2.y - p1.y) / (p2.x - p1.x);
        }

        List<double> PolynomialsProduct(List<double> A, List<double> B)
        {
	        List<double> result = new List<double>();
	        for (uint i = 0; i < (A.Count() + B.Count() - 1); i += 1) result.Add(0);

	        for (int i = 0; i < A.Count(); i += 1)
	        {
		        for (int j = 0; j < B.Count(); j += 1)
		        {
			        result[i + j] += A[i] * B[j];
		        }
	        }
	        return result;
        }

        List<double> AddPolynomials (List<double> A, List<double> B)
        {
            List<double> result, tmpA, tmpB;

            if (A.Count() > B.Count())
            {
                tmpA = A;
                tmpB = B;
            }
            else
            {
                tmpA = B;
                tmpB = A;
            }

            result = new List<double>(tmpA);
            result.Reverse();
            for (int i = 0; i < tmpB.Count(); i++)
            {
                result[i] += tmpB[tmpB.Count()-i-1];
            }

            result.Reverse();
            return result;
        }

        public List<double> GetInterpolationPolynomial(List<Point> nodes)
        {
            List<Point> result = new List<Point>();
            int degree = nodes.Count();

	        List<List<double>> differentialQuotients = new List<List<double>>();
            for (int i = 0; i < degree; i++ )
            {
                differentialQuotients.Add(new List<double>());
            }

            foreach (Point node in nodes)
            {
                differentialQuotients[0].Add(node.y);
            }

	        for (int i = 1; i < degree; i += 1)
	        {
		        for (int j = 0; j < degree - i; j += 1)
		        {
			        differentialQuotients[i].Add(DifferentialQuotient(new Point(nodes[j].x, differentialQuotients[i - 1][j]), new Point(nodes[j + i].x, differentialQuotients[i - 1][j + 1])));
		        }
	        }
                        
            List<double> polynomial = new List<double>();
            for (int i = 0; i < degree; i += 1) polynomial.Add(0);

            for (int i = 0; i < degree; i += 1)
            {
                List<double> fi = new List<double>();
                fi.Add(differentialQuotients[i][0]);
                for (int j = 0; j < i; j += 1)
                {
                    List<double> tmp = new List<double>();
                    tmp.Add(1);
                    tmp.Add(-nodes[j].x);
                    fi = PolynomialsProduct(fi, tmp);
                }

                polynomial = AddPolynomials(polynomial, fi);
            }

            return polynomial;
        }

        public List<Point> Interpolate (List<Point> nodes, List<double> domain)
        {
            List<Point> result = new List<Point>();
            List<double> interpolationPoly = GetInterpolationPolynomial(nodes);
            foreach (double x in domain)
            {
                result.Add(new Point(x, HornerScheme(interpolationPoly, x)));
            }

            return result;
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
                double h = nodes[1].x - nodes[0].x;
                double t = (x - nodes[0].x) / (h);

                double tmpDiff = ProgressiveDifference(k, nodes) * CountFactor(k, t) / factorial((UInt64)k);
                result += tmpDiff;
            }

            return result;
        }

        double CountFactor(double k, double t)
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

        double ProgressiveDifference(int k, List<Point> nodes)
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
