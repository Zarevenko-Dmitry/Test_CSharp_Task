namespace Test_CSharp_Forms.Figures
{
    public class Square : Rectangle
    {
        public Square(Point2D[] tops) : base(tops)
        {
        }
        
        public Square(double side) : base(side, side)
        {
        }
    }
}