using _03_Interfaces_Demo.Interfaces;
using _03_Interfaces_Demo.Models.Devices;
using _03_Interfaces_Demo.Models.Products;

List<IDevice> devices = new List<IDevice>();
devices.Add(new TemperatureSensor());
devices.Add(new Fan());


List<IProduct> products = new()
{
    new Tv() { Inches = 55, Vendor = "Samsung" },
    new Mobile(),
    new Laptop() { Vendor = "Dell", Model = "P55", CPU = "Intel i5", RAM = 16 },
    new StationaryComputer()
};


