using System;
using System.IO;
using Microsoft.UI.Xaml.Shapes;
using Newtonsoft.Json;

namespace JsonEditor_win.Utilities
{
    public class FileUtility
    {
        public static T? ReadFile<T>(string filePath)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(filePath));
        }

        public static void WriteFile<T>(string filePath, T data)
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(data, Formatting.Indented));
        }

        public static void CreateFolder(string path) { 
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
        }
    }
}
