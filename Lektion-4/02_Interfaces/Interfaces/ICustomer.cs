namespace _02_Interfaces.Interfaces
{
    internal interface IPerson : IPersonalInformation, IContactInformation, IBillingInformation
    {

    }


    internal interface ICustomer
    {
        string Id { get; set; }
    }
}