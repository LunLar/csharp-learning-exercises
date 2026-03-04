

float area;
float baseSize;
float hight;

/*
Console.WriteLine("What is the base size of the triangle?: ");
baseSize = float.Parse(Console.ReadLine());

Console.WriteLine("What is the hight of the triangle?: ");
hight = float.Parse(Console.ReadLine());

area = (baseSize * hight) / 2;

Console.WriteLine("The area of the triangle is: " + area);


int a = 5;
int b = 2;
int result = a / b;
Console.WriteLine(result);
*/

int totalEggs;
int numberOfSisters = 4;
float remainder;
int eggsEach;

Console.WriteLine("How many eggs today?: ");
totalEggs = int.Parse(Console.ReadLine());

eggsEach = totalEggs / numberOfSisters;

remainder = totalEggs % numberOfSisters;

Console.WriteLine("The sisters should get: " + eggsEach + " eggs each.");
Console.WriteLine("The duckbear should get: " + remainder + " eggs.");




