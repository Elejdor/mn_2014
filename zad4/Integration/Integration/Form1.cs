using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integration
{
    public partial class Form1 : Form
    {
        FuncList functions = new FuncList();
        public Form1()
        {
            InitializeComponent();
            functions.Changed += functions_Changed;
            functions.Add(new fXto2());
            functions.Add(new fCos2x());
            functions.Add(new f3sinx());
            functions.Add(new f2toX());
        }

        void functions_Changed(object sender, EventArgs e)
        {
            cbFunction.Items.Clear();
            foreach (Function foo in functions)
            {
                cbFunction.Items.Add(foo.ToString());
            }
        }

        private void btnSimpsounCount_Click(object sender, EventArgs e)
        {
            simpson.SimpsonIntegrator integrator = new simpson.SimpsonIntegrator();
            double a, b, error, result;
            double.TryParse(tbSimA.Text, out a);
            double.TryParse(tbSimB.Text, out b);
            double.TryParse(tbBladObliczen.Text, out error);

            result = integrator.Integrate(functions[cbFunction.SelectedIndex].Calculate, a,b,error);
            lbSimpsonResult.Text = result.ToString();
        }

        private void btnHerCount_Click(object sender, EventArgs e)
        {
            double result = 0, lim;
            int nodes;

            double.TryParse(tbLim.Text, out lim);
            int.TryParse(comboNodes.Text, out nodes);

            if (rbHermit.Checked == true)
            {
                HermiteIntegrator integrator = new HermiteIntegrator();
                result = integrator.Integrate(functions[cbFunction.SelectedIndex], nodes);
            }
            else if (rbLag.Checked == true)
            {
                LaguerreIntegrator integrator = new LaguerreIntegrator();
                result = integrator.Integrate(functions[cbFunction.SelectedIndex], nodes);
            }

            lbHerLagResult.Text = result.ToString();
        }
    }
}
