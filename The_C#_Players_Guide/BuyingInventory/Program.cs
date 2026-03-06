

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



string response = choice switch
{
    1 => "10 Gold",
    2 => "16 Gold",
    3 => "24 Gold",
    4 => "2 Gold",
    5 => "20 Gold",
    6 => "200 Gold",
    7 => "2 Gold",
    _ => "Invalid choice",
};


Console.WriteLine(response);