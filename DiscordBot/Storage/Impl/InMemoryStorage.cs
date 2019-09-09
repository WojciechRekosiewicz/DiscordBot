using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordBot.Storage.Impl
{
    class InMemoryStorage : IDataStorage
    {
        public T RestoreObject<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void StoreObject(object obj, string key)
        {
            throw new NotImplementedException();
        }
    }
}
