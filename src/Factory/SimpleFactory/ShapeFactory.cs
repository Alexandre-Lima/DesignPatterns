using Factory.SimpleFactory.Abstract;

namespace Factory.SimpleFactory
{
    public  sealed class ShapeFactory
    {
        private ShapeFactory() { }

        //use CreateShape method to get object of type shape 
        public static Shape CreateShape(string shapeType)
        {
            switch (shapeType)
            {
                case "CIRCLE":
                    return new Circle();

                case "RECTANGLE":
                    return new Rectangle();

                case "SQUARE":
                    return new Square();

                default:
                    throw new NotImplementedException($"Shape type '{shapeType}' Not mapped");
            }
        }
    }
}
