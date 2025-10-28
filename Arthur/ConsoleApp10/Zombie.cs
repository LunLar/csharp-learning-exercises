using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Zombie : GameCharacter
   
    {

        public string curse;

        
        public Zombie()
        {

        }

        public Zombie(string _name, string _curse) : base(_name)
        { 
            curse = _curse;
        }

    }
}
