//welcome statement

Console.WriteLine("Welcome to the room calculator");

//asks for legth and stores it

Console.WriteLine("Please enter the length of the room");
double length = double.Parse(Console.ReadLine());

//asks for width and stores it

Console.WriteLine("Please enter the width of the room");
double width = double.Parse(Console.ReadLine());

//asks for the height and stores it

Console.WriteLine("Please enter the height of the room");
double height = double.Parse(Console.ReadLine()); 

//calculates perimeter

double perimeter = 2 * (length + width);
Console.WriteLine("Perimeter = " + perimeter);

//calculates area

double area = (length * width);
Console.WriteLine("Area = " + area);

//calculates the volume

double volume = (length * width * height);
Console.WriteLine("Volume = " + volume);

//calculates the surface area

double surfaceArea = 2 * ((length * width) + (width * height) + (length * height));
Console.WriteLine("surface area = " + surfaceArea);
//determines the room size by area

if (area <= 250 && area > 0)
{
    Console.WriteLine("the room is small");
}

if (area < 650 && area >250)
{
    Console.WriteLine("the room is medium");
}
if (area >= 650)
{
    Console.WriteLine("the room is large");

}

//ending statement

Console.WriteLine("Thank you for using the room calculator.");
