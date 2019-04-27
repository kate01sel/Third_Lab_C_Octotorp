using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1M
{
    class Complex
    {
        private int pr;
        private double valid;
        private double imaginary;

        public Complex()
        {

        }

        public Complex(double valid, double imaginary)
        {
            Valid = valid;
            Imaginary = imaginary;
        }

        public Complex(int pr, double valid, double imaginary)
        {
            this.pr = pr;
            this.valid = valid;
            this.imaginary = imaginary;

            if (pr == 0)
            {
                this.valid = GetModule() * Math.Cos(GetAngle());
                this.imaginary = GetModule() * Math.Sin(GetAngle());
            }
        }
        
        public double GetAngle()
        {
            return imaginary / valid;
        }

        public double GetModule()
        {
            return Math.Sqrt(Math.Pow(valid, 2) + Math.Pow(imaginary, 2));
        }

        public Complex Elevate(int n)
        {
            return new Complex(GetModule() * Math.Cos(n * GetAngle()), GetModule() * Math.Sin(n * GetAngle()));
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex( a.valid + b.valid, a.imaginary + b.imaginary);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.valid - b.valid, a.imaginary - b.imaginary);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.valid * b.valid - a.imaginary * b.imaginary, a.valid * b.imaginary + a.imaginary * b.valid);
        }

        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex((a.valid * b.valid + a.imaginary * b.imaginary) / (Math.Pow(b.valid, 2)
                + Math.Pow(b.imaginary, 2)), (b.valid * a.imaginary - a.valid * b.imaginary) /
                (Math.Pow(b.valid, 2) + Math.Pow(b.imaginary, 2)));
        }

        override public string ToString()
        {
            if (pr == 0)
            {
                if (GetAngle() < 0)
                    return "\n" + GetModule() + " * " + "Cos(" + Math.Abs(GetAngle()) + ")" + " - Sin(" + Math.Abs(GetAngle()) + ")" + "i";
                else
                    return "\n" + GetModule() + " * " + "Cos(" + GetAngle() + ")" + " + Sin(" + GetAngle() + ")" + "i";
            }

            if (pr == 1)
            {
                if (this.imaginary > 0)
                    return "\n" + this.valid + " + " + this.imaginary + "i";
                else
                    return "\n" + this.valid + " - " + Math.Abs(this.imaginary) + "i";
            }

            else
                if (this.imaginary > 0)
                    return "\n Error!Pr can only take a value of 0 and 1!\n" + this.valid + " + " + this.imaginary + "i";
                else
                    return "\nError!Pr can only take a value of 0 and 1!\n" + this.valid + " - " + Math.Abs(this.imaginary) + "i";
           
        }

        public int Pr { get => pr; set => pr = value; }
        public double Valid { get => valid; set => valid = value; }
        public double Imaginary { get => imaginary; set => imaginary = value; }
    }
}
