using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    static class Turn
    {
        public static int selectFirstPlayer(List<Player> players)
        {
            int numberOfPlayers = players.Count;
            Random rnd = new Random();
            var randomFirstPlayer = rnd.Next(0, numberOfPlayers);
            Console.WriteLine(" {0} goes first! Here's your card: ", players[randomFirstPlayer].getPlayerName);
            return randomFirstPlayer;
        }

        public static void firstRound(Game gameName)
        {
            Console.Clear();
            Console.WriteLine("GAME BEGINS");
            Console.WriteLine();
            int firstPlayer = Turn.selectFirstPlayer(gameName.players);
            Console.WriteLine();
            Score.checkScore(gameName.players);
            // The following monster shows the first card of the player who got to go first:
            gameName.players.ElementAt(firstPlayer).playDeck.showFirstCard();
            int category = Turn.selectCategory(gameName);
            Comparator.compareCategory(category, gameName.players, gameName);
                        
        }

        public static void nextRound(Game gameName, int winnerOfPreviousRound)
        {
            Score.checkScore(gameName.players);
            gameName.players.ElementAt(winnerOfPreviousRound).playDeck.showFirstCard();
            int category = Turn.selectCategory(gameName);
            Comparator.compareCategory(category, gameName.players, gameName);
        }

        // TODO: Make number of categories automatically match test.txt
        // TODO: Make a try-catch to avoid errors if wrong type input
        public static int selectCategory(Game game)
        {
            
            int categoryValue;
            String categorySelected;

            Console.Write(" Select a category: ");
            categorySelected = Console.ReadLine();

            if(categorySelected.ToUpper() == "Q")
            {
                //TODO 20130515: Add some sort of text to show the score at time of exit.
                Console.WriteLine("Add stuff about the score when the game is exited (There is a TODO about it)");
                Console.ReadLine();
                Environment.Exit(0);
            }

            while (!Int32.TryParse(categorySelected, out categoryValue) || categoryValue > game.getNumberOfCategories() - 1 || categoryValue < 0)
            {
                Console.WriteLine("Not a valid number, try again.");
                categorySelected = Console.ReadLine();
            }

            Console.WriteLine();
            return categoryValue;

        }


    
    } // END OF CLASS
}
