/*   
 
    Array - statisk kan inte ändras (dvs vi kan inte göra add, remove, sort, orderby, filtrera) 
 
    List - dynamisk lista som kan ändras (dvs vi kan göra add, remove, sort, orderby, filter)
    
    IEnumerable - lista som kan ändras till en viss del (vi kan inte göra add, remove men vi kan göra sort, orderby etc.)
                  används väldigt mycket när vi använder oss av databaser och andra lagringsytor

    lambda-expression aka. arrow-function
    () => {}

    contacts.Where(contact => contact.FirstName == firstName)


    foreach(var contact in contacts)
        contact.FirstName



*/

using _01_Lists;

ContactPerson contactPerson = new ContactPerson(); 
List<ContactPerson> contacts = new List<ContactPerson>();

// Skapa en lista med kontakter som har efternamnet Mattin-Lassei
//string lastName = "Mattin-Lassei";
//var result = contacts.Where(contact => contact.LastName == lastName);


// Skapa en lista med kontakter som inte har efternamnet Mattin-Lassei
//string lastName = "Mattin-Lassei";
//var result = contacts.Where(contact => contact.LastName != lastName);


// Hämta ut EN användare från en lista där användarens e-postadress är lika med hans@domain.com
//string email = "hans@domain.com";
//var result = contacts.FirstOrDefault(contact => contact.Email == email);


// Finns det några kontaktpersoner i listan, om ja då vill jag få true som svar annars false
//var result = contacts.Any();

// Kontrollera om det finns en kontaktperson med epostadressen hans@domain.com
//string email = "hans@domain.com";
//var result = contacts.Any(contact => contact.Email == email);
//if (contacts.Any(contact => contact.Email == email)) { }

contacts.OrderBy(contact => contact.LastName == "Mattin-Lassei");