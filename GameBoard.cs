using System;
using System.Collections.Generic;
using System.Text;

namespace MastermindKnockoff
{
    public class GameBoard
    {
        public string[] playerGuess { get; } = new string[4];

        public string[] correctAnswer { get; } = new string[4];

        public string correctNumAndSlot { get; } = "!";

        public string correctNumWrongSlot { get; } = "?";

        public string wrongNumWrongSlot { get; } = "-";

        public List<string> possibleNumbers
        {
            get
            {
                possibleNumbers.Add("1");
                possibleNumbers.Add("2");
                possibleNumbers.Add("3");
                possibleNumbers.Add("4");
                possibleNumbers.Add("5");
                possibleNumbers.Add("6");

                return possibleNumbers;
            }
        }

        public string[] guessFeedback { get; } = new string[4];

        public int NumOfFullyCorrectGuesses(string playerGuess, string correctAnswer)
        {
            int numberOfCorrect = 0;
            for (int i = 0; i < 4; i++)
            {
                if (playerGuess[i] == correctAnswer[i])
                {
                    numberOfCorrect += 1;
                }
            }
            return numberOfCorrect;
        }

        public int NumOfPartiallyCorrectGuesses(string playerGuess, string correctAnswer)
        {
            HashSet<string> partCorrect = new HashSet<string>();
            for (int i = 0; i < 4; i++)
            {
                if (playerGuess[i] != correctAnswer[i])
                {
                    if (playerGuess[i] == correctAnswer[0])
                    {
                        partCorrect.Add("correctAnswer[0]");
                    }
                    else if (playerGuess[i] == correctAnswer[1])
                    {
                        partCorrect.Add("correctAnswer[1]");
                    }
                    else if (playerGuess[i] == correctAnswer[2])
                    {
                        partCorrect.Add("correctAnswer[3]");
                    }
                    else if (playerGuess[i] == correctAnswer[3])
                    {
                        partCorrect.Add("correctAnswer[4]");
                    }
                }
            }
            return partCorrect.Count;
        }
    }
}
