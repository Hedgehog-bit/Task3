using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Ax, Ay, Bx, By, Cx, Cy;
            Ax = Convert.ToInt32(this.textBox1.Text);
            Ay = Convert.ToInt32(this.textBox2.Text);
            Bx = Convert.ToInt32(this.textBox3.Text);
            By = Convert.ToInt32(this.textBox4.Text);
            Cx = Convert.ToInt32(this.textBox5.Text);
            Cy = Convert.ToInt32(this.textBox6.Text);

            double a = Dlina(Ax, Ay, Bx, By);
            double b = Dlina(Ax, Ay, Cx, Cy);
            double c = Dlina(Cx, Cy, Bx, By);
            double min1 = Min(a, b);
            double min2 = Min(c, b);
            this.textBox7.Text = min1.ToString();
            this.textBox8.Text = min2.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double a2 = double.Parse(this.textBox9.Text);
            double b2 = double.Parse(this.textBox10.Text);
            double c2 = double.Parse(this.textBox11.Text);
            double h = double.Parse(this.textBox13.Text);
            for (double i = a2; i <= b2; i += h)
                this.textBox12.Text += F(i, a2, b2, c2).ToString()+"   ";
            
        
        }
        static double F(double x, double a, double b, double c)
        {
            double y;
            if (x < 93) y = a + b * x;
            else if (x > 120) y = a * b * x;
            else y = b - a * c;
            return y;
        }
        static void F(double x, double a, double b, double c, out double y)
        {
            y = 0.0;
            if (x < 93) y = a + b * x;
            else if (x > 120) y = a * b * x;
            else y = b - a * c;
            
        }
        static double Dlina(double x1, double y1, double x2, double y2)
        {
            double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return d;
        }
        static double Min(double a, double b)
        {
            double min = a;
            if (a > b)
                min = b;
            return min;
        }

        
    }
}
