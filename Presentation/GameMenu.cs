using PigDiceGame.Controller;
using PigDiceGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame.Presentation
{
    internal class GameMenu
    {
        static Game newGame = null; 
        public static void StartGame()
        {
            Console.WriteLine("Enter Your name:");
            string name = Console.ReadLine();
            newGame = new Game(name);
            Console.WriteLine($"Let's play the game {name}");
            DisplayMenu();
        }

        public static void StartOrEndGame() {
            while (true) {
                Console.WriteLine($"\n1.Start new game\n" +
                    $"2.End game\n");
                int choice = int.Parse( Console.ReadLine() );
                switch (choice)
                {
                    case 1:
                        StartGame();
                        break;

                    case 2:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please choose correct option!");
                        break;
                }
            }
        }


        public static void DisplayMenu()
        {
            while (true) { 
            Console.WriteLine($"\n1.Roll the dice\n" +
            $"2.Hold and end the game\n");
            int choice = int.Parse( Console.ReadLine() );
            ExecuteCases( choice);
            }
            
        }
        public static void ExecuteCases(int choice) {
            switch (choice)
            {
                case 1:
                    RollTheDice();
                    break;

                case 2:
                    Console.WriteLine($"{Services.CheckWinOrLoss(newGame)} your score is: {newGame.PlayerScore}");
                    StartOrEndGame();
                    break;

                default:
                    Console.WriteLine("Please choose correct option!");
                    break;
            }
        }

        public static void RollTheDice()
        {
            int number = Services.RollDice();
            Console.WriteLine($"Current Score : {number}");
            ExecuteConditions( number );
        }

        public static void ExecuteConditions(int number)
        {
            List<int> store = newGame.EachRoll;
            switch (number)
            {
                case 1:
                    Console.WriteLine($"{Services.CheckWinOrLoss(newGame)} your score is: {newGame.PlayerScore}");
                    StartOrEndGame();
                    break;

                default:
                    store.Add(number);
                    DisplayMenu();
                    break;
            }
        }

    }
}
