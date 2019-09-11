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
            Console.WriteLine("HW!");

            //var config = new DiscordSocketConfig
            //{
            //    AlwaysDownloadUsers = true            
            //};
            //var client = new DiscordSocketClient(config);

            var a = new DiscordBotConfig()
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()

            };



        }
    }



}
