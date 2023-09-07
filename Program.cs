// See https://aka.ms/new-console-template for more information

using aruppgift;

Console.WriteLine("Rektangel eller Triangel");
var Input = Console.ReadLine();

Console.Write("Ange Höjd: ");
var Input3 = Console.ReadLine();
var Input5 = float.Parse(Input3);
Console.Write("Ange Bas: ");
var Input4 = Console.ReadLine();
var Input6 = float.Parse(Input4);
if(Input == "Rektangel")
{
    Rectangle Rectangle1 = new Rectangle(Input5, Input6);

    Console.WriteLine("Omrkets: " + Rectangle1.Omkrets(Input5, Input6));
    Console.WriteLine("Area: " + Rectangle1.Area(Input5, Input6));

}

else if(Input == "Triangel")
{
    Triangle Traingle1 = new Triangle(Input5, Input6);

    Console.WriteLine("Omrkets: " + Traingle1.Omkrets(Input5, Input6));
    Console.WriteLine("Area: " + Traingle1.Area(Input5, Input6));
}

else
{
    Console.WriteLine("Felaktig Indata");
}