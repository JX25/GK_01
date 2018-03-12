using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK_01
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Black, 3);

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            PointF P1 = new PointF();
            PointF P2 = new PointF();

            //  g.DrawLine(pen1, 0, 0, 50, 300);
            P1.X = (float)Double.Parse(textBox1.Text);
            P1.Y = (float)Double.Parse(textBox2.Text);
            P2.X = (float)Double.Parse(textBox3.Text);
            P2.Y = (float)Double.Parse(textBox4.Text);
            g.DrawLine(pen1, P1.X, P1.Y, P2.X, P2.Y);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // prostokat
        {
            pictureBox1.Refresh();
            PointF P1 = new PointF();
            PointF P2 = new PointF();

            //  g.DrawLine(pen1, 0, 0, 50, 300);
            P1.X = (float)Double.Parse(textBox1.Text);
            P1.Y = (float)Double.Parse(textBox2.Text);
            P2.X = (float)Double.Parse(textBox3.Text);
            P2.Y = (float)Double.Parse(textBox4.Text);

            g.DrawRectangle(pen1, P1.X, P1.Y, P2.X, P2.Y);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            PointF P1 = new PointF();
            PointF P2 = new PointF();

            //  g.DrawLine(pen1, 0, 0, 50, 300);
            PointF Pstart = new PointF(0, 0);
            PointF Pend = new PointF(300, 300);
            P1.X = (float)Double.Parse(textBox1.Text);
            P1.Y = (float)Double.Parse(textBox2.Text);
            P2.X = (float)Double.Parse(textBox3.Text);
            P2.Y = (float)Double.Parse(textBox4.Text);

            g.DrawBezier(pen1, Pstart, P1, P2, Pend);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            Point point1 = new Point(50, 50);
            Point point2 = new Point();
            Point point3 = new Point();
            point2.X = (int)Double.Parse(textBox1.Text);
            point2.Y = (int)Double.Parse(textBox2.Text);
            point3.X = (int)Double.Parse(textBox3.Text);
            point3.Y = (int)Double.Parse(textBox4.Text);
            Point point4 = new Point(250, 50);

            Point[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4
             };


            g.DrawPolygon(pen1, curvePoints);
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            int x = (int)Double.Parse(textBox1.Text);
            int y = (int)Double.Parse(textBox2.Text);
            int width = (int)Double.Parse(textBox3.Text);
            int height = (int)Double.Parse(textBox4.Text);
            g.DrawArc(pen1, x, y, width, height, 36, 220);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            int x = (int)Double.Parse(textBox1.Text);
            int y = (int)Double.Parse(textBox2.Text);
            int width = (int)Double.Parse(textBox3.Text);
            int height = (int)Double.Parse(textBox4.Text);
            g.DrawEllipse(pen1, x, y, width, height);
        }
    }

}
