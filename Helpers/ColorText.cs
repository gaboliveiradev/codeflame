using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeflame.Helpers
{
    public class ColorText
    {
        public void setGreen()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void setRed()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void setGray()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
