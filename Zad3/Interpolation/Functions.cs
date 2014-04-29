using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolation
{
    abstract class Function
    {
        protected string text = "";
        public string Text { get { return text; } }
        public abstract double GetValue(double x);
    }

    class Polynomial : Function //x in < -0.5, 2.5 > --- looks interesting
    {
        public override double GetValue(double x)
        {
            return x *x - 2 * x - 1; //x^2 - 2x - 1
        }
    }

    class Exponential : Function
    {
        public override double GetValue(double x)
        {
            return Math.Pow(3, x);
        }
    }

    class Logarithmic : Function
    {
        public override double GetValue(double x)
        {
            return Math.Log(x);
        }
    }

    class Sinus : Function
    {
        public override double GetValue(double x)
        {
            return Math.Sin(x);
        }
    }

    class Spline1 : Function
    {
        public override double GetValue(double x)
        {
            Function fun1 = new Sinus();
            Function fun2 = new Exponential();

            return fun1.GetValue(fun2.GetValue(x)); //sin(3^x)
        }
    }

    class Spline2 : Function
    {
        public override double GetValue(double x)
        {
            Function fun1 = new Sinus();
            Function fun2 = new Logarithmic();

            return fun1.GetValue(fun2.GetValue(x)); //sin(ln(x))
        }
    }

    class Spline3 : Function
    {
        public override double GetValue(double x)
        {
            Function fun1 = new Sinus();
            Function fun2 = new Polynomial();

            return fun1.GetValue(fun2.GetValue(x)); //sin(x^2 - 2x - 1)
        }
    }
}
