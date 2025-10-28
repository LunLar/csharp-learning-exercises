using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class GameCharacter
    {
        public string name {  get; set; } // this is a special version of a getter and a setter witch only works in C#
        public double health { get; set; }

        public double max_health;



        public GameCharacter() // basis constructor
        {
            health = 100;

        }

        public GameCharacter(string _name)
        {
            name = _name;
        }

        public void jump()
        {

        }


       

    }
}
