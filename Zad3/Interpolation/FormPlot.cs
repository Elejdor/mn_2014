using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Interpolation
{
    public partial class FormPlot : Form
    {
        public FormPlot(List<Point> nodes, List<Point> interpolated, Func<double, double> function)
        {
            InitializeComponent();
            foreach (Point element in interpolated)
            {
                chart1.Series["Interpolation"].Points.AddXY(element.x, element.y);
            }

            foreach (Point element in nodes)
            {
                chart1.Series["Nodes"].Points.AddXY(element.x, element.y);
            }

            for (double x = nodes[0].x; x < nodes[nodes.Count-1].x; x += 0.001f)
            {
                chart1.Series["Function"].Points.AddXY(x, function(x));
            }
        }

        private void FormPlot_Load(object sender, EventArgs e)
        {

        }
    }
}
