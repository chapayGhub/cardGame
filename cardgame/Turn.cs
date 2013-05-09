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
            Console.WriteLine("{0} goes first!", players[randomFirstPlayer].getPlayerName);
            return randomFirstPlayer;
        }

        // TODO: Make method so player whose turn it is can choose category.
        public static void firstRound(Game gameName)
        {
            int firstPlayer = Turn.selectFirstPlayer(gameName.players);
            // The following monster shows the first card of the player who got to go first:
            gameName.players.ElementAt(firstPlayer).playDeck.showFirstCard();
            int category = Turn.selectCategory();
            Comparator.compareCategory(category, gameName.players);
            // TODO: Send winning player as argument to nextRound
            Score.checkScore(gameName.players);
        }

        // TODO: Take winner of previous round as argument for this round
        public static void nextRound(Game gameName)
        {
            // TODO: Show first card of winner of previous round
            int category = Turn.selectCategory();
            Comparator.compareCategory(category, gameName.players);
        }

        // TODO: Make number of categories automatically match test.txt
        public static int selectCategory()
        {
            Console.Write("Select category [0, 1]: ");
            int selectCategory = Convert.ToInt32(Console.ReadLine());
            return selectCategory;

        }


    
    } // END OF CLASS
}
