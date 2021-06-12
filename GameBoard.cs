using System;
using System.Collections.Generic;
using System.Text;

namespace MastermindKnockoff
{
    public class GameBoard
    {
        public string[] CorrectAnswer { get; } = new string[4];

        public string[] NewGame()
        {
            string[] newGame = new string[4];
            GameBoard gameBoard = new GameBoard();
            Random random = new Random();
            newGame[0] = random.Next(1, 6).ToString();
            newGame[1] = random.Next(1, 6).ToString();
            newGame[2] = random.Next(1, 6).ToString();
            newGame[3] = random.Next(1, 6).ToString();
            return newGame;
        }
    }
}
