using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;

namespace JsonEditor_win.Models.ViewModels
{
    public partial class PropertyViewModel: ObservableObject
    {
        [ObservableProperty]
        public partial JsonProperty? Property { get; set; }
    }
}
