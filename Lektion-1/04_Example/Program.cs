string firstName;
string lastName;
int age;
List<string> people = new List<string>();

Console.WriteLine("Välkommen!");

while(true)
{
    Console.WriteLine("1. Skapa ny person");
    Console.WriteLine("2. Lista upp alla personer");
    Console.Write("Vad vill du göra: ");
    string option = Console.ReadLine() ?? "";

    switch(option)
    {
        case "1":
            Console.Write("Ange ett förnamn: ");
            firstName = Console.ReadLine() ?? "";

            Console.Write("Ange ett efternamn: ");
            lastName = Console.ReadLine() ?? "";

            Console.Write("Ange ålder: ");
            try { age = int.Parse(Console.ReadLine() ?? ""); }
            catch { age = 0; }

            string contact = $"{firstName} {lastName} - {age}";
            people.Add(contact);
            break;

        case "2":
            foreach (string person in people)
                Console.WriteLine(person);


            break;

        default:

            break;
    }

    Console.ReadKey();
    Console.Clear();
}
