using _00_GettersAndSetters.Models;

var customer = new Customer();

Console.Write("Förnamn: ");
customer.FirstName = Console.ReadLine() ?? "";

Console.Write("Efternamn: ");
customer.LastName = Console.ReadLine() ?? "";

Console.Write("E-postadress: ");
customer.Email = Console.ReadLine() ?? "";


Console.WriteLine($"{customer.FirstName} {customer.LastName}");
Console.WriteLine(customer.Email);
Console.ReadKey();

