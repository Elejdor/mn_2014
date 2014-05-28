using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HermiteAprox2
{
    public partial class FormPlot : Form
    {
        public FormPlot(List<double> args, List<double> vals, Func<double, double> function)
        {
            InitializeComponent();
            for (int i = 0; i < args.Count; i++)
            {
                chart1.Series["Approximation"].Points.AddXY(args[i], vals[i]);
                chart1.Series["Function"].Points.AddXY(args[i], function(args[i]));
            }
        }
    }
}
