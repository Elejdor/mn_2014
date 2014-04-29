using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Interpolation
{
    public partial class Form1 : Form
    {
        public List<Point> ChebyshevNodes(int n, double a, double b, Func<double, double> function)
        {
            List<Point> result = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                double xn = Math.Cos(((2 * i + 1) * Math.PI) / (2 * n + 1));
                double x = 0.5 * ((b - a) * xn + (a + b));
                result.Add(new Point(x, function(x)));
            }

            result.Reverse();
            return result;
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            Function function = new Polynomial();

            if (rbChebyshev.Checked)
            {
                ChebyshevInterpolation(function);
            }
            else
            {
                EquiDistantInterpolation(function);
            }
        }

        private List<Point> EquiDistantInterpolation (Function func)
        {
            float jump;
            float nodesJump;
            int numberOfNodes;
            float startingNodeX;
            List<Point> nodes = new List<Point>();
            List<Point> interpolated = new List<Point>();

            if (float.TryParse(tbJump.Text, out jump) &&
                float.TryParse(tbJumpNodes.Text, out nodesJump) &&
                int.TryParse(tbNodesNumber.Text, out numberOfNodes) &&
                float.TryParse(tbStartingNode.Text, out startingNodeX))
            {
                NewtonInterpolation interpolator = new NewtonInterpolation();

                nodes = GenerateNodes(numberOfNodes, nodesJump, startingNodeX, func.GetValue);

                Debug.Log("Interpolation started");
                double b = nodes[nodes.Count() - 1].x;
                DateTime time = DateTime.Now;

                for (double x = nodes[0].x; x < b; x += jump)
                {
                    interpolated.Add(new Point(x, interpolator.Interpolate(nodes, x)));
                }

                Debug.Log("Interpolation finished in " + (DateTime.Now - time).TotalSeconds.ToString() + " s.");

                FormPlot form = new FormPlot(nodes, interpolated, func.GetValue);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong arguments. Note that a floating point number separator is coma (ex. 1,5).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return interpolated;
        }

        private List<Point> ChebyshevInterpolation (Function func)
        {
            List<Point> interpolated;
            int numberOfNodes;
            float a, b, jump;
            if (float.TryParse(tbJump.Text, out jump) &&
                float.TryParse(tbBegin.Text, out a) &&
                float.TryParse(tbEnd.Text, out b) &&
                int.TryParse(tbNodesNumber.Text, out numberOfNodes))
            {
                NewtonChebyshevInterpolation interpolator = new NewtonChebyshevInterpolation();
                List<Point> nodes = new List<Point>();
                List<double> domain = new List<double>();

                nodes = ChebyshevNodes(numberOfNodes, a, b, func.GetValue);

                for (double x = nodes[0].x; x < b; x += jump)
                {
                    domain.Add(x);
                }

                interpolated = interpolator.Interpolate(nodes, domain);

                FormPlot form = new FormPlot(nodes, interpolated, func.GetValue);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong arguments. Note that a floating point number separator is coma (ex. 1,5).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return interpolated;
        }

        private List<Point> GenerateNodes(int numberOfNodes, float jump, double firstNodeX, Func<double, double> function)
        {
            List<Point> result = new List<Point>();
            for (int i = 0; i < numberOfNodes; i++)
            {
                double x = firstNodeX + (double)i * jump;
                result.Add(new Point(x, function(x)));
            }
            return result;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panelEqui.Enabled = !panelEqui.Enabled;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panelChebyshev.Enabled = !panelChebyshev.Enabled;
        }
    }
}
