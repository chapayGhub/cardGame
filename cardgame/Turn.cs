using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    static class Turn
    {

        public static void firstRound(Game gameName)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n GAME BEGINS\t\n");
            Console.ResetColor();
            Console.WriteLine();
            
            int firstPlayer = Turn.selectFirstPlayer(gameName.players);
            Console.WriteLine();
            // Show the first card of the player who got to go first:
            gameName.players.ElementAt(firstPlayer).playDeck.showFirstCard();
            int category = Turn.selectCategory(gameName);
            Comparator.compareCategory(category, gameName.players, gameName);

        }

        public static int selectFirstPlayer(List<Player> players)
        {
            int numberOfPlayers = players.Count;
            Random rnd = new Random();
            var randomFirstPlayer = rnd.Next(0, numberOfPlayers);
            
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(" " + players[randomFirstPlayer].getPlayerName + " ");
            Console.ResetColor();
            Console.WriteLine(" goes first! Here's your card: ");
            return randomFirstPlayer;
        }

        public static void nextRound(Game gameName, int winnerOfPreviousRound)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n " + gameName.players.ElementAt(winnerOfPreviousRound).getPlayerName + " ");
            Console.ResetColor();
            Console.WriteLine(" gets to pick next category: ");
            Console.WriteLine();

            // Show the first card of the player who won previous round:
            gameName.players.ElementAt(winnerOfPreviousRound).playDeck.showFirstCard();
            int category = Turn.selectCategory(gameName);
            Comparator.compareCategory(category, gameName.players, gameName);
        }

        public static int selectCategory(Game game)
        {
            int categoryValue;
            String categorySelected;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Select a category: ");
            Console.ResetColor();
            categorySelected = Console.ReadLine();

            if(categorySelected.ToUpper() == "Q")
            {
                Score.quitScore(game.players);
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (categorySelected.ToUpper() == "S")
            {
                Score.printScoreboard(game.players);
                Console.ForegroundColor = ConsoleColor.Blue;               
                Console.Write(" Select a category: ");
                Console.ResetColor();
                categorySelected = Console.ReadLine();
            }

            while (!Int32.TryParse(categorySelected, out categoryValue) || categoryValue > game.players.ElementAt(0).playDeck.getNumberOfCategories() - 1 || categoryValue < 0)
            {
                Console.Write(" Not a valid category number. ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Try again: ");
                Console.ResetColor();
                categorySelected = Console.ReadLine();
            }

            Console.WriteLine();
            return categoryValue;

        }


    
    } // END OF CLASS
}
