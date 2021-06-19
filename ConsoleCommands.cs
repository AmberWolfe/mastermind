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

        Style style = new Style();
        public void BeginGame()
        {
            style.XBreak();
            Console.WriteLine("Welcome to MASTERMIND: The Knockoff Version");
            style.XBreak();
            Console.WriteLine();
        }

        public void StartMenu()
        {
            ConsoleCommands cc = new ConsoleCommands();
            string userInput = null;
            while (true)
            {
                style.DashBreak();
                Console.WriteLine("MENU");
                Console.WriteLine();
                Console.WriteLine("1. Read Rules");
                Console.WriteLine();
                Console.WriteLine("2. Start Game");
                Console.WriteLine();
                Console.WriteLine("3. Exit");
                style.DashBreak();

                Console.WriteLine("Type 1 or 2 or 3 and hit enter: ");
                Console.WriteLine();
                userInput = Console.ReadLine().Trim();

                if (userInput.Equals("1"))
                {
                    cc.Rules(); //ToDo figure out how to make this work
                }
                else if (userInput.Equals("2"))
                {
                    break; //ToDo replace with a call on the correct method
                }
                else if (userInput.Equals("3"))
                {
                    break;
                }
                Console.Clear();

            }
        }

        public void Rules()
        {
            Console.Clear();
            Console.WriteLine("RULES:");
            Console.WriteLine("1. You must guess the 4 numbers in the secret code.");
            Console.WriteLine("2 You have a maximum of 10 guesses before you lose.");
            Console.WriteLine("3. Each guess is worth one point. In this game points are bad... the less points the better.");
            Console.WriteLine("4. The possible numbers are 1-6");
            Console.WriteLine("5. Repeats ARE allowed. Ex: 4421, 2222, 1212");
            Console.WriteLine("6. After each guess you will be given a guess analysis that will help you solve the problem.");
            Console.WriteLine("      >>> Guesses that include a correct number in the correct spot will return an exclamation point symbol: !");
            Console.WriteLine("      >>> Guesses that include a correct number, but in the wrong spot will return a question mark symbol: ?");
            Console.WriteLine("      >>> Guesses that are completely wrong will return a dash symbol: -");
            Console.WriteLine("      >>> Each guess analysis will return 4 symbols. Ex: !!?-, !?--, ----");
            Console.WriteLine("      >>> Analysis results will always show all ! first, then ?, and lastly any -");
            Console.WriteLine();
            Console.WriteLine("EXAMPLES");
            Console.WriteLine(" | Example # | Correct Answer | Guess | Analysis |");
            Console.WriteLine(" |1 | 1234 | 2432 | !??- |");
            Console.WriteLine(" |2 | 2222 | 3223 | !!-- |");
            Console.WriteLine(" |3 | 1212 | 4444 | ---- |");
            //ToDo Align the Examples in columns


        }
        // Make menu ask if player wants to read the rules.
        // Get player guess
        // Analyze Guess
        // Give player the analysis
        // Repeat Guess and Analysis until player wins or loses
        // Display Score 
        // Prompt to play again
    }
}
