using Xunit;
using DiscordBot;

namespace DiscordBot.xUnit.Tests
{
    public class UtilityTests
    {
        [Fact]
        public void MyFirstTest()
        {

            const int expected = 5;
            var actual = Utilities.MyUtility();
        }
    }
}
