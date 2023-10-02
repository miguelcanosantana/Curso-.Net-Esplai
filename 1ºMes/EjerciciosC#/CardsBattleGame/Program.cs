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

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
