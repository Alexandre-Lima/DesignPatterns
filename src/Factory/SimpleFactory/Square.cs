using Factory.SimpleFactory.Abstract;

namespace Factory.SimpleFactory
{
    public class Square : Shape
    {
        public Square()
        {
            Type = "SQUARE";
        }

        public override string Draw()
        {
            return $"Inside {Type}::draw() method.";
        }
    }
}
