namespace Test_CSharp_Forms.Figures
{
    public class Rectangle : Polygon
    {
        protected double SideA;
        protected double SideB;

        public Rectangle(Point2D[] tops) : base(tops)
        {
            SideA = 0.0;
            SideB = 0.0;
        }
        
        public Rectangle(double sideA, double sideB) : base(null)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override double Area()
        {
            if (Tops != null)
                return base.Area();
            return SideA * SideB;
        }
    }
}