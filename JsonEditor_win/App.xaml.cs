using System;
using JsonEditor_win.Models.ViewModels;
using JsonEditor_win.Services;
using JsonEditor_win.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace JsonEditor_win
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        public ServiceProvider Services { get; private set; }
        private Window? _window;
        private PropertyWindow? _addPropertyWindow;
        private PropertyWindow? _editPropertyWindow;
        private PatternWindow? _patternWindow;

        public new static App Current => (App)Application.Current;

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            InitializeComponent();
            Services = ConfigureService();
        }

        private static ServiceProvider ConfigureService()
        {
            ServiceCollection services = new();
            AddServices(services);
            AddViewModels(services);
            AddWindows(services);

            return services.BuildServiceProvider();
        }



        private static void AddServices(ServiceCollection services)
        {
            services.AddSingleton<SettingsService>();
        }

        private static void AddViewModels(ServiceCollection services)
        {
            services.AddSingleton<JsonViewModel>();
        }

        private static void AddWindows(ServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddSingleton<PropertyWindow>();
        }

        /// <summary>
        /// Invoked when the application is launched.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            _window = Services.GetRequiredService<MainWindow>();
            _addPropertyWindow = new PropertyWindow(((MainWindow)_window).ViewModel, true);
            _editPropertyWindow = new PropertyWindow(((MainWindow)_window).ViewModel, false);
            _patternWindow = new PatternWindow();


            _window.Closed += (_, _) =>
            {
                var settingsService = Services.GetRequiredService<SettingsService>();

                _addPropertyWindow.SavePosition(settingsService.Settings);
                _editPropertyWindow.SavePosition(settingsService.Settings);
                _patternWindow.SavePosition(settingsService.Settings);
                settingsService.SaveSettings();

                _addPropertyWindow.Close();
                _editPropertyWindow.Close();
                _patternWindow.Close();
            };

            _window.Activate();
            _addPropertyWindow.Activate();
            _editPropertyWindow.Activate();
            _patternWindow.Activate();
        }
    }
}
