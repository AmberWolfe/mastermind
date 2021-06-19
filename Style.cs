using System;
using System.Collections.Generic;
using System.Text;

namespace MastermindKnockoff
{
    public class Style
    {
        public void DashBreak()
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
        }

        public void XBreak()
        {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }

        public void MakeSpace()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(); 
        }
    }
}
