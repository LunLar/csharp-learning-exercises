
string name = "Lars Henrik";
string customerName;

Console.WriteLine("The following items are available:\n" +
    "1 - Rope\n" +
    "2 - Torches\n" +
    "3 - Climbing equipment\n" +
    "4 - Clean water\n" +
    "5 - Machete\n" +
    "6 - Canoe\n" +
    "7 - Food supplies\n" +
    "What do you want to see the price of?");

int choice = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your name");
customerName = Console.ReadLine() ?? "";

int response = choice switch
{
    1 => 10,
    2 => 16,
    3 => 24,
    4 => 2,
    5 => 20,
    6 => 200,
    7 => 2,
    _ => -1
};


if (response == -1)
    Console.WriteLine("Invalid choice!");
else if (customerName == name)
    Console.WriteLine($"Price customer {customerName}: {response / 2} Gold (50% off)");
else
    Console.WriteLine($"Price customer {customerName}: {response} Gold (No discount)");