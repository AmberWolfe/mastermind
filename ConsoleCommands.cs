using System;
using System.Collections.Generic;
using System.Text;

namespace MastermindKnockoff
{
    public class ConsoleCommands
    {
        public void Run()
        {
            GameBoard gameBoard = new GameBoard();
            string[] newGame = new string[4];
            newGame = gameBoard.NewGame();
        }

        public void BeginGame()
        {
            Style style = new Style();
            style.XBreak();
            Console.WriteLine("Welcome to MASTERMIND: The Knockoff Version");
            style.XBreak();
        }
        // Make menu ask if player wants to read the rules.
        // Get player guess
        // Analyze Guess
        // Give player the analysis
        // Repeat Guess and Analysis until player wins or loses
    }
}
