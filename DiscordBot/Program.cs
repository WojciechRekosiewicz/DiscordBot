using System;
using DiscordBot.Discord.Entities;
using DiscordBot.Discord;
using System.Threading.Tasks;

namespace DiscordBot
{
     internal class Program
    {
        private static async Task Main()
        {
    
            Unity.RegiterTypes();
           
            var storage = Unity.Resolve<IDataStorage>();

            var connection = Unity.Resolve<Connection>();
            await connection.ConnectAsync(new DiscordBotConfig
            {
                Token = storage.RestoreObject<string>("Bot")
                //SocketConfig = SocketConfig.GetDefault()

            });

            Console.ReadKey();



        }
    }
}
