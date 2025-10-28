using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public static class GameController
    {
        public static List<GameCharacter> gc_list = new List<GameCharacter>();
        // this is like a database for gamecharacters.....


        public static void fight(GameCharacter g1, GameCharacter g2)
        {
            // Fight logic..
            Console.WriteLine(g1.name + " attacked" + g2.name);
            Console.WriteLine(g2.name + " Died");


        }


        public static void printData(GameCharacter g)
        {
            Console.WriteLine(g.name);
        }



    }
}
