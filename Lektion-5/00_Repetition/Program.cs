/*
    Access Modifiers
    -----------------------------------------------------------------------------------------
    public          accessbart inom hela solution
    internal        accessbart inom projektet
    private         accessbart inom klassen
 
    använd public överallt om du är osäker annars kan det bli konflikter med access levels

    public används på Properties och Methods och Classes själv
    private används på fields i en klass




    Getter Setter 
    ----------------------------------------------------------------------------------------
    används på Properties för att styra läs och skrivrättigheter på en Property
    skriv i regel bara { get; set; } du behöver inte göra några andra specialsaker

    public string FirstName { get; set; }



    Interfaces
    ----------------------------------------------------------------------------------------
    Är ett "kontrakt" som talar om vad som måste implementeras och hur det ska implementeras
    Gör det möjligt att sätta olika "taggar" på våra klasser. Om du är säker på interfaces,
    använd det inte.

    Ett interface börjar oftast med I i början av namnet: IPerson, IContact, IProduct, IDeviceManager

    public interface IDeviceManager 
    {
        void Create(string deviceId);
        Device Get(string deviceId);
    }

    public class DeviceManager : IDeviceManager 
    {
        public void Create(string deviceId) 
        {
            Här skriver vi själva koden för att skapa en device.
        }

        public Device Get(string deviceId) 
        {
            Här skriver vi själva koden för att hämta en device.
            return device;
        }
    }
*/