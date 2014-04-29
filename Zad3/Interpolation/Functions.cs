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

    class Polynomial : Function
    {
        public Polynomial ()
        {
            text = "x^3";
        }

        public override double GetValue(double x)
        {
            return x * x * x;
        }
    }
}
