using Factory.SimpleFactory.Abstract;

namespace Factory.SimpleFactory
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            Type = "RECTANGLE";
        }

        public override string Draw()
        {
            return $"Inside {Type}::draw() method.";
        }
    }
}
