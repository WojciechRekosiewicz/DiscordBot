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
           

            var botDiscordConfig = new DiscordBotConfig()
            {
                Token = "ABC"
                //SocketConfig = SocketConfig.GetDefault()

            };

            var connection = Unity.Resolve<Connection>();
            await connection.ConnectAsync(botDiscordConfig);

            Console.ReadKey();



        }
    }
}
