using PigDiceGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame.Controller
{
    internal class Services
    {
        public static int RollDice() { 
            Random rnd = new Random();
            return rnd.Next(1,7);
        }

        public static string CheckWinOrLoss(Game game)
        {   

            foreach(int I in game.EachRoll)
            {
                game.PlayerScore += I;
            }
            if (game.PlayerScore >= 20) {
                return $"Hurry {game.Name} you won";
            }
            return $"You loss!";
        }
    }
}
