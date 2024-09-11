// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (f,m)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Pleas, select your gender (m/f):");

char userGender = char.Parse(Console.ReadLine());  //loeb konsoolist maha sõne formaadis
Console.WriteLine("Pleas, enter your last name:");

string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}

else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}

else 
{
    Console.WriteLine($"welcome, {userLastName}!");
}

