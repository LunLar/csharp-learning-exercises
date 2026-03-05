

int pointsPerEstate = 1;
int pointsPerDuchy = 3;
int pointsPerProvince = 6;


int userEstates;
int userDuchy;
int userProvince;

int userTotal;

Console.WriteLine("How many estates do you have?: ");
userEstates = int.Parse(Console.ReadLine());

Console.WriteLine("How many duchy's do you have?: ");
userDuchy = int.Parse(Console.ReadLine());

Console.WriteLine("How many provinces do you have?: ");
userProvince = int.Parse(Console.ReadLine());

userTotal = (userEstates * pointsPerEstate) + (userDuchy * pointsPerDuchy) + (userProvince * pointsPerProvince);

Console.WriteLine(userTotal);