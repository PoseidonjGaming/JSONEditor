using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using JsonEditor_win.Models;
using JsonEditor_win.Models.ViewModels;
using JsonEditor_win.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace JsonEditor_win.Windows
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PropertyWindow : Window
    {
        public JsonViewModel JsonViewModel { get; set; }
        public Array JsonTypes { get; set; }

        public PropertyViewModel PropertyViewModel { get; set; }
        public Visibility IsAddMode { get; set; }
        public Visibility IsEditMode { get; set; }

        private bool _isAddMode;

        public PropertyWindow(JsonViewModel jsonViewModel, bool isAddMode)
        {
            InitializeComponent();

            var settings = App.Current.Services.GetRequiredService<SettingsService>().Settings;

            AppWindow.Resize(new(450, 300));

            OverlappedPresenter overlappedPresenter = OverlappedPresenter.Create();
            overlappedPresenter.IsAlwaysOnTop = true;

            AppWindow.SetPresenter(overlappedPresenter);

            PropertyViewModel = new PropertyViewModel();
            _isAddMode = isAddMode;
            IsAddMode = isAddMode ? Visibility.Collapsed : Visibility.Visible;
            IsEditMode = isAddMode ? Visibility.Visible : Visibility.Collapsed;

            JsonViewModel = jsonViewModel;
            JsonTypes = Enum.GetValues<JsonType>();

            if (isAddMode)
            {
                Title = "Edit property";
                jsonViewModel.SelectionChanged += (selectedProperty) =>
                {
                    PropertyViewModel.Property = selectedProperty;
                };

                AppWindow.Move(new(settings.EditX, settings.EditY));
            }
            else
            {
                Title = "Add new property";
                PropertyViewModel.Property = JsonViewModel.Property;
                AppWindow.Move(new(settings.AddX, settings.AddY));
            }
        }

        public void SavePosition(Settings settings)
        {
            if (_isAddMode)
            {
                settings.AddX = AppWindow.Position.X;
                settings.AddY = AppWindow.Position.Y;
            }
            else
            {
                settings.EditX = AppWindow.Position.X;
                settings.EditY = AppWindow.Position.Y;
            }
        }
    }
}
