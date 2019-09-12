using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using static System.IO.Directory;

namespace DiscordBot.Storage.Impl
{
    class JsonStorage : IDataStorage
    {
        public T RestoreObject<T>(string key)
        {
            var json = File.ReadAllText($"{key}.json");
            return JsonConvert.DeserializeObject<T>(json);
        }

        public void StoreObject(object obj, string key)
        {
            var file = $"{key}.json";
            CreateDirectory(file);
            var json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(file, json);

        }
    }
}
