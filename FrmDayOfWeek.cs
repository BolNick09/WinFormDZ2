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
    public partial class FrmDayOfWeek : Form
    {
        public FrmDayOfWeek()
        {
            InitializeComponent();
        }

        private void btnGetDay_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpGuessDay.Value;
            string dayOfWeek = selectedDate.DayOfWeek.ToString();
            MessageBox.Show($"Selected day of the week: {dayOfWeek}");
        }
    }
}
