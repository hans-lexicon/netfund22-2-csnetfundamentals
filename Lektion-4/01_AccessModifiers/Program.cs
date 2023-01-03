/*  
    ACCESS MODIFIERS
    -------------------------------------------------------------------------------------------
    public          tillgänglig överallt (i andra metoder i projektet, i andra metoder i andra projekt)
    internal        tillgänglig endast i projektet (i andra metoder i projektet)
    private         endast tillgänglig inom den egna klassen (bara i metoder i sin egna klass)

    protected

 
*/


using _01_AccessModifiers.DifferentProject.Models;

var customer = new Customer();
customer.Public = "Hans";
customer.Internal = "Mattin-Lassei";
customer.Private = "hans@domain.com";