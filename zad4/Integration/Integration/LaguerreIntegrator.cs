using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simpson;

namespace Integration
{
    class LaguerreIntegrator
    {
        private List<Quadrature> quadratures = new List<Quadrature>();

        public void initializeListOfQuadratures(int numberOfNodes)
        {
            switch (numberOfNodes)
            {
                case 2:
                    quadratures.Add(new Quadrature(0.585786, 0.853553));
                    quadratures.Add(new Quadrature(3.41421, 0.146447));
                    break;
                case 3:
                    quadratures.Add(new Quadrature(0.415775, 0.711093));
                    quadratures.Add(new Quadrature(2.29428, 0.278518));
                    quadratures.Add(new Quadrature(6.28995, 0.0103893));
                    break;
                case 4:
                    quadratures.Add(new Quadrature(0.322548, 0.603154));
                    quadratures.Add(new Quadrature(1.74576, 0.357419));
                    quadratures.Add(new Quadrature(4.53662, 0.0388879));
                    quadratures.Add(new Quadrature(9.39507, 0.000539295));
                    break;
                case 5:
                    quadratures.Add(new Quadrature(0.26356, 0.521756));
                    quadratures.Add(new Quadrature(1.4134, 0.398667));
                    quadratures.Add(new Quadrature(3.59643, 0.0759424));
                    quadratures.Add(new Quadrature(7.08581, 0.00361176));
                    quadratures.Add(new Quadrature(12.6408, 0.00002337));
                    break;
            }
        }
        public double Integrator(Function f)
        {
            double result = 0.0;
            for (int i = 0; i < quadratures.Count; i++)
            {
                result += quadratures[i].Weight * f.Calculate(quadratures[i].Node);
            }

            double error = (1 / 120) * (720 / 4); //????
            return result + error;
        }


        public double LimitCount(Function f, double eps)
        {

            double result = 0.0;
            double a = 1.0;
            double delta = 0.5;
            SimpsonIntegrator simpsonInteg = new SimpsonIntegrator();
            result += simpsonInteg.Integrate(f.Calculate, 0, a, 0.01);
            while (result > eps)
            {
                result += simpsonInteg.Integrate(f.Calculate, a, a + delta, 0.01);
                a = a + delta;
            }

            return result;
        }

        public double Integrate(Function f, int numberOfNodes)
        {
            this.initializeListOfQuadratures(numberOfNodes);
            double result = this.Integrator(f);
            this.quadratures.Clear();
            return result;
        }
    }

}

