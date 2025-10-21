using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Gamecharacter
    {

        private string name;
        public double helathpoints;
        public string attack_impact;
        private string id;



        public Gamecharacter()
        {

        }

        public Gamecharacter(string name, double helathpoints, string attack_impact)
        {

            this.name = name;
            this.helathpoints = helathpoints;
            this.attack_impact = attack_impact;
        }

        public string get_id()
        {

            return id;
        }
        public void set_id(string _id)
        {
            id = _id;
        }


        public string get_name()
        {
            return name;
        }

        public void set_name(string _name)
        {
            name = _name;
        }

        public virtual void print_data()
        {
            Console.WriteLine("your attributes are: "+name+" "+helathpoints);

        }

        public virtual void print_attack()
        {
            Console.WriteLine(attack_impact);
        }

        



    }
}