using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
    class Quadrature
    {
        double node;

        public double Node
        {
            get { return node; }
            set { node = value; }
        }
        double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Quadrature(double n, double w)
        {
            this.node = n;
            this.weight = w;
        }
    }
}
