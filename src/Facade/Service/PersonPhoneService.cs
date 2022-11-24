using Facade.Entity;

namespace Facade.Service
{
    public class PersonPhoneService
    {
        public void Remove(Person person)
        {
            Console.WriteLine($"Telefones de {person.Name} removidos com sucesso.");
        }
    }
}
