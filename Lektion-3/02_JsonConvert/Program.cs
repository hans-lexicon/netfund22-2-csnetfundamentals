/*   

    JSON = Javascript Object Notation

    var javascript = {
        firstName: 'Hans',
        lastName: "Mattin-Lassei",
        email: 'hans@domain.com',
        age: 38,
        isActive: true
    }
 
    var csharp = new {
        firstName = "Hans",
        lastName = "Mattin-Lassei",
        email = "hans@domain.com",
        age = 38,
        isActive = true
    };
    
    var json = {
        "firstName": "Hans",
        "lastName": "Mattin-Lassei",
        "email": "hans@domain.com",
        "age": 38,
        "isActive": true
    }


    Att göra ett objekt till ett json-objekt (Serialize)
    ---------------------------------------------------------------------------    
    C#      =        string json = JsonConvert.SerializeObject(csharp);     
    JS      =        string json = JSON.stringify(javascript)
    PY      =        string json = json.dumps(pythonObj)

    Att göra ett json-objekt till ett objekt (Deserialize)
    ----------------------------------------------------------------------------
    C#      =        object csharp = JsonConvert.DeserializeObject<object>(json);     
    JS      =        var javascript = JSON.parse(json)
    PY      =        pythonObj = json.loads(json)
*/


using Newtonsoft.Json;

var csharp = new
{
    firstName = "Hans",
    lastName = "Mattin-Lassei",
    email = "hans@domain.com",
    age = 38,
    isActive = true
};

var json = JsonConvert.SerializeObject(csharp);
Console.WriteLine(json);

var converted_csharp = JsonConvert.DeserializeObject<ContactPerson>(json);
Console.WriteLine(converted_csharp.FirstName);



class ContactPerson
{
    public string FirstName { get; set; }   
    public string LastName { get; set; }
}