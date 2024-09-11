// See https://aka.ms/new-console-template for more information


//rakendus küsib kasutajal sisestada tema vanus.
//kuikasutaja vanus on väiksem kui13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to instagram"

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine());

if (userAge >= 13)
{
    Console.WriteLine("Welcome to instagram!");
}

else
{
    Console.WriteLine("You are too young to use Instagram");
}