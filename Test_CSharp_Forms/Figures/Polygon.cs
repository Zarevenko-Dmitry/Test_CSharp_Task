using Test_CSharp_Forms.Interfaces;

namespace Test_CSharp_Forms.Figures
{
    public class Polygon : IFigure
    {
        protected Point2D[] Tops;

        public Polygon(Point2D[] tops)
        {
            Tops = tops;
        }

        public virtual double Area()
        {
            if (Tops == null || Tops.Length == 0)
                return 0.0;

            double mult = 0;
            for (int i = Tops.Length - 1; i > 0; i--)
            {
                mult += Tops[i].Y * Tops[i - 1].X;
                mult -= Tops[i].X * Tops[i - 1].Y;
            }
            return mult / 2;
        }
    }
}