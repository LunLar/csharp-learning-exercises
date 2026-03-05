// See https://aka.ms/new-console-template for more information
Console.WriteLine("\"");
Console.WriteLine(@"\");
Console.WriteLine("Line 1 \nLine 2");

string name1 = Console.ReadLine();
string name2 = Console.ReadLine();
Console.WriteLine($"#1: {name1,20}");
Console.WriteLine($"#2: {name2,20}");

Console.WriteLine($"{Math.PI:0.000}");

float currentHealth = 4;
float maxHealth = 9;
Console.WriteLine($"{currentHealth / maxHealth:0.0%}");
