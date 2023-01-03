using _00_Exercies_3.Models;

namespace _00_Exercies_3.Services
{
    internal class MenuService
    {
        public int MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till Adressboken");
            Console.WriteLine("1. Skapa en ny kontakt");
            Console.WriteLine("2. Visa alla kontakter");
            Console.WriteLine("3. Visa en specifik kontakt");
            Console.WriteLine("4. Ta bort en specifik kontakt");
            Console.Write("Ange ett av alternativen ovan: ");

            try
            {
                var option = int.Parse(Console.ReadLine() ?? "0");
                return option;
            }
            catch { return 0; }
        }

        public ContactPerson CreateMenu()
        {
            var contact = new ContactPerson();

            Console.Clear();
            Console.WriteLine("Skapa en ny kontakt");
            
            Console.Write("Förnamn: ");
            contact.FirstName = Console.ReadLine() ?? "";
            
            Console.Write("Efternamn: ");
            contact.LastName = Console.ReadLine() ?? "";
            
            Console.Write("E-postadress: ");
            contact.ContactInformation.Email = Console.ReadLine() ?? "";
            
            Console.Write("Telefonnummer: ");
            contact.ContactInformation.PhoneNumber = Console.ReadLine() ?? "";
            
            Console.Write("Gatuadress: ");
            contact.Address.StreetName = Console.ReadLine() ?? "";
            
            Console.Write("Postnummer: ");
            contact.Address.PostalCode = Console.ReadLine() ?? "";
            
            Console.Write("Ort: ");
            contact.Address.City = Console.ReadLine() ?? "";

            return contact;
        }

        public void ListMenu(List<ContactPerson> contacts)
        {
            Console.Clear();
            Console.WriteLine("Kontaktlistan");

            foreach(var contact in contacts)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName} <{contact.ContactInformation.Email}>");
            }

            Console.ReadKey();
        }

        public void DetailsMenu(List<ContactPerson> contacts)
        {
            Console.Clear();
            Console.WriteLine("Detaljerad kontaktinformation");
            Console.Write("Ange e-postadressen på den du vill se information om: ");
            var email = Console.ReadLine();

            var contact = contacts.FirstOrDefault(contact => contact.ContactInformation.Email == email);
            if (contact != null)
            {
                Console.Clear();
                Console.WriteLine("Detaljerad kontaktinformation");
                Console.WriteLine($"Namn: {contact.FirstName} {contact.LastName}");
                Console.WriteLine($"E-postadress: {contact.ContactInformation.Email}");
                Console.WriteLine($"Telefonnummer: {contact.ContactInformation.PhoneNumber}");
                Console.WriteLine($"Adress: {contact.Address.StreetName}, {contact.Address.PostalCode} {contact.Address.City.ToUpper()}");
            } 
            else
            {
                Console.WriteLine("Det finns ingen kontaktperson med den angivna e-postadressen.");
            }

            Console.ReadKey();
        }

        public void DeleteMenu(ref List<ContactPerson> contacts)
        {
            Console.Clear();
            Console.WriteLine("Ta bort en kontakt");
            Console.Write("Ange e-postadressen på den du vill ta bort: ");
            var email = Console.ReadLine();
            contacts = contacts.Where(contact => contact.ContactInformation.Email != email).ToList();
        }
    }
}