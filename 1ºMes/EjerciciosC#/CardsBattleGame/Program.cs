//-DOCS
//-Shuffle a List in one line
//https://levelup.gitconnected.com/shuffle-a-list-t-in-c-net-7-with-one-line-8b9e3e44db64

//-Clear the entire console, not just the shown part
//https://stackoverflow.com/questions/75471607/console-clear-doesnt-clean-up-the-whole-console


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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


    public enum eWinCondition
    {
        None,
        Color,
        RoyalStair,
    }


    public enum eColor
    {
        None,
        Red,
        Black
    }


    public class Card
    {
        public eCardSuit suit;
        public int number;
        public eColor color;

        public Card(eCardSuit suit, int number) 
        {
            this.suit = suit;
            this.number = number;

            switch (suit)
            {
                case eCardSuit.Heart:
                case eCardSuit.Diamond:
                    this.color = eColor.Red;
                    break;
                case eCardSuit.Clover:
                case eCardSuit.Pike:
                    this.color = eColor.Black;
                    break;
            }
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
                for (int n = 1; n < 14; n++)
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


    public class SharedDeck
    {
        private List<Card> cards = new List<Card>();


        public SharedDeck(){}

        public void Add(Card card)
        {
            this.cards.Add(card);
        }

        public void Add(List<Card> cards)
        {
            this.cards.AddRange(cards);
        }

        public List<Card> GetCards() { return cards; }
    }


    public class Player
    {
        private int number = 0;
        private int lollipops = 1000;
        private List<Card> cards = new List<Card>();


        public Player(int playerNumber, List<Card> initialCards) 
        {
            this.number = playerNumber;
            this.cards = initialCards;
        }

        public void SetCards(List<Card> cards) { this.cards = cards; }
        public List<Card> GetCards() { return this.cards; }

        public void SetLollipops(int lollipops) { this.lollipops = lollipops; }
        public int GetLollipops() { return this.lollipops; }
    }


    internal class Program
    {
        public static int playersNumber;
        public static int initialPlayerCards = 2;
        public static Deck centralDeck = new Deck();
        public static int initialSharedDeckCards = 3;
        public static List<Player> players = new List<Player>();
        public static int previousBidAmount = 0;


        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            AskPlayers();
            CreateMatch();
            GameCoreLoop();

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


        private static void PrintCard(Card card)
        {
            string suitSymbol = "";
            string cardNumber = "";

            switch (card.number)
            {
                case 1:
                    cardNumber = "A";
                    break;

                case 11:
                    cardNumber = "J";
                    break;

                case 12:
                    cardNumber = "Q";
                    break;

                case 13:
                    cardNumber = "K";
                    break;

                default:
                    cardNumber = card.number.ToString();
                    break;
            }

            switch (card.suit)
            {
                case eCardSuit.Heart:
                    suitSymbol = "♥️";
                    break;
                case eCardSuit.Diamond:
                    suitSymbol = "♦️";
                    break;
                case eCardSuit.Clover:
                    suitSymbol = "♣️";
                    break;
                case eCardSuit.Pike:
                    suitSymbol = "♠️";
                    break;
            }

            Console.Write(
                @"
                  _____
                 |     |
                 |     |
                 |  {0} |
                 |     |
                 |____{1}"
            ,suitSymbol, cardNumber);
        }


        private static void GameCoreLoop()
        {
            SharedDeck sharedDeck = new SharedDeck();
            int currentPlayer = -1;

            //Add 3 new cards to it
            sharedDeck.Add(centralDeck.Steal(initialSharedDeckCards));

            while (sharedDeck.GetCards().Count < 5)
            {
                Console.Clear();
                Console.WriteLine("\x1b[3J");

                currentPlayer += 1;

                if (currentPlayer > players.Count - 1)
                {
                    currentPlayer = 0;
                    sharedDeck.Add(centralDeck.Steal(1));
                }

                if (players.Count == 1)
                {
                    WinnerPlayer(currentPlayer);
                    return;
                }

                Console.WriteLine("Current player is Player " + currentPlayer);
                Console.WriteLine("Your cards are:");
                List<Card> playerCards = players[currentPlayer].GetCards();

                for (int i = 0; i < playerCards.Count; i++)
                    PrintCard(playerCards[i]);
                Console.WriteLine("");

                Console.WriteLine("\nShared deck cards are:");
                for (int i = 0; i < sharedDeck.GetCards().Count; i++)
                    PrintCard(sharedDeck.GetCards()[i]);

                Console.WriteLine("");
                Console.WriteLine("");

                bool validResult = false;
                int answer;

                do
                {
                    Console.WriteLine("== You have " + players[currentPlayer].GetLollipops() + " lollipops ==");
                    Console.WriteLine("== Here is a list of things you can do: ==");
                    Console.WriteLine("0. Check (Continue with the next player)");
                    Console.WriteLine("1. Make a Bid (" + previousBidAmount + " lollipops minimum)");
                    Console.WriteLine("2. Leave the game");
                    Console.Write("Choose an option: ");

                    validResult = int.TryParse(Console.ReadLine(), out answer);

                } while (!validResult || answer > 2 || answer < 0);

                switch (answer)
                {
                    case 0:
                        Console.WriteLine(@" 
                                             #####  #     # #######  #####  #    #  ## 
                                            #     # #     # #       #     # #   #   ## 
                                            #       #     # #       #       #  #    ## 
                                            #       ####### #####   #       ###     #  
                                            #       #     # #       #       #  #       
                                            #     # #     # #       #     # #   #   ## 
                                             #####  #     # #######  #####  #    #  ## "
                         );
                        Thread.Sleep(2000);
                        break;

                    case 1:

                        bool validLollipops = false;
                        int lollipopsToBid = 0;
                        int currentLollipops = players[currentPlayer].GetLollipops();

                        do
                        {
                            if (players[currentPlayer].GetLollipops() < previousBidAmount)
                            {
                                Console.WriteLine(@" 
                                                    #     #                  ######                              ## 
                                                     #   #   ####  #    #    #     # #####   ####  #    # ###### ## 
                                                      # #   #    # #    #    #     # #    # #    # #   #  #      ## 
                                                       #    #    # #    #    ######  #    # #    # ####   #####  #  
                                                       #    #    # #    #    #     # #####  #    # #  #   #          
                                                       #    #    # #    #    #     # #   #  #    # #   #  #      ## 
                                                       #     ####   ####     ######  #    #  ####  #    # ###### ##"
                                );
                                Thread.Sleep(3000);

                                players.RemoveAt(currentPlayer);
                                break;
                            }

                            Console.WriteLine("== You have " + currentLollipops + " lollipops ==");
                            Console.Write("Enter an amount to bill (minimum bill is " + previousBidAmount +
                                "): ");

                            validLollipops = int.TryParse(Console.ReadLine(), out lollipopsToBid);

                        } while (!validResult || lollipopsToBid < previousBidAmount || answer > currentLollipops);

                        //Spend lollipops
                        players[currentPlayer].SetLollipops(currentLollipops - lollipopsToBid);
                        previousBidAmount = lollipopsToBid;

                        break;

                    case 2:
                        return;
                }
            }

            PrintFinale(sharedDeck);
        }


        private static void WinnerPlayer(int winnerPlayer)
        {
            Console.WriteLine(@" 
                                #     # ### #     # #     # ####### ######  ## 
                                #  #  #  #  ##    # ##    # #       #     # ## 
                                #  #  #  #  # #   # # #   # #       #     # ## 
                                #  #  #  #  #  #  # #  #  # #####   ######  #  
                                #  #  #  #  #   # # #   # # #       #   #       
                                #  #  #  #  #    ## #    ## #       #    #  ## 
                                 ## ##  ### #     # #     # ####### #     # ## "
            );
            Console.WriteLine("\n Player " + winnerPlayer + " has won!");
            Console.ReadKey();
        }


        private static void PrintFinale(SharedDeck sharedDeck)
        {
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Player " + i + " cards");

                for (int c = 0; c < players[i].GetCards().Count; c++)
                    PrintCard(players[i].GetCards()[c]);
            }

            Console.WriteLine("");
            Console.WriteLine("\nShared deck cards are:");
            for (int i = 0; i < sharedDeck.GetCards().Count; i++)
                PrintCard(sharedDeck.GetCards()[i]);

            Console.WriteLine("");
            CheckWinner(sharedDeck);
        }


        private static void CheckWinner(SharedDeck sharedDeck)
        {
            //Tuple with Player number, win condition met, and win condition number (optional)
            List<Tuple<int, eWinCondition, int>> winningConditions = new List<Tuple<int, eWinCondition, int>>();

            //For each player
            for (int i = 0; i < players.Count; i++)
            {
                //Check colors if the player has 2 cards of the same color
                if (players[i].GetCards()[0].color == players[i].GetCards()[1].color) 
                {

                    int matching = 0;
                    foreach (var card in sharedDeck.GetCards())
                    {
                        if (card.color == players[i].GetCards()[0].color)
                            matching++;
                    }

                    if (matching >= 3)
                    {
                        winningConditions.Add(Tuple.Create(i, eWinCondition.Color, 0));
                        Console.WriteLine("Player " + i + " has a color!");
                    }     
                }

                //for (int j = 0; j < length; j++)
                //{
                    
                //}
            }
        }

    }
}
