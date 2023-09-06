// See https://aka.ms/new-console-template for more information

using aruppgift;

Console.WriteLine("Rektangel eller Triangel");
var Input = Console.ReadLine();

if(Input == "Rektangel")
{

    Console.WriteLine("Ange Höjd");
    var Input3 = Console.ReadLine();
    Console.WriteLine("Ange Bas");
    var Input4 = Console.ReadLine();
    Rectangle Rectangle1 = new Rectangle(float.Parse(Input3), float.Parse(Input4));

    Console.WriteLine("Omrkets: " + Rectangle1.omkrets);
}

else if(Input == "Triangel")
{

}

else
{
    Console.WriteLine("Felaktig Indata");
}

Triangle T = new Triangle (10f, 10f);



Console.WriteLine("Area: " + T.area);
Console.WriteLine("Omrekts: " + T.omkrets);
