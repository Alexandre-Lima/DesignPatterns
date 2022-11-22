namespace Factory.SimpleFactory.Abstract
{
    public abstract class Shape
    {
        public string Type { get; set; }

        public abstract string Draw();
    }
}
