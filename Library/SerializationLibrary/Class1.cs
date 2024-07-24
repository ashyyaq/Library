using System;
using System.IO;
using System.Text.Json;

namespace SerializationLibrary
{
    public static class Serializer
    {
        public static void SerializeToFile<T>(T obj, string filePath)
        {
            string jsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText(filePath, jsonString);
        }

        public static T DeserializeFromFile<T>(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found", filePath);

            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }
}
