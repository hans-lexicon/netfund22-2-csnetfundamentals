namespace _03_Interfaces_Demo.Interfaces
{
    internal interface IComputer : IProduct
    {
        string CPU { get; set; }
        string Model { get; set; }
        int RAM { get; set; }
        string Vendor { get; set; }
    }
}
