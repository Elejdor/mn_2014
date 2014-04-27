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
        List<Point> nodes = new List<Point>();

        public Form1()
        {
            InitializeComponent();

        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            float jump;
            float nodesJump;
            int numberOfNodes;
            float startingNodeX;
            if (float.TryParse(tbJump.Text, out jump) && 
                float.TryParse(tbJumpNodes.Text, out nodesJump) && 
                int.TryParse(tbNodesNumber.Text, out numberOfNodes) && 
                float.TryParse(tbStartingNode.Text, out startingNodeX))
            {
                NewtonInterpolation interpolator = new NewtonInterpolation();
                List<Point> interpolated = new List<Point>();

                GenerateNodes(numberOfNodes, nodesJump, startingNodeX, x3);

                Debug.Log("Interpolation started");
                double b = nodes[nodes.Count() - 1].x;
                DateTime time = DateTime.Now;

                for (float x = startingNodeX; x < b; x += jump)
                {
                    interpolated.Add(new Point(x, interpolator.Interpolate(nodes, x)));
                }

                Debug.Log("Interpolation finished in " + (DateTime.Now - time).TotalSeconds.ToString() + " s.");

                FormPlot form = new FormPlot(nodes, interpolated, x3);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong arguments. Note that a floating point number separator is coma (ex. 1,5).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateNodes(int numberOfNodes, float jump, double firstNodeX, Func<double, double> function)
        {
            nodes.Clear();
            for (int i = 0; i < numberOfNodes; i++)
            {
                double x = firstNodeX + (double)i * jump;
                nodes.Add(new Point(x, function(x)));
            }

        }

        private double x3(double x)
        {
            //return (float)Math.Pow(x, 3);
            return Math.Sin(x);
        }
    }
}
