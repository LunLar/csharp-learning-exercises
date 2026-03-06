
int x;
int y;


Console.WriteLine("Give me a X value");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Give me a Y value");
y = Convert.ToInt32(Console.ReadLine());

string messageFromTower;

if (y > 0 && x < 0)
    messageFromTower = "North West";

else if (y > 0 && x == 0)
    messageFromTower = "North";

else if (y > 0 && x > 0)
    messageFromTower = "North East";

else if (y == 0 && x < 0)
    messageFromTower = "West";

else if (y == 0 && x == 0)
    messageFromTower = "They are here!";

else if (y == 0 && x > 0)
    messageFromTower = "East";

else if (y < 0 && x < 0)
    messageFromTower = "South West";
else if (y < 0 && x == 0)
    messageFromTower = "South";
else
    messageFromTower = "South East";

Console.WriteLine(messageFromTower);



