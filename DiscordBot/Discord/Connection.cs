﻿using Discord;
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
        private DiscordSocketClient _client;


        internal async Task ConnectAsync(DiscordBotConfig config)
        {
            _client = new DiscordSocketClient(config.SocketConfig);

            var a = new DiscordLogger();


            _client.Log += a.Log;
                       
             
        }
    }
}
