List<string> contacts = new List<string>();

while(true)
{
    Console.Clear();
    Console.WriteLine("Välkommen till Adressboken");
    Console.WriteLine("1. Skapa en kontakt");
    Console.WriteLine("2. Visa alla kontakter");
    Console.WriteLine("3. Visa en specifik kontakt");
    Console.WriteLine("4. Ta bort en specifik kontakt");
    Console.Write("Välj ett av alternativen ovan: ");
    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.Clear();
            Console.Write("Förnamn: ");
            string firstName = Console.ReadLine();

            Console.Write("Efternamn: ");
            string lastName = Console.ReadLine();

            Console.Write("E-postadress: ");
            string email = Console.ReadLine();

            Console.Write("Telefonnummer: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Gatuadress: ");
            string streetName = Console.ReadLine();

            Console.Write("Postnummer: ");
            string postalCode = Console.ReadLine();

            Console.Write("Ort: ");
            string city = Console.ReadLine();

            contacts.Add($"{firstName},{lastName},{email},{phoneNumber},{streetName},{postalCode},{city}");

            break;

        case "2":
            Console.Clear();
            foreach(string contact in contacts)
            {
                var values = contact.Split(',');
                Console.WriteLine($"{values[0]} {values[1]} ({values[2]})");

            }

            Console.ReadKey();

            break;

        case "3":
            Console.Clear();
            Console.Write("Ange kontaktpersonens indexvärde: ");
            var index = int.Parse(Console.ReadLine());

            var selected_contact = contacts[index];
            var selected_contact_values = selected_contact.Split(',');

            Console.Clear();
            Console.WriteLine($"Förnamn: {selected_contact_values[0]}");
            Console.WriteLine($"Efternamn: {selected_contact_values[1]}");
            Console.WriteLine($"E-postadress: {selected_contact_values[2]}");
            Console.WriteLine($"Telefonnummer: {selected_contact_values[3]}");
            Console.WriteLine($"Adress: {selected_contact_values[4]}, {selected_contact_values[5]} {selected_contact_values[6]}");
            Console.ReadKey();
            break;

        case "4":
            Console.Clear();
            Console.Write("Ange kontaktpersonens indexvärde: ");
            var index_to_delete = int.Parse(Console.ReadLine());

            Console.Write("Vill du verkligen ta bort denna kontakt? (y/n) ");
            var answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                contacts.RemoveAt(index_to_delete);
                Console.WriteLine("Kontaktpersonen har nu tagits bort.");
                Console.ReadKey();
            }

            break;

        default:
            break;
    }
}