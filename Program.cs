using System;

namespace MastermindKnockoff
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleCommands cc = new ConsoleCommands();
            Style style = new Style();
            cc.Run();
            cc.BeginGame();
            style.MakeSpace();
        }
    }
}
