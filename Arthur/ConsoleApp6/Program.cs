namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tmp;


            Console.WriteLine("Hello, World!");
            Gamecharacter g1 = new Gamecharacter();
            Console.WriteLine("Give me the name of the game character: ");

            tmp = Console.ReadLine();
            g1.set_name(tmp);

            Console.WriteLine(g1.print_attack);

            Console.WriteLine(g1.get_name()); // Husk perantes etter funksjoner!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


            Gamecharacter g2 = new Gamecharacter("Hansi", 1000,"30");

            // Console.WriteLine(g2.id); Not possible !! id is private
            // want to set and get the id....

            Console.WriteLine(g2.get_id()); // This is possible with the get_id function even though it is private

            Wizard w1 = new Wizard("Gandalf", "Horse Riding");
            
            w1.print_data();

            // i want my GC to fight against each other....
            // i do not need to create gamecontroller object

            GameController.fight(g1, w1);
        }

    }
}
