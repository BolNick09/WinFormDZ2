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
    public partial class FrmTask2 : Form
    {
        Point firstPoint;
        Point lastPoint;
        List<GroupBox> boxes;
        public FrmTask2()
        {
            InitializeComponent();
            boxes = new List<GroupBox>();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            Size size = new Size(Math.Abs(lastPoint.X - firstPoint.X), Math.Abs(lastPoint.Y - firstPoint.Y));
            if (size.Width < 10 || size.Height < 10)
            {
                MessageBox.Show("Размер должен быть больше 10");
                return;
            }
            Point startPoint = new(Math.Min(firstPoint.X, lastPoint.X), Math.Min(firstPoint.Y, lastPoint.Y));
            GroupBox nBox = new GroupBox();
            nBox.Text = $"Группбокс {boxes.Count + 1}";
            nBox.Location = startPoint;

            nBox.Size = size;
            Controls.Add(nBox);

            nBox.BringToFront();
            boxes.Add(nBox);
            nBox.MouseClick += HandleMouseClick;
            nBox.DoubleClick += HandleMouseDoubleClick;
        }



        private void HandleMouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                return;
            GroupBox clickedBox = (GroupBox)sender;
            string message = $"Координаты: {clickedBox.Location} \n Размер: {clickedBox.Size.Width * clickedBox.Size.Height}";
            this.Text = message;

        }
        private void HandleMouseDoubleClick(object? sender, EventArgs e)
        {
            if (sender is GroupBox clickedBox)
            {
                Controls.Remove(clickedBox);
                boxes.Remove(clickedBox);
            }


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
