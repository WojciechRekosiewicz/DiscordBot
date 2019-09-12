using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordBot
{
    class Logger
    {
        public void Log(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
