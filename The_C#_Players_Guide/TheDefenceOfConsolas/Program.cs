Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();
Console.Title = "Defence of Consolas";


int targetRow;
int targetColumn;

int deployLocation1Row;
int deployLocation1Column;

int deployLocation2Row;
int deployLocation2Column;

int deployLocation3Row;
int deployLocation3Column;

int deployLocation4Row;
int deployLocation4Column;

Console.WriteLine("target row?: ");
targetRow = int.Parse(Console.ReadLine());
Console.WriteLine("targetColumn?: ");
targetColumn = int.Parse(Console.ReadLine());

deployLocation1Row = targetRow;
deployLocation1Column = targetColumn - 1;

deployLocation2Row = targetRow - 1;
deployLocation2Column = targetColumn;

deployLocation3Row = targetRow;
deployLocation3Column = targetColumn + 1;

deployLocation4Row = targetRow + 1;
deployLocation4Column = targetColumn;

Console.Beep();

Console.WriteLine("Deploy to: \n");
Console.WriteLine($"{(deployLocation1Row, deployLocation1Column)}");
Console.WriteLine($"{(deployLocation2Row, deployLocation2Column)}");
Console.WriteLine($"{(deployLocation3Row, deployLocation3Column)}");
Console.WriteLine($"{(deployLocation4Row, deployLocation4Column)}");
