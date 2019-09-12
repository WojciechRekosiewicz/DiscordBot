using Discord;
using Discord.WebSocket;
using DiscordBot.Discord.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Discord
{
    public class Connection
    {

        private readonly DiscordSocketClient _client;
        private readonly DiscordLogger _logger;

        public Connection(DiscordLogger logger, DiscordSocketClient client)
        {
            _logger = logger;
            _client = client;
        

        }

        internal async Task ConnectAsync(DiscordBotConfig config)
        {    
            _client.Log += _logger.Log;                                    
        }
    }
}
