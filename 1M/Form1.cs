using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1M
{
    public partial class Form1 : Form
    {
        Complex a;
        Complex b;
        Complex c;
        Complex d;
        Complex X;
        int n;

        public Form1()
        {
            InitializeComponent();
            a = new Complex();
            b = new Complex();
            c = new Complex();
            d = new Complex();
            X = new Complex();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            a.Pr = Convert.ToInt32(txtPr1.Text == "" ? "0" : txtPr1.Text);
            b.Pr = Convert.ToInt32(txtPr2.Text == "" ? "0" : txtPr2.Text);
            c.Pr = Convert.ToInt32(txtPr3.Text == "" ? "0" : txtPr3.Text);
            d.Pr = Convert.ToInt32(txtPr4.Text == "" ? "0" : txtPr4.Text);
            a.Valid = Convert.ToDouble(txt1Real.Text == "" ? "0" : txt1Real.Text);
            b.Valid = Convert.ToDouble(txt2Real.Text == "" ? "0" : txt2Real.Text);
            c.Valid = Convert.ToDouble(txt3Real.Text == "" ? "0" : txt3Real.Text);
            d.Valid = Convert.ToDouble(txt4Real.Text == "" ? "0" : txt4Real.Text);
            a.Imaginary = Convert.ToDouble(txt1Imaginary.Text == "" ? "0" : txt1Imaginary.Text);
            b.Imaginary = Convert.ToDouble(txt2Imaginary.Text == "" ? "0" : txt2Imaginary.Text);
            c.Imaginary = Convert.ToDouble(txt3Imaginary.Text == "" ? "0" : txt3Imaginary.Text);
            d.Imaginary = Convert.ToDouble(txt4Imaginary.Text == "" ? "0" : txt4Imaginary.Text);
            n = Convert.ToInt32(txtDegree.Text == "" ? "0" : txtDegree.Text);

            richTextBox1.Text = a.ToString();
            richTextBox2.Text = b.ToString();
            richTextBox3.Text = c.ToString();
            richTextBox4.Text = d.ToString();

            X = (a + b) * c.Elevate(2) / (b - a);
            richTextBoxResult.Text = X.ToString();
        }
    }
}
