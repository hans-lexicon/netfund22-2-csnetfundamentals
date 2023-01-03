/*   
    INTERFACES
    -------------------------------------------------------------------------------
    Det är ett kontrakt som talar om vad som måste implementeras och på vilket sätt.
    Men den innehåller ingen kod.

    Detta är för att säkerställa att man implementerar allt som ska implementeras och
    att man gör det på rätt sätt enligt det som man har "avtalat fram"
 
    Ett interface brukar börja på bokstaven I
    ICustomer, IUser, IProduct, IProductService...

*/

using _02_Interfaces.Interfaces;
using _02_Interfaces.Models;
using _02_Interfaces.Services;

var customerService = new CustomerService();

Customer customer1 = new Customer();
customer1.Age= 1;


ICustomer customer2 = new Customer();
customer2.Age = 2;




customerService.CreateOne(new Customer { FirstName = "Hans" });