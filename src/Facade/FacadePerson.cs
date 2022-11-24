using Facade.Entity;
using Facade.Service;

namespace Facade
{
    public class FacadePerson
    {
        public PersonAccessHistoryService PersonAccessHistoryService { get; set; }
        public PersonAddressService PersonAddressService { get; set; }
        public PersonDocsService PersonDocsService { get; set; }
        public PersonEmailService PersonEmailService { get; set; }
        public PersonPhoneService PersonPhoneService { get; set; }
        public EmailService EmailService { get; set; }

        public FacadePerson()
        {
            PersonAccessHistoryService = new PersonAccessHistoryService();
            PersonAddressService = new PersonAddressService();
            PersonDocsService = new PersonDocsService();
            PersonEmailService = new PersonEmailService();
            PersonPhoneService = new PersonPhoneService();
            EmailService = new EmailService();
        }

        public bool RemovePerson(Person person)
        {
            PersonAccessHistoryService.Remove(person);
            PersonAddressService.Remove(person);
            PersonDocsService.Remove(person);
            PersonEmailService.Remove(person);
            PersonPhoneService.Remove(person);
            EmailService.SendEmail(
                email: "teste@",
                subject: $"Dados de {person.Name} removidos com sucesso."
            );

            return true;
        }
    }
}
