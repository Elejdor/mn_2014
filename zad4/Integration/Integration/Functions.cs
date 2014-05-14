using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
    abstract class Function
    {
        public string formulaSimpson;
        public string formulaLaguerre;
        public string formulaHermite;

        public abstract double Calculate(double x);

        public override string ToString()
        {
            return formulaSimpson;
        }
    }

    class fXto2 : Function
    {
        public fXto2()
        {
            formulaSimpson = "x^2";
            formulaLaguerre = "e^-x * x^2";
            formulaHermite = "e^-x^2 * x^2";
        }
        public override double Calculate (double x)
        {
            return x * x;
        }
    }

    class fCos2x : Function
    {
        public fCos2x()
        {
            formulaSimpson = "cos(2x)";
            formulaLaguerre = "e^-x * cos(2x)";
            formulaHermite = "e^-x^2 * cos(2x)";
        }
        public override double Calculate(double x)
        {
            return Math.Cos(2 * x);
        }
    }

    class f3sinx : Function
    {
        public f3sinx()
        {
            formulaSimpson = "3sin(x)";
            formulaLaguerre = "e^-x * 3sin(x)";
            formulaHermite = "e^-x^2 * 3sin(x)";
        }
        public override double Calculate(double x)
        {
            return 3 * Math.Sin(x);
        }
    }

    class f2toX : Function
    {
        public f2toX()
        {
            formulaSimpson = "2^x";
            formulaLaguerre = "e^-x * 2^x";
            formulaHermite = "e^-x^2 * 2^x";
        }

        public override double Calculate(double x)
        {
            return Math.Pow(2, x);
        }

    }
}
