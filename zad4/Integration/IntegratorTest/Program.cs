using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simpson;
using Integration;

namespace IntegratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimpsonIntegrator.Integrate(x => x * x, 0, 2, 0.01));
            LaguerreIntegrator lagIntegrator = new LaguerreIntegrator();
            lagIntegrator.initializeListOfQuadratures(5);
            Console.WriteLine(lagIntegrator.Integrate(new Function(), lagIntegrator.fiveNodesQuadratures));
            HermiteIntegrator herIntegrator = new HermiteIntegrator();
            herIntegrator.initializeListOfQuadratures(5);
            Console.WriteLine(herIntegrator.Integrate(new Function(), herIntegrator.fiveNodesQuadratures));
            Console.ReadKey();
        }
    }
}
