using Facade.Entity;

namespace Facade.Service
{
    public class PersonAddressService
    {
        public void Remove(Person person)
        {
            Console.WriteLine($"Endereços de {person.Name} removidos com sucesso.");
        }
    }
}
