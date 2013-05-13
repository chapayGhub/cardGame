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
            int category = Turn.selectCategory();
            Comparator.compareCategory(category, gameName.players, gameName);
                        
        }

        public static void nextRound(Game gameName, int winnerOfPreviousRound)
        {
            Score.checkScore(gameName.players);
            gameName.players.ElementAt(winnerOfPreviousRound).playDeck.showFirstCard();
            int category = Turn.selectCategory();
            Comparator.compareCategory(category, gameName.players, gameName);
        }

        // TODO: Make number of categories automatically match test.txt
        // TODO: Make a try-catch to avoid errors if wrong type input
        public static int selectCategory()
        {
            Console.Write(" Select a category: ");
            int selectCategory = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return selectCategory;

        }


    
    } // END OF CLASS
}
