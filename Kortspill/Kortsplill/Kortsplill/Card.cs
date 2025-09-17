using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Kortsplill
{
    internal class Card
    {
        
        public string card;

        public Card(int value, string suit)
        {
            this.card = ("the " + value + " of " + suit).ToString();
        }

        


    }


}
