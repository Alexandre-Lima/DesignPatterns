using Facade;
using Facade.Entity;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.UnitTests.Facade
{
    public class FacadePersonTest
    {
        [Fact]
        public void Execute_Remove_Person_Request()
        {
            // Arrange
            var facadePerson = new FacadePerson();

            var person = new Person
            {
                Name = "Test"
            };

            //Act
            var excute = facadePerson.RemovePerson(person);

            //Assert
            excute.Should().Be(false);
        }
    }
}
