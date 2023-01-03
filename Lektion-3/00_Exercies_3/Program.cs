using _00_Exercies_3.Models;
using _00_Exercies_3.Services;
using Newtonsoft.Json;

FileService fileService = new FileService();
MenuService menuService = new MenuService();
List<ContactPerson> contacts = new List<ContactPerson>();
string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\contacts.json";

contacts = JsonConvert.DeserializeObject<List<ContactPerson>>(fileService.Read(filePath)) ?? new List<ContactPerson>();

while (true)
{
    switch (menuService.MainMenu())
    {
        case 1:
            var contact = menuService.CreateMenu();
            contacts.Add(contact);
            fileService.Save(filePath, JsonConvert.SerializeObject(contacts));
            break;

        case 2:
            menuService.ListMenu(contacts);
            break;

        case 3:
            menuService.DetailsMenu(contacts);
            break;

        case 4:
            menuService.DeleteMenu(ref contacts);
            fileService.Save(filePath, JsonConvert.SerializeObject(contacts));
            break;
    }
}

// hitta själva kontakten. FirstOrDefault(x => x.....)
// fileservice jsonconvertdelen.