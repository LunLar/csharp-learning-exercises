using System.Runtime.ExceptionServices;

namespace Kortsplill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            string input_suit;
            int input_value;
            string input_card;

            Console.WriteLine("Welcome to my card game!");

            Deck deck_1 = new Deck();


            for (i = 0; i < deck_1.deck.Length; i++)
            {
                Console.WriteLine(deck_1.deck[i].card);
            }

            Console.WriteLine("Give me a cardsuit: ");
            input_suit = Console.ReadLine();

            Console.WriteLine("Give me a cardvalue: ");
            input_value = Convert.ToInt32((Console.ReadLine()));

            input_card = input_value + input_suit;

            for (i = 0; i < deck_1.deck.Length; i++)
            {
                if (deck_1.deck[i].card == input_card)
                {
                    Console.WriteLine("your card is at posision: " + i);
                }


            }




        }

    }
}
