using System;
using System.IO;

namespace JsonEditor_win.Services
{
    public class PathService
    {
        private readonly static string EnvironmentPath = Path.GetDirectoryName(Environment.ProcessPath) ?? string.Empty;
        
        public readonly static string DataDirectoryPath = Path.Combine(EnvironmentPath, "Data");
        public readonly static string SettingsFilePath = Path.Combine(DataDirectoryPath, "settings.json");
        public readonly static string PatternsDirectoryPath = Path.Combine(DataDirectoryPath, "Patterns");


    }
}
