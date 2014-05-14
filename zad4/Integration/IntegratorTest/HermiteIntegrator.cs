using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
   public  class HermiteIntegrator
    {
        List<Quadrature> twoNodesQuadratures = new List<Quadrature>();
        List<Quadrature> threeNodesQuadratures = new List<Quadrature>();
        List<Quadrature> fourNodesQuadratures = new List<Quadrature>();
        public List<Quadrature> fiveNodesQuadratures = new List<Quadrature>();

        public void initializeListOfQuadratures(int numberOfnodes)
        {
            switch (numberOfnodes)
            {
                case 2:
                    twoNodesQuadratures.Add(new Quadrature(-0.707106781187, 0.886226925453));
                    twoNodesQuadratures.Add(new Quadrature(0.707106781187, 0.886226925453));
                    break;
                case 3:
                    threeNodesQuadratures.Add(new Quadrature(-1.22474487139, 0.295408975151));
                    threeNodesQuadratures.Add(new Quadrature(0.0, 1.1816359006));
                    threeNodesQuadratures.Add(new Quadrature(1.22474487139, 0.295408975151));
                    break;
                case 4:
                    fourNodesQuadratures.Add(new Quadrature(-1.65068012389, 0.0813128354472));
                    fourNodesQuadratures.Add(new Quadrature(-0.524647623275, 0.804914090006));
                    fourNodesQuadratures.Add(new Quadrature(0.524647623275, 0.804914090006));
                    fourNodesQuadratures.Add(new Quadrature(1.65068012389, 0.0813128354472));
                    break;
                case 5:
                    fiveNodesQuadratures.Add(new Quadrature(-2.02018287046, 0.019953242059));
                    fiveNodesQuadratures.Add(new Quadrature(-0.958572464614, 0.393619323152));
                    fiveNodesQuadratures.Add(new Quadrature(0.0, 0.945308720483));
                    fiveNodesQuadratures.Add(new Quadrature(0.958572464614, 0.393619323152));
                    fiveNodesQuadratures.Add(new Quadrature(2.02018287046, 0.019953242059));
                    break;
            }
        }

        public double Integrate(Func<double, double> f, List<Quadrature> quads)
        {
            double result = 0.0;
            for (int i = 0; i < quads.Count; i++)
            {
                result += quads[i].Weight + f(quads[i].Node);
            }

            //double error = (1 / 120) * (720 / 4); //????
            return result;
        }
    }
}
