using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;

namespace JsonEditor_win.Models
{
    public partial class JsonProperty : ObservableObject
    {
        [ObservableProperty]
        public partial string Name { get; set; }

        [ObservableProperty]
        public partial string Value { get; set; }


        private JsonType? type;
        public JsonType? Type
        {
            get => type; 
            set
            {
                SetProperty(ref type, value);
                IsValueEnabled = type != JsonType.Object;
            }
        }

        [ObservableProperty]
        public partial bool IsValueEnabled { get; set; } = true;

        public ObservableCollection<JsonProperty> Children { get; set; } = [];

        public JsonProperty? Parent;


        public JsonProperty(Action action, JsonProperty? parent = null)
        {
            Subscribe(action);
            Name = string.Empty;
            Value = string.Empty;
            Type = JsonType.Object;
            Parent = parent;
        }

        public JsonProperty(string name, string value, JsonType? type = null)
        {
            Name = name;
            Value = value;
            Type = type;
        }

        public void Reset()
        {
            Name = string.Empty;
            Value = string.Empty;
            Type = JsonType.Value;
        }

        public JsonProperty Clone(Action action, JsonProperty? parent = null)
        {
            JsonProperty clone = new(action, parent)
            {
                Name = this.Name,
                Value = this.Value,
                Type = this.Type
            };

            foreach (var child in Children)
            {
                clone.Children.Add(child.Clone(action, clone));
            }

            return clone;
        }

        public void Subscribe(Action action) { 
            Children.CollectionChanged += (s, e) => action();
        }
    }
}
