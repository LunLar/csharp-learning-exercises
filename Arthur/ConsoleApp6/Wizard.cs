using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Wizard:Gamecharacter
    {
        public string name;
        public string special_ability;


        public Wizard()
        {


        }

        
        public Wizard(string _name, string _special_ability)
        {
            this.name = _name;
            this.special_ability = _special_ability;
            // base operator ( super(). )
            
        }

        // virtual method print data
        public override void print_data()
        {
            // i can change the content of this method
            Console.WriteLine("your name is: " + name);

        }

        public override void print_attack()
        {
            Console.WriteLine(special_ability);
        }



    }
}
