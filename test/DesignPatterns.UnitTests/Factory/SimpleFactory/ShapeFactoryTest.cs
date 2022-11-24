using Factory.SimpleFactory;
using Factory.SimpleFactory.Abstract;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.UnitTests.Factory.SimpleFactory
{
    public class ShapeFactoryTest
    {

        [Fact]
        public void Execute_Create_Shape_Circle_Request()
        {
            // Arrange
            var shapeType = "CIRCLE";
            Shape shape1 = ShapeFactory.CreateShape(shapeType);
            var result = $"Inside {shapeType}::draw() method.";

            //Act
            var excute = shape1.Draw();

            //Assert

            shape1.GetType().Should().Be(typeof(Circle));
            shape1.GetType().Should().NotBe(typeof(Rectangle));
            shape1.GetType().Should().NotBe(typeof(Square));

            excute.Should().BeEquivalentTo(result);
        }

        [Fact]
        public void Execute_Create_Shape_Rectangle_Request()
        {
            // Arrange
            var shapeType = "RECTANGLE";
            Shape shape1 = ShapeFactory.CreateShape(shapeType);
            var result = $"Inside {shapeType}::draw() method.";

            //Act
            var excute = shape1.Draw();

            //Assert
            shape1.GetType().Should().NotBe(typeof(Circle));
            shape1.GetType().Should().Be(typeof(Rectangle));
            shape1.GetType().Should().NotBe(typeof(Square));

            excute.Should().BeEquivalentTo(result);
        }

        [Fact]
        public void Execute_Create_Shape_Square_Request()
        {
            // Arrange
            var shapeType = "SQUARE";
            Shape shape1 = ShapeFactory.CreateShape(shapeType);
            var result = $"Inside {shapeType}::draw() method.";

            //Act
            var excute = shape1.Draw();

            //Assert
            shape1.GetType().Should().NotBe(typeof(Circle));
            shape1.GetType().Should().NotBe(typeof(Rectangle));
            shape1.GetType().Should().Be(typeof(Square));

            excute.Should().BeEquivalentTo(result);
        }
    }
}
