using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
    class HermiteIntegrator
    {
        private List<Quadrature> quadratures = new List<Quadrature>();

        public void initializeListOfQuadratures(int numberOfNodes)
        {
            switch (numberOfNodes)
            {
                case 2:
                    quadratures.Add(new Quadrature(-0.707106781187, 0.886226925453));
                    quadratures.Add(new Quadrature(0.707106781187, 0.886226925453));
                    break;
                case 3:
                    quadratures.Add(new Quadrature(-1.22474487139, 0.295408975151));
                    quadratures.Add(new Quadrature(0.0, 1.1816359006));
                    quadratures.Add(new Quadrature(1.22474487139, 0.295408975151));
                    break;
                case 4:
                    quadratures.Add(new Quadrature(-1.65068012389, 0.0813128354472));
                    quadratures.Add(new Quadrature(-0.524647623275, 0.804914090006));
                    quadratures.Add(new Quadrature(0.524647623275, 0.804914090006));
                    quadratures.Add(new Quadrature(1.65068012389, 0.0813128354472));
                    break;
                case 5:
                    quadratures.Add(new Quadrature(-2.02018287046, 0.019953242059));
                    quadratures.Add(new Quadrature(-0.958572464614, 0.393619323152));
                    quadratures.Add(new Quadrature(0.0, 0.945308720483));
                    quadratures.Add(new Quadrature(0.958572464614, 0.393619323152));
                    quadratures.Add(new Quadrature(2.02018287046, 0.019953242059));
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
