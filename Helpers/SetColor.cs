using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeflame.Helpers
{
    public class SetColor
    {
        public void resetColor()
        {
            Console.ResetColor();
        }

        public void setColor(string c)
        {
            switch (c)
            {
                case "Black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                case "DarkBlue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;

                case "DarkGreen":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;

                case "DarkCyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;

                case "DarkRed":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;

                case "DarkYellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;

                case "DarkMagenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;

                case "Gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;

                case "DarkGray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;

                case "Blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case "Cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;

                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case "Magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;

                case "Yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                case "White":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        } 
    }
}
