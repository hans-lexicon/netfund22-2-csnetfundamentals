/* 
    IF-satser    -    if (condition) { }
    -----------------------------------------------------------------------------------------------------------------------------
    Används när vi vill jämnföra olika saker med varandra och vi använder då olika operander för att göra detta

    ==          lika med
    !=          inte lika med
    <=          mindre eller lika med
    >=          större eller lika med
    <           mindre än
    >           större än
    &&          och
    ||          eller

    ---------------------------------------------------
 
    if (value == 0) {}
    if (value < 10) {}
    if (value < 100 && value > 50) {}


    if (value == 0) { }
    else { }


    if (value == 0) { }
    else if (value == 5) { }
    else { }

    int value = 5;
    if (value == 0) 
        Console.WriteLine("första if-satsen"); 
    else if (value == 5) 
        Console.WriteLine("else if-satsen"); 
    else 
        Console.WriteLine("else satsen"); 

*/

/*  
    SWITCH
    -------------------------------------------------------------------------------------------------------------------------
    gör samma sak som en if-sats men med enkla jämnförelser såsom ==
    effektiv när vi har många olika alternativ att välja mellan.

    int value = 0;
    switch(value) 
    {
        case 5:
            break;
        case 10:
            break;

        default:
            break;
    }
 
 
*/

int value = 0;
switch (value)
{
    case 5:
        Console.WriteLine("Talet är fem");
        break;

    case 10:
        Console.WriteLine("Talet är tio");
        break;

    default:
        Console.WriteLine("Talet är något annat");
        break;
}



Console.ReadKey();