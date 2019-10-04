using Xunit;
using DiscordBot.Storage.Impl;
using System;

namespace DiscordBot.xUnit.Tests
{
    public class DataStorageTests
    {
        [Fact]
        public void StorageDefaultToJson()
        {

            var storage = Unity.Resolve<IDataStorage>();

            Assert.Throws<InvalidCastException>(() =>
            {
                var ims = (InMemoryStorage)storage;
            });


            var s = (JsonStorage)storage;
        }


        [Fact]
        public void InMemoryStorageTest()
        {

            var storage = new InMemoryStorage();
        }
    }
}
