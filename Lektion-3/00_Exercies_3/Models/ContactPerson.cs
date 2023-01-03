namespace _00_Exercies_3.Models
{
    internal class ContactPerson
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public ContactInformation ContactInformation { get; set; } = new ContactInformation();
        public Address Address { get; set; } = new Address();

    }
}
