/*  
    static          en instans av detta skapas direkt när programmet körs. Det innebär att det tar upp utrymme i ram-minnet
                    fördelar med det är att det redan finns och behövs inte skapas, dvs det blir snabbare
                    nackdelar med det är att den tar plats redan från början trots att den inte används till något än


    Main        100MB
 
*/
using _01_Classes.Models;
using _01_Classes.Services;


var menu = new MenuService();
var contacts = new List<Contact>();

while(true)
{
    var option = menu.MainMenu();

    switch (option)
    {
        case "1":
            contacts.Add(menu.CreateContactMenu());
            break;

        case "2":
            menu.ListContactsMenu(contacts);
            break;

        case "3":
            menu.ContactDetailsMenu(contacts);
            break;

        case "4":
            menu.DeleteContactMenu(contacts);
            break;
    }
}