using System;
using System.Collections.Generic;
using System.Text;
using Discord;

namespace DiscordBot
{
    public interface ILogger
    {
        void Log(string message);
    }
}
