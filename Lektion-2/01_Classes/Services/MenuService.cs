using _01_Classes.Models;

namespace _01_Classes.Services
{
    internal class MenuService
    {
        public string MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till Adressboken");
            Console.WriteLine("1. Skapa en kontakt");
            Console.WriteLine("2. Visa alla kontakter");
            Console.WriteLine("3. Visa en specifik kontakt");
            Console.WriteLine("4. Ta bort en specifik kontakt");
            Console.Write("Välj ett av alternativen ovan: ");
            return Console.ReadLine();
        }

        public Contact CreateContactMenu()
        {
            var contact = new Contact();

            Console.Clear();
            Console.Write("Förnamn: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Efternamn: ");
            contact.LastName = Console.ReadLine();

            Console.Write("E-postadress: ");
            contact.Email = Console.ReadLine();

            Console.Write("Telefonnummer: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Gatuadress: ");
            contact.StreetName = Console.ReadLine();

            Console.Write("Postnummer: ");
            contact.PostalCode = Console.ReadLine();

            Console.Write("Ort: ");
            contact.City = Console.ReadLine();

            return contact;
        }

        public void ListContactsMenu(List<Contact> contacts)
        {
            Console.Clear();
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName} ({contact.Email})");
            }

            Console.ReadKey();
        }

        public void ContactDetailsMenu(List<Contact> contacts)
        {
            Console.Clear();
            Console.Write("Ange e-postadressen på den du vill hämta: ");
            var email = Console.ReadLine();
            
            var contact = contacts.FirstOrDefault(contact => contact.Email == email);
            if (contact != null)
            {
                Console.Clear();
                Console.WriteLine($"Förnamn: {contact.FirstName}");
                Console.WriteLine($"Efternamn: {contact.LastName}");
                Console.WriteLine($"E-postadress: {contact.Email}");
                Console.WriteLine($"Telefonnummer: {contact.PhoneNumber}");
                Console.WriteLine($"Adress: {contact.StreetName}, {contact.PostalCode} {contact.City}");            
            }
            else
            {
                Console.WriteLine($"Kunde inte hitta en kontaktperson med epostadressen {email}");
            }

            Console.ReadKey();
        }

        public void DeleteContactMenu(List<Contact> contacts)
        {
            Console.Clear();
            Console.Write("Ange e-postadressen på den du vill ta bort: ");
            var contact = contacts.FirstOrDefault(contact => contact.Email == Console.ReadLine());

            Console.Write($"Vill du verkligen ta bort kontakten {contact.FirstName} {contact.LastName}? (y/n): ");
        
            if (Console.ReadLine().ToLower() == "y")
            {
                contacts.Remove(contact);
                Console.WriteLine("Kontaktpersonen har nu tagits bort.");
                Console.ReadKey();
            }

        }
    }
}
