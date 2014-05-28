using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HermiteAprox2
{
    abstract class BaseFunction
    {        
        abstract public double f(double x);
        abstract public override string ToString();
    }

    class FuncLiniowa : BaseFunction
    {

        public override double f(double x)
        {
            return 4 * x - 2;
        }

        public override string ToString()
        {
            return "4x - 2";
        }
    }

    class FuncModulo : BaseFunction
    {

        public override double f(double x)
        {
            return Math.Abs(x);
        }

        public override string ToString()
        {
            return "|x|";
        }
    }

    class FuncWielomian : BaseFunction
    {

        public override double f(double x)
        {
            double[] factors = { 6, -4, 6, 4 };
            double result = factors[0];

            for (int i = 1; i < 4; i++)
            {
                result = result * x + factors[i];
            }
            return result;
        }

        public override string ToString()
        {
            return "6x^3 - 4x^2 + 6x + 4";
        }
    }

    class FuncTrygonometryczna : BaseFunction
    {

        public override double f(double x)
        {
            return Math.Sin(x);
        }

        public override string ToString()
        {
            return "sin(x)";
        }
    }

    class FuncWykladnicza : BaseFunction
    {

        public override double f(double x)
        {
            return Math.Exp(x);
        }

        public override string ToString()
        {
            return "e^x";
        }
    }
}
