using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphysm
{
    public class Shap
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Side { get; set; }
        public double Diameter { get; set; }
        public double P =Math.PI;
        public Shap(int w, int L)
        {
            Length = L;
            Width = w;
        }
        public Shap(int s)
        {
            Side = s;
        }
        public Shap(double c)
        {
            Diameter = c;
        }
        //محاسبه مساحت مستطیل و مربع
        public virtual double Area()
        {
            return 0;
        }
        public virtual double Environment()
        {
            return 0;
        }
    }
    public class Rectangle:Shap
    {
        public Rectangle(int w,int l): base(w, l)
        {
        }
        public override double Area()
        {
            return Width * Length;
        }
        public override double Environment()
        {
            return (Width + Length) * 2;
        }
    }
    public class Squar : Shap
    {
        public Squar(int s) : base(s)
        {
        }
        public override double Area()
        {
            return Side * Side;
        }
        public override double Environment()
        {
            return Side * 4;
        }
    }
    public class Circle : Shap
    {
        public Circle(double c) : base(c)
        {
        }
        public override double Area()
        {
            return Diameter * P;
        }
        public override double Environment()
        {
            return (Diameter / 2)*2*P;
        }
    }
}
