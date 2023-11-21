using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHangman
{
    public partial class _Default : Page
    {
        static bool isMatchEnd;
        static int lives;
        static String randomWord;
        static String guessedWord;

        static String[] words = new String[] {"lizard", "cat", "dog", "dolphin", "jaguar",
            "giraffe", "hippopotamus", "cow", "goat", "elephant", "porcupine", "bird", "fox",
            "wolf", "goose", "duck", "alligator" };

        static Random rand = new Random();


        protected void Page_Load(object sender, EventArgs e)
        {
            //Reset initial variables
            isMatchEnd = false;
            lives = 7;
            randomWord = words[rand.Next(0, words.Length)];
            guessedWord = "";

            for (int i = 0; i < randomWord.Length; i++)
            {
                guessedWord += "-";
            }

            //Set initial forms
            GuessedWordLabel.Text = guessedWord;
            LivesLabel.Text = "Lives: " + lives;
        }
    }
}