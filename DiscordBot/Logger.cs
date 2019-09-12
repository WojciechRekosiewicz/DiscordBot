using System;
using System.Collections.Generic;
using System.Text;
using Discord;

namespace DiscordBot
{
    class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

    }
}
