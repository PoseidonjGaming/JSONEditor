using System.IO;
using JsonEditor_win.Models;
using JsonEditor_win.Utilities;

namespace JsonEditor_win.Services
{
    public class SettingsService
    {
        public Settings Settings { get; set; }

        public SettingsService()
        {
            Settings = LoadSettings();
        }

        public static Settings LoadSettings()
        {
            Settings defaultSettings = new();
            if (File.Exists(PathService.SettingsFilePath))
                return FileUtility.ReadFile<Settings>(PathService.SettingsFilePath) ?? defaultSettings;
            return defaultSettings;
        }

        public void SaveSettings()
        {
            FileUtility.CreateFolder(PathService.DataDirectoryPath);
            FileUtility.WriteFile(PathService.SettingsFilePath, Settings);
        }
    }
}
