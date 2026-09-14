using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using JsonEditor_win.Services;
using JsonEditor_win.Utilities;

namespace JsonEditor_win.Models.ViewModels
{
    public partial class PatternViewModel : ObservableObject
    {
        public ObservableCollection<string> Patterns { get; set; } = [];

        [ObservableProperty]
        public partial string PatternName { get; set; }

        [ObservableProperty]
        public partial string SelectedPattern { get; set; }

        public PatternViewModel()
        {
            PatternName = string.Empty;
            SelectedPattern = string.Empty;

            FileUtility.CreateFolder(PathService.PatternsDirectoryPath);
            foreach (var pattern in Directory.EnumerateFiles(PathService.PatternsDirectoryPath,
                "*.json"))
            {
                Patterns.Add(Path.GetFileNameWithoutExtension(pattern));
            }
        }

        [RelayCommand]
        public void AddPattern(string pattern)
        {
            if (!string.IsNullOrWhiteSpace(PatternName) && !Patterns.Contains(PatternName))
            {
                Patterns.Add(PatternName);
                File.WriteAllText(Path.Combine(PathService.PatternsDirectoryPath,
                    $"{PatternName}.json"), pattern);
                PatternName = string.Empty;
            }
        }

        [RelayCommand]
        public void RemovePattern() { 
            FileUtility.DeleteFile(Path.Combine(PathService.PatternsDirectoryPath, $"{SelectedPattern}.json"));
            Patterns.Remove(SelectedPattern);
            SelectedPattern = string.Empty;
        }

        [RelayCommand]
        public void LoadPattern(JsonViewModel jsonViewModel)
        {
            string pattern = File.ReadAllText(Path.Combine(PathService.PatternsDirectoryPath, $"{SelectedPattern}.json"));
            jsonViewModel.LoadJson(pattern);
        }
    }
}
