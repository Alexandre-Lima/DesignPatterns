namespace Singleton;
public sealed class PersonService
{
    private static PersonService _instance;

    private PersonService() { }

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

    public string AddPerson(dynamic person)
    {
        return  $"Person {person} adicionado";
    }
}
