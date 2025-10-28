using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Wizard : GameCharacter
    {

        public string special_ability;
        public string spell;
        public int attack;


        public Wizard()
        {

        }

        public Wizard(string _name, string _special_ability, int _attack) : base(_name)
        {
            special_ability = _special_ability;
            attack = _attack;
        }

    }
}
