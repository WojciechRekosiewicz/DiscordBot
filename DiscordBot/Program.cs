using DiscordBot.Storage.Impl;
using System;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace DiscordBot
{
     class Program
    {
        static void Main()
        {
        
            Unity.RegiterTypes();


            var config = new DiscordSocketConfig
            {
                AlwaysDownloadUsers = true

            };
            var client = new DiscordSocketClient(config);
            Console.WriteLine("HW!");



        }
    }



}
