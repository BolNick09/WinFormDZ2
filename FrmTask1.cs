using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace My_Form_2
{
    public partial class FrmTask1 : Form
    {
        int left = 10;
        int right;
        int top = 10;
        int down;
        public FrmTask1()
        {
            InitializeComponent();
            right = Width - 10;
            down = Height - 10;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                    Close();

                if (e.X == left || e.X == right || e.Y == top || e.Y == down)
                {
                    MessageBox.Show("Клик по рамке");
                    return;
                }

                if (e.X > left && e.X < right && e.Y > top && e.Y < down)
                    MessageBox.Show("Клик внутри рамки");
                else
                    MessageBox.Show("Клик за пределами рамки");
            }
            else if (e.Button == MouseButtons.Right)
                Text = $"Ширина = {right - left}, высота = {down - top}";

        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            Text = e.Location.ToString();
        }
    }
}
