using System;
using Test_CSharp_Forms.Interfaces;

namespace Test_CSharp_Forms.Figures
{
    public class Round : IFigure
    {
        protected double Radius;

        public Round(double radius)
        {
            Radius = radius;
        }

        public virtual double Area()
        {
            return Math.PI*Radius*Radius;
        }
    }
}