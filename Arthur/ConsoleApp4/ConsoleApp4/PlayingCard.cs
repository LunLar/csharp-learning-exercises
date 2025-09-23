using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class PlayingCard
    {
        public int value;
        public string suit;



        public PlayingCard()
        {
            value = 0;
            suit = "Unknown";
        }


        public PlayingCard(int _value, string _suit)
        {
            value = _value;
            suit = _suit;
        }
    }


    

}
