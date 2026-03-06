 

using System.ComponentModel.Design;

string tick = "Tick";
string tock = "Tock";

int userInput;

Console.WriteLine("Give me a number: ");
userInput = Convert.ToInt32(Console.ReadLine());

if (userInput % 2 == 0)
{
    Console.WriteLine(tick);
}

else
{
    Console.WriteLine(tock);
}
