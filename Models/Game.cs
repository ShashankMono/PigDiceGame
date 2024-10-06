using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame.Models
{
    internal class Game
    {
        public List<int> EachRoll {  get; set; } = new List<int>();
        public int PlayerScore {  get; set; } = 0;
        public string Name {  get; set; }

        public Game(string name)
        {
            Name = name;
        }
    }
}
