using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SmartLibrarySystem.Data;

public static class FileStorage
{
    private static readonly JsonSerializerOptions Options = new JsonSerializerOptions
    {
        WriteIndented = true
    };

    public static void SaveData<T>(string filePath, List<T> data)
    {
        string json = JsonSerializer.Serialize(data, Options);
        File.WriteAllText(filePath, json);
    }

    public static List<T> LoadData<T>(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return new List<T>();
        }

        string json = File.ReadAllText(filePath);
        if (string.IsNullOrWhiteSpace(json))
        {
            return new List<T>();
        }

        return JsonSerializer.Deserialize<List<T>>(json, Options) ?? new List<T>();
    }
}
