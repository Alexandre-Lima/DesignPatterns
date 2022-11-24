using Facade.Entity;

namespace Facade.Service
{
    public class PersonEmailService
    {
        public void Remove(Person person)
        {
            Console.WriteLine($"E-mails de {person.Name} removidos com sucesso.");
        }
    }
}
