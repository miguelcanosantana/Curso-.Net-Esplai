//-DOCS
//-Shuffle a List in one line
//https://levelup.gitconnected.com/shuffle-a-list-t-in-c-net-7-with-one-line-8b9e3e44db64


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
        public eCardSuit suit;
        public int number;

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
                            cards.Add(new Card(eCardSuit.Pike, n));
                            break;
                    }
                }
            }
        }


        public void Shuffle()
        {
            Random random = new Random();
            cards = cards.OrderBy(card => random.Next()).ToList();
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


    public class Player
    {
        private int number = 0;
        private List<Card> cards = new List<Card>();


        public Player(int playerNumber, List<Card> initialCards) 
        {
            this.number = playerNumber;
            this.cards = initialCards;
        }

        public void SetCards(List<Card> cards) { this.cards = cards; }
        public List<Card> GetCards() { return this.cards; }
    }


    internal class Program
    {
        public static int playersNumber;
        public static int initialPlayerCards = 6;
        public static Deck centralDeck = new Deck();
        public static List<Player> players = new List<Player>();


        static void Main(string[] args)
        {
            AskPlayers();
            CreateMatch();

            DebugPrintPlayerCards();

            Console.ReadKey();
        }


        private static void AskPlayers()
        {

            bool validNumber = false;

            do
            {
                Console.Write("Enter a number of players: ");
                validNumber = int.TryParse(Console.ReadLine(), out playersNumber);
            } while (!validNumber || playersNumber < 2 || playersNumber > 5);
        }


        //Shuffle, create players and give them their cards
        private static void CreateMatch()
        {
            
            centralDeck.Shuffle();

            for (int i = 0; i < playersNumber; i++)
            {
                Player newPlayer = new Player(i, centralDeck.Steal(initialPlayerCards));
                players.Add(newPlayer);
            }
        }


        private static void DebugPrintPlayerCards()
        {
            foreach (var p in players)
            {
                foreach (var card in p.GetCards())
                {
                    Console.Write(card.number + " " + card.suit + "    ");
                }
                Console.WriteLine("\n \n");
            }
        }
    }
}
