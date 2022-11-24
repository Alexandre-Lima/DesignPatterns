namespace Singleton;
public sealed class PersonService
{
    private static PersonService _instance;

    private List<string> _persons;

    private PersonService()
    {
        _persons = new List<string>();
    }

    public static PersonService GetInstance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new PersonService();
            }

            return _instance;
        }
    }

    public void AddPerson(dynamic person)
    {
        _persons.Add(person);
    }

    public IEnumerable<string> GetPersons()
    {
        return _persons;
    }
}
