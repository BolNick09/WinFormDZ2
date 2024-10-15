using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Form_2
{
    public partial class FrmQuadEquation : Form
    {
        public FrmQuadEquation()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            double a, b, c;
            try
            {
                a = double.Parse(tbA.Text);
                b = double.Parse(tbB.Text);
                c = double.Parse(tbC.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода");
                return;
            }
            double discr = b * b - 4 * a * c;
            if (discr < 0)
            {
                MessageBox.Show("The equation has no real roots.");
            }
            else if (discr == 0)
            {
                double root = -b / (2 * a);
                MessageBox.Show($"The equation has a single root: {root}");
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discr)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discr)) / (2 * a);
                MessageBox.Show($"The equation has two roots: {root1} and {root2}");
            }
        }
    }
}
