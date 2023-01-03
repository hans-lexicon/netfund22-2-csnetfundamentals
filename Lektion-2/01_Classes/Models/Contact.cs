/* 
    camelCase           firstName                   html, js, fields, variabler, parametrar             html,js,c,c++,java
    Pascal              FirstName                   Klasser, Properties, Metoder, Konstruktorer         C#, F#, VB, Pascal, Turbo Pascal
    snake_notation      first_name                  i vissa fall variabler                              Python
*/

namespace _01_Classes.Models
{
    internal class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetName { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}
