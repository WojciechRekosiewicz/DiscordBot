using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordBot.Storage.Impl
{

    class InMemoryStorage : IDataStorage
    {



        private readonly Dictionary<string, object> _dictionary = new Dictionary<string, object>();

        //public InMemoryStorage()
        //{
        //    Console.WriteLine("sss");
        //    //this.dictionary = _dictionary;
        //}

        public void StoreObject(object obj, string key)
        {
            if (_dictionary.ContainsKey(key)) return;
            _dictionary.Add(key, obj);
        }

        public T RestoreObject<T>(string key)
        {
            if (!_dictionary.ContainsKey(key))
                throw new ArgumentException($"Key provided {key} wasn't found");

            return (T)_dictionary[key];

        }

  
    }
}
