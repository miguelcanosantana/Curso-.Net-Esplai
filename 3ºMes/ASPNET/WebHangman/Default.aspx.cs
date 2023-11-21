using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

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

            //If the page loads for the first time
            if (!IsPostBack)
            {
                //Reset initial variables
                isMatchEnd = false;
                lives = 7;
                randomWord = words[rand.Next(0, words.Length)];
                guessedWord = "";

                for (int i = 0; i < randomWord.Length; i++)
                    guessedWord += "-";

                //Set initial forms
                GuessedWordLabel.Text = guessedWord;
                LivesLabel.Text = "Lives: " + lives;
            }
        }


        public void TryAttempt()
        {
            if (isMatchEnd) 
                return;

            if (InputTextBox.Text.Length == 1)
                TryGuessLetter(InputTextBox.Text);
            else 
                TryGuessWord(InputTextBox.Text);

            GuessedWordLabel.Text = guessedWord;
            LivesLabel.Text = "Lives: " + lives.ToString();
        }


        private void TryGuessLetter(String letter)
        {
            var randomArray = randomWord.Split();
            var guessedArray = guessedWord.Split();

            if (randomWord.Contains(letter))
            {
                for (int i = 0; i < randomArray.Length; i++)
                {
                    if (randomArray[i].Equals(letter))
                        guessedArray[i] = letter;
                }

                guessedWord = String.Join("", guessedArray);
            }
            else
            {
                lives--;
                HangmanImage.ImageUrl = "~/Images/" + (7 - lives) + ".png";
            }

            InputTextBox.Text = "";

            if (guessedWord.Equals(randomWord) && lives > 0)
            {
                WinLabel.Text = "You Won!";
                isMatchEnd = true;
            }
            else if (lives <= 0)
            {
                LoseLabel.Text = "You Lose!";
                guessedWord = "Word was: " + randomWord;
                isMatchEnd = true;
            }
        }


        private void TryGuessWord(String word)
        {
            if (word.Equals(guessedWord) && lives > 0)
            {
                WinLabel.Text = "You Won!";
                isMatchEnd = true;
            }
            else
            {
                LoseLabel.Text = "You Lose!";
                guessedWord = "Word was: " + randomWord;
                HangmanImage.ImageUrl = "~/Images/7.png";
                isMatchEnd = true;
            }
        }


        protected void CheckButton_Click(object sender, EventArgs e)
        {
            TryAttempt();
        }
    }
}