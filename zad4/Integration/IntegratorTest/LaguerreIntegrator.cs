using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integration;

namespace Integration
{
    class LaguerreIntegrator
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
                    twoNodesQuadratures.Add(new Quadrature(0.585786, 0.853553));
                    twoNodesQuadratures.Add(new Quadrature(3.41421, 0.146447));
                    break;
                case 3:
                    threeNodesQuadratures.Add(new Quadrature(0.415775, 0.711093));
                    threeNodesQuadratures.Add(new Quadrature(2.29428, 0.278518));
                    threeNodesQuadratures.Add(new Quadrature(6.28995, 0.0103893));
                    break;
                case 4:
                    fourNodesQuadratures.Add(new Quadrature(0.322548, 0.603154));
                    fourNodesQuadratures.Add(new Quadrature(1.74576, 0.357419));
                    fourNodesQuadratures.Add(new Quadrature(4.53662, 0.0388879));
                    fourNodesQuadratures.Add(new Quadrature(9.39507, 0.000539295));
                    break;
                case 5:
                    fiveNodesQuadratures.Add(new Quadrature(0.26356, 0.521756));
                    fiveNodesQuadratures.Add(new Quadrature(1.4134, 0.398667));
                    fiveNodesQuadratures.Add(new Quadrature(3.59643, 0.0759424));
                    fiveNodesQuadratures.Add(new Quadrature(7.08581, 0.00361176));
                    fiveNodesQuadratures.Add(new Quadrature(12.6408, 0.00002337));
                    break;
            }
        }
            public double Integrate(Function f, List<Quadrature> quads)
            {
                double result = 0.0;
                for (int i =0; i<quads.Count; i++)
                {
                    result += quads[i].Weight * f.Calculate(quads[i].Node);
                }
                double error = (1 / 120) * (720 / 4); //????
                return result + error;
            }
        }
        
        

     

        
    }

