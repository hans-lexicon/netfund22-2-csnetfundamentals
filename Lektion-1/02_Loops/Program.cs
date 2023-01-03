/*  
    LOOPAR
    ------------------------------------------------------------------------------------------------------------------
    for             loopar ett givet antal gånger                                   for (int i = 0; i < 10; i++) { }
    foreach         loopar genom alla objekt i en lista/array                       foreach (var item in items) { }
    while           loopar endast om ett tillstånd är sant                          while (value == true) { }
    do while        kör minst en gång och sen loopa om tillståndet är sant          do { } while (value == true);
 
    OBS!!!!!
    Var försiktig med while så du inte gör en evighetsloop.
*/


string[] items = { "Hans", "Tommy", "Joakim", "Hanna", "Josefine", "Haithem", "Bilaal", "Oskar", "Stina", "Amanda", "Ali", "Mohammed" };

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(items[i]);
}

Console.WriteLine();

foreach (var item in items)
{
    Console.WriteLine(item);
}

Console.WriteLine();

int counter1 = 10;
while (counter1 < 10)
{
    Console.WriteLine("counter 1");
    counter1++;
}

Console.WriteLine();

int counter2 = 10;
do
{
    Console.WriteLine("counter 2");
    counter2++;
} while (counter2 < 10);







// for (initialize; condition; increment)
string password = "Bytmig123!";
string comparePassword = "BytMig123!";

for (int i = 0; i < password.Length; i++)
{
    if (password[i] != comparePassword[i])
    {
        Console.WriteLine("Lösenordet matchar inte");
        break;
    }
}



Console.ReadKey();