using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using JsonEditor_win.Utilities;
using Microsoft.UI;
using Microsoft.Windows.Storage.Pickers;

namespace JsonEditor_win.Models.ViewModels
{
    public partial class JsonViewModel : ObservableObject
    {
        public JsonProperty Property { get; set; }

        private JsonProperty? selectedProperty;
        public JsonProperty? SelectedProperty
        {
            get => selectedProperty;
            set
            {
                SetProperty(ref selectedProperty, value);
                SelectionChanged?.Invoke(selectedProperty);
            }
        }
        public ObservableCollection<JsonProperty> Properties { get; set; }

        public JsonProperty Root;


        private bool isJsonModified;
        private string _json;
        public string Json
        {
            get => _json;
            set
            {
                SetProperty(ref _json, value);
                string previousJson = JsonUtility.TreeToJson(Root);
                if (previousJson != value)
                {
                    try
                    {
                        isJsonModified = true;
                        JsonProperty prop = JsonUtility.JsonToTree(value);
                        Root.Children.Clear();
                        foreach (var child in prop.Children)
                        {
                            Root.Children.Add(child.Clone(updateAction, Root));
                        }
                        isJsonModified = false;
                        JsonNode? node = JsonNode.Parse(value);
                        if (node is not null)
                            SetProperty(ref _json, node.ToString());
                    }
                    catch
                    {

                    }

                }
            }
        }

        private readonly Action updateAction;
        public event Action<JsonProperty?>? SelectionChanged;

        public JsonViewModel()
        {
            _json = string.Empty;
            Properties = [];
            updateAction = () =>
            {
                if (Root is not null && !isJsonModified)
                    Json = JsonUtility.TreeToJson(Root);
            };
            Properties.CollectionChanged += (s, e) =>
            {
                updateAction();
            };

            Root = new(updateAction)
            {
                Name = "Root",
                Value = string.Empty,
                Type = JsonType.Object,
            };
            Root.Children.Add(new(updateAction, Root)
            {
                Name = "Child1",
                Type = JsonType.Object
            });

            Properties.Add(Root);

            Property = new(updateAction);
        }

        [RelayCommand]
        public void AddProperty()
        {
            SelectedProperty?.Children.Add(Property.Clone(updateAction, SelectedProperty));
            Property.Reset();
        }

        [RelayCommand]
        public void DeleteProperty()
        {
            SelectedProperty?.Parent?.Children.Remove(SelectedProperty);
            SelectedProperty?.Reset();
        }

        public void LoadJson(string pattern)
        {
            Properties.Clear();
            Root.Children.Clear();
            foreach (var child in JsonUtility.JsonToTree(pattern).Children)
            {
                Root.Children.Add(child.Clone(updateAction, Root));
            }
            Properties.Add(Root);
        }

        [RelayCommand]
        public void CreateNewJson()
        {
            Root.Children.Clear();
        }

        [RelayCommand]
        public async Task OpenJson(WindowId id)
        {
            FileOpenPicker filePicker = new(id)
            {
                Title = "Open JSON File",
                CommitButtonText = "Open"
            };
            filePicker.FileTypeChoices.Add("Json Files", [".json"]);

            var res = await filePicker.PickSingleFileAsync();
            string jsonContent = File.ReadAllText(res.Path);
            LoadJson(jsonContent);
        }

        [RelayCommand]
        public async Task SaveJson(WindowId id)
        {
            FileSavePicker filePicker = new(id)
            {
                Title = "Save JSON File",
                CommitButtonText = "Save"
            };
            filePicker.FileTypeChoices.Add("Json Files", [".json"]);
            var res = await filePicker.PickSaveFileAsync();
            if (res is not null)
            {
                File.WriteAllText(res.Path, Json);
            }
        }
    }
}
