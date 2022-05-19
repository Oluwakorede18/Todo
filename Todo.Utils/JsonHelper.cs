
using Newtonsoft.Json;

namespace Todo.Utils
{
    public static class JsonHelper<K>
    {
        private static readonly JsonSerializerSettings _settings =
            new () { NullValueHandling = NullValueHandling.Ignore };
        //A generic method ususally <T>
        public static void WriteToFile(K obj,string fileName)
        {
            using var streamWriter = File.CreateText(fileName);
            using var jsonWriter = new JsonTextWriter(streamWriter);
            JsonSerializer.CreateDefault(_settings).Serialize(jsonWriter, obj);
        }

        public static List<K> ReadFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                File.CreateText(fileName);
            }
            using var streamReader = File.OpenText(fileName);
            using var jsonReader = new JsonTextReader(streamReader);
            var result = JsonSerializer.CreateDefault(_settings).Deserialize<List<K>>(jsonReader);
            if (result == null)
            {
                return new List<K>();
            }
            return result;
        }
    }
}
