using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardsBattleGame
{

    public enum eCardSuit
    {
        None,
        Heart,   //♥️
        Diamond, //♦️
        Clover,  //♣️
        Pike,    //♠️
    }


    public class Card
    {
        private eCardSuit suit;
        private int number;

        public Card(eCardSuit suit, int number) 
        {
            this.suit = suit;
            this.number = number;
        }
    }


    public class Deck
    {
        private List<Card> cards = new List<Card> ();


        public Deck() 
        {
            GenerateDeck();
        }


        private void GenerateDeck()
        {
            for (int suit = 0; suit < 4; suit++)
            {
                for (int n = 0; n < 13; n++)
                {
                    Card newCard;

                    switch (suit)
                    {
                        case 0:
                            cards.Add(new Card(eCardSuit.Heart, n));
                            break;

                        case 1:
                            cards.Add(new Card(eCardSuit.Diamond, n));
                            break;

                        case 2:
                            cards.Add(new Card(eCardSuit.Clover, n));
                            break;

                        case 3:
                            cards.Add(new Card(eCardSuit.Diamond, n));
                            break;
                    }
                }
            }
        }


        public void Shuffle()
        {

        }

        public List<Card> Steal(int number)
        {
            List<Card> listToSteal = new List<Card>();

            for (int i = 0; i < number; i++)
            {
                listToSteal.Add(cards[0]);
                cards.RemoveAt(0);
            }

            return listToSteal;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
