using Singleton;
using Xunit;

namespace DesignPatterns.UnitTests.Singleton
{
    public class PersonServiceTest
    {

        [Fact]
        public async Task Execute_Add_Person_Request()
        {
            // Arrange
            var personService = PersonService.GetInstance;
            var person = "michael jordan";
            var result = $"Person {person} adicionado";

            //Act
            var excute = personService.AddPerson(person);

            //Assert
            excute.Equals(result);
        }
    }
}
