using Facade.Entity;

namespace Facade.Service
{
    public class PersonAccessHistoryService
    {
        public void Remove(Person person)
        {
            Console.WriteLine($"Históricos de acesso de {person.Name} removidos com sucesso.");
        }
    }
}
