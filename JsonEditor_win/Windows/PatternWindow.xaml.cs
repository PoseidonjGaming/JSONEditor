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
    public sealed partial class PatternWindow : Window
    {
        public PatternViewModel PatternViewModel { get; set; }
        public JsonViewModel JsonViewModel { get; set; }
        public PatternWindow()
        {
            InitializeComponent();

            JsonViewModel = App.Current.Services.GetRequiredService<JsonViewModel>();

            var settings = App.Current.Services.GetRequiredService<SettingsService>();
            AppWindow.MoveAndResize(new(settings.Settings.PatternX, settings.Settings.PatternY,
                450, 400));

            OverlappedPresenter overlappedPresenter = OverlappedPresenter.Create();
            overlappedPresenter.IsAlwaysOnTop = true;
            AppWindow.SetPresenter(overlappedPresenter);

            PatternViewModel = new PatternViewModel();
        }

        public void SavePosition(Settings settings)
        {
            settings.PatternX = AppWindow.Position.X;
            settings.PatternY = AppWindow.Position.Y;
        }
    }
}
