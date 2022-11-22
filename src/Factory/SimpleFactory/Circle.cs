using Factory.SimpleFactory.Abstract;

namespace Factory.SimpleFactory
{
    public class Circle : Shape
    {
        public Circle()
        {
            Type = "CIRCLE";
        }

        public override string Draw()
        {
            return $"Inside {Type}::draw() method.";
        }
    }
}
