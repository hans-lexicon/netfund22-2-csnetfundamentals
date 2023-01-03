/*  
    
    ()  = för parametrar 
    []  = för index/position i listor, arrayer och objekt
    {}  = kodblock där vi skriver kod mellan



    DEKLARERA VARIABLER
    ---------------------------------------------------
    string          name             =   "Hans";
      |              |                      |
    datatyp      variabelnamn             värde


    string name = "Hans";
    var name = "Hans";

    var är en dynamisk deklaring som blir den datatyp som värdet på högra sidan är

    JS:
    --------------------------
    var     global variabel
    let     lokal variabel
    const   statisk variabel
 */



/* 
 
    DATATYPER

    C#                              JS                                      BESKRIVNING
    -------------------------------------------------------------------------------------------------------------
    string                          String                                  ska vara en text    
    bit,int,uint,long,ulong         Number                                  heltal (1,2,3,4...)
    double,decimal,float            Number                                  decimaltal (1.1, 1.2...)
    dynamic                         (Object)                                kan innehålla vad som helst
    object                          Object                                  är ett objekt
    null                            NULL                                    är ingenting är tomt
    Array                           Array                                   en fixerad lista över något (gäller ej js)
    List                            Array                                   en dynamisk lista över något
    bool                            Boolean                                 ett sant eller falskt värde
    GUID                            UUID                                    Gobalt unikt Id
                                    undefined
    
*/

/* 
    STRING - string, char 
    ------------------------------------------------------------------------------------------------------------
    string name = "Hans";
    var name = "Hans";

    char firstLetter = 'H';
    var firstLetter = 'H';
    
        placeholders:
        --------------------------------------------------------------
        används när vi vill stoppa in olika värden i en textsträng
        string firstName = "Hans";
        string lastName = "Mattin-Lassei";

        var greeting = "Hej Hans Mattin-Lassei.";
        var greeting = "Hej "+ firstName +" "+ lastName +".";
        var greeting = $"Hej {firstName} {lastName}.";

        escapers:
        --------------------------------------------------------------

        \   =   läs nästa tecken som vanlig text
        '   =   byta tecken, som inte avslutar en text
        @   =   ignorerar allt och läser allt som vanligt text när det kommer till \    

        var text = "Hej Tommy är den \"bästa\" personen i världen.";
        var text = "Hej Tommy är den 'bästa' personen i världen.";
        var urn = @"C:\Users\HansMattin-Lassei\Documents\Utbildning\NETFUND22-2";
*/


/*  
        Nummer - int, long, decimal, double, float
        ---------------------------------------------------------------------------------------------------------    
        int     32 bit      -2147483648 to 2147483647
        long    64 bit      -9223372036854775808 to 9223372036854775807
        
        floating pointers:
        ------------------------------
        float   value = 0.0f;       32 bit              MCU, Sensor, IOT....
        double  value = 0.0;        64 bit              Machine Learning, AI, prestanda...
        decimal value = 0.0m;      128 bit              Beräkningar, valutor och finansiella värden..använd det hän

        float float_value = 0.1f + 0.1f + 0.1f;         = 0.3
        double double_value = 0.1 + 0.1 + 0.1;          = 0.3000000000001
        decimal decimal_value = 0.1m + 0.1m + 0.1m;     = 0.3
*/

/*  
    GUID - Globally Unique Identifier / UUID - Universally Unique Identifier
    --------------------------------------------------------------------------------------------------------------
    Guid.NewGuid()  =  54601f42-dc20-42a5-8b18-5d1d7e14960c
 
*/

/*  
    ARRAY - en fixerad lista
    -------------------------------------------------------------------------------------------------------------
    string[] names = new string[5];
    int[] numbers = { 1 , 2, 3, 4, 5, 6 };

    string[] names = new string[5];
    names[0] = "Hans";
    names[1] = "Tommy";
    names[2] = "";
    names[3] = "Haithem";
    names[4] = "Anna";

    foreach(var name in names)
    {
        Console.WriteLine(name);
    }

*/

/*  
    LIST - en dynamisk lista
    -------------------------------------------------------------------------------------------------------------
    List<string> names = new List<string>();
    var names = new List<string>();
    List<string> names = new();


    var names = new List<string>
    {
        "Hans",
        "Tommy",
        "Joakim",
        "Haithem",
        "Anna"
    };

    names.Add("Stefan");
    names.Sort();
    names.Reverse();
    names.Insert(1, "Hanna");
    names.Remove("Tommy");
    names = names.Where(name => name != "Hans").ToList();


    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
*/




Console.ReadKey();