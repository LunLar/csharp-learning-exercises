namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameCharacter ch1 = new GameCharacter();
            Zombie z1 = new Zombie();
            Wizard w1 = new Wizard("Tor", "Water", 5);
            Wizard w2 = new Wizard("Lars", "Fire", 10);



            w2.jump(); // in order to call my method jump in Gamecharacter, i have to create an object !

            GameController.printData(w2); // i can use all the functionalities in my class without creating an object
            GameController.fight(w1, w2);

            GameController.gc_list.Add(w1); // i add Wizard 1 to the database
            GameController.gc_list.Add(w2);

            Console.WriteLine(GameController.gc_list.);


        }
    }
}
