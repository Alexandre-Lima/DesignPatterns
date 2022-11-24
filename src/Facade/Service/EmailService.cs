using Facade.Entity;

namespace Facade.Service
{
    public class EmailService
    {
        public void SendEmail(dynamic email, dynamic subject)
        {
            Console.WriteLine($"{email}: {subject}");
        }
    }
}
