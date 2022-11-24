using FluentAssertions;
using Singleton;
using Xunit;

namespace DesignPatterns.UnitTests.Singleton
{
    public class PersonServiceTest
    {

        [Fact]
        public void Execute_Add_Person_Request()
        {
            // Arrange
            var personService1 = PersonService.GetInstance;
            var personService2 = PersonService.GetInstance;

            var person1 = "michael jordan";
            var person2 = "michael phelps";

            //Act
            personService1.AddPerson(person1);
            personService2.AddPerson(person2);

            //Assert
            personService1.GetPersons().Should().BeEquivalentTo(personService2.GetPersons());

        }
    }
}
