using Facade.Entity;

namespace Facade.Service
{
    public class PersonDocsService
    {
        public void Remove(Person person)
        {
            Console.WriteLine($"Documentos de {person.Name} removidos com sucesso.");
        }
    }
}
