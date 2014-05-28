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
    public partial class Form1 : Form
    {
        List<BaseFunction> functions = new List<BaseFunction>();
        public Form1()
        {
            InitializeComponent();
            functions.Add(new FuncLiniowa());
            functions.Add(new FuncModulo());
            functions.Add(new FuncTrygonometryczna());
            functions.Add(new FuncWielomian());
            functions.Add(new FuncWykladnicza());

            cbFunction.Items.Clear();

            foreach(BaseFunction func in functions)
            {
                cbFunction.Items.Add(func.ToString());
            }
        }
        void Approximate()
        {
            int choice = cbFunction.SelectedIndex + 1, degree, nodesCount;
            double a, b, epsilon, err = 0;
            const int grainess = 2000;
            double[] arguments = new double[grainess];
            double[] values = new double[grainess];

            double.TryParse(tbFrom.Text, out a);
            double.TryParse(tbTo.Text, out b);

            FillPoints(arguments, a, b, grainess);

            int.TryParse(cbNodes.Text, out nodesCount);
            
            if (!cbDecission.Checked)
            {
                int.TryParse(tbStop.Text, out degree);
                int.TryParse(cbNodes.Text, out nodesCount);
                FindFunctionValuesBy(values, arguments, choice, degree, nodesCount, grainess);
                err = blad(choice, nodesCount, degree);
            }
            else
            {
                //dokladnosc
                double.TryParse(tbStop.Text, out epsilon);
                degree = 1;
                do
                {
                    FindFunctionValuesBy(values, arguments, choice, degree, nodesCount, grainess);

                    err = blad(choice, nodesCount, degree);
                    degree += 1;
                } while (Math.Abs(err) > epsilon);
                Console.WriteLine("Stopien wielomianu: " + degree);
            }
            RysujWykres(a, b, arguments, values, grainess);

        }

        //double Hermite(int n, double x)
        //{
        //    if (n == 0) return 1;
        //    if (n == 1) return 2 * x;
        //    return (2 * x * Hermite(n - 1, x)) - (2 * (n - 1) * Hermite(n - 2, x));
        //}

        double Hermite (int n, double x)
        {            
            if (n == 0) return 1;
            else if (n == 1) return 2 * x;
            else
            {
                List<double> result = new List<double>();
                result.Add(1);
                result.Add(2 * x);

                for (int i = 2; i <= n; i++)
                {
                    result.Add(2 * x * result[i - 1] - 2 * (i - 1) * result[i - 2]);
                }
                return result[result.Count - 1];
            }
        }
        UInt64 factorial(int n)
        {
            UInt64 s = 1;
            for (int i = 1; i <= n; i++) s *= (UInt64)i;
            return s;
        }

        double potega(double x, int n)
        {
            if (n == 0) return 1;
            double p = x;
            for (int i = 1; i < n; i++) p *= x;
            return p;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wybor">wybór funkcji</param>
        /// <param name="n">ile węzłów</param>
        /// <param name="k">aktualny stopień</param>
        /// <param name="stopien">stopień wielomianu końcowego</param>
        /// <returns></returns>
        double GetLambda(int wybor, int n, int k, int stopien)
        {
            double suma = 0;

            List<double> wezly = new List<double>();
            List<double> wagi = new List<double>();

            switch (n)
            {
                case 2:
                    wezly.Add(-0.707107);
                    wezly.Add(0.707107);
                    wagi.Add(0.886227);
                    wagi.Add(0.886227);
                    break;
                case 3:
                    wezly.Add(-1.224745);
                    wezly.Add(0.0);
                    wezly.Add(1.224745);
                    wagi.Add(0.295409);
                    wagi.Add(1.181636);
                    wagi.Add(0.295409);
                    break;
                case 4:
                    wezly.Add(-1.650680);
                    wezly.Add(-0.524648);
                    wezly.Add(0.524648);
                    wezly.Add(1.650680);
                    wagi.Add(0.081313);
                    wagi.Add(0.804914);
                    wagi.Add(0.804914);
                    wagi.Add(0.081313);
                    break;
                case 5:
                    wezly.Add(-2.020183);
                    wezly.Add(-0.958572);
                    wezly.Add(0.0);
                    wezly.Add(0.958572);
                    wezly.Add(2.020183);
                    wagi.Add(0.019953);
                    wagi.Add(0.393619);
                    wagi.Add(0.945309);
                    wagi.Add(0.393619);
                    wagi.Add(0.019953);
                    break;
            }

            for (int i = 0; i < wezly.Count(); i++)
            {
                suma += wagi[i] * functions[cbFunction.SelectedIndex].f(wezly[i]) * Hermite(k, wezly[i]);
            }

            return suma;
        }


        double aproksymacja(double arg, int numerFunkcji, int stopienWielomianu, int ileWezlow)
        {
            double suma = 0;
            for (int i = 0; i <= stopienWielomianu; i++)
            {
                double nominator = GetLambda(numerFunkcji, ileWezlow, i, stopienWielomianu) * Hermite(i, arg);
                double denominator =  (potega(2, i) * factorial(i) * Math.Sqrt(Math.PI));
                suma += nominator/denominator;
            }
            return suma;
        }

        void FindFunctionValuesBy(double[] nodesVals, double[] nodes, int choice, int degree, int nodesCount, int grainess)
        {
            for (int i = 0; i < grainess; i++)
            {
                nodesVals[i] = aproksymacja(nodes[i], choice, degree, nodesCount);
            }

        }

        void FillPoints(double[] pointReference, double a, double b, int grainess)
        {

            double przedzial = Math.Abs((a - 1) - (b + 1));
            double odstepMiedzyWezlami = przedzial / grainess;
            pointReference[0] = a - 1;

            for (int i = 1; i < grainess; i++)
            {
                pointReference[i] = pointReference[i - 1] + odstepMiedzyWezlami;
            }
        }

        double blad(int wybor, int n, int stopienWielomianu)
        {
            double E = 0;

            List<double> wezly = new List<double>();
            List<double> wagi = new List<double>();

            switch (n)
            {
                case 2:
                    wezly.Add(-0.707107);
                    wezly.Add(0.707107);
                    wagi.Add(0.886227);
                    wagi.Add(0.886227);
                    break;
                case 3:
                    wezly.Add(-1.224745);
                    wezly.Add(0.0);
                    wezly.Add(1.224745);
                    wagi.Add(0.295409);
                    wagi.Add(1.181636);
                    wagi.Add(0.295409);
                    break;
                case 4:
                    wezly.Add(-1.650680);
                    wezly.Add(-0.524648);
                    wezly.Add(0.524648);
                    wezly.Add(1.650680);
                    wagi.Add(0.081313);
                    wagi.Add(0.804914);
                    wagi.Add(0.804914);
                    wagi.Add(0.081313);
                    break;
                case 5:
                    wezly.Add(-2.020183);
                    wezly.Add(-0.958572);
                    wezly.Add(0.0);
                    wezly.Add(0.958572);
                    wezly.Add(2.020183);
                    wagi.Add(0.019953);
                    wagi.Add(0.393619);
                    wagi.Add(0.945309);
                    wagi.Add(0.393619);
                    wagi.Add(0.019953);
                    break;
            }
            for (int i = 0; i < wezly.Count(); i++)
            {
                E += wagi[i] * (functions[cbFunction.SelectedIndex].f(wezly[i]) - aproksymacja(wezly[i], wybor, stopienWielomianu, n)) * (functions[cbFunction.SelectedIndex].f(wezly[i]) - aproksymacja(wezly[i], wybor, stopienWielomianu, n));
            }
            E = Math.Sqrt(E);
            return E;
        }

        void RysujWykres(double przedzialOd, double przedzialDo, double[] punkty, double[] wartosciPunktow, int ilePunktow)
        {
            List<double> args = new List<double>();
            List<double> vals = new List<double>();
            for (int i = 0; i < ilePunktow; i++)
            {
                args.Add(punkty[i]);
                vals.Add(wartosciPunktow[i]);
            }

            FormPlot plot = new FormPlot(args, vals, functions[cbFunction.SelectedIndex].f);
            plot.Show();
        }

        private void cbDecission_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                lbNodes.Text = "Błąd aproksymacji:";
            }
            else
            {
                lbNodes.Text = "Stopień wielomianu:";
            }
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            Approximate();
        }
    }
}
