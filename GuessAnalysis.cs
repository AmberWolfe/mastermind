using System;
using System.Collections.Generic;
using System.Text;

namespace MastermindKnockoff
{
    public class GuessAnalysis
    {
        public string CorrectNumAndSlot { get; } = "!";

        public string CorrectNumWrongSlot { get; } = "?";

        public string WrongNumWrongSlot { get; } = "-";

        public string[] GuessFeedback { get; } = new string[4];

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
