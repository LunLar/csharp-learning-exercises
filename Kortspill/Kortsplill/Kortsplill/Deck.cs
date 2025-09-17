using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Kortsplill
{
    internal class Deck
    {
        int i;
        int j;

        public string[] suits = new string[4] { "diamonds", "clubs", "hearts", "spades" };
        public Card[] deck = new Card[52];


        public Deck()
        {
            for (i = 0; i < suits.Length; i++)
            {
                for (j = 0; j < 13; j++)
                {
                    Card card = new Card(j+1, suits[i]);
                    deck[(i * 13) + j] = card;
                }

            }

        }
    }
}
