using DiscordBot.Storage.Impl;
using System;
using Discord.WebSocket;
using System.Threading.Tasks;
using DiscordBot.Discord.Entities;
using DiscordBot.Discord;

namespace DiscordBot
{
     class Program
    {
        static void Main()
        {
    
            Unity.RegiterTypes();
           

            var botDiscordConfig = new DiscordBotConfig()
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()

            };

            var connection = Unity.Resolve<Connection>();





        }
    }



}
