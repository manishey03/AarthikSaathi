using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace AarthikSaathi_22069007.Utilities
{
    public static class JsonFileHandler
    {
        public static async Task<List<T>> ReadDataAsync<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<T>();
            }

            var jsonData = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<T>>(jsonData);
        }

        public static async Task WriteDataAsync<T>(string filePath, List<T> data)
        {
            var jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(filePath, jsonData);
        }
    }
}
