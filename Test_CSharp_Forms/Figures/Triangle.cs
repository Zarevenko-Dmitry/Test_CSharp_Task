using System;
using Test_CSharp_Forms.Interfaces;

namespace Test_CSharp_Forms.Figures
{
    public class Triangle : Polygon, IRectangular
    {
        protected double Accuracy = 0.0001;

        protected double SideA;
        protected double SideB;
        protected double SideC;

        public Triangle(Point2D[] tops) : base(tops)
        {
        }
        
        public Triangle(double sideA, double sideB, double sideC) : base(null)
        {
            SideA = Math.Max(Math.Max(sideA, sideB), sideC);
            SideC = Math.Min(Math.Min(sideA, sideB), sideC);
            SideB = sideA + sideB + sideC - SideA - SideC;
        }

        public override double Area()
        {
            if (Tops != null)
                return base.Area();
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public virtual bool Rectangular()
        {
            if (Tops == null)
                return Sqr(SideA) - Sqr(SideB) - Sqr(SideC) < Accuracy;
            else
                return (Area() * 2) - (SideB * SideC) < Accuracy;
        }

        private double Sqr(double digit)
        {
            return digit * digit;
        }
    }
}