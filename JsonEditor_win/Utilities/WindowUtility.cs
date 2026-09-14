using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;

namespace ModernDownladComics.Utilities
{
   public class WindowUtility
    {
        public static void Center(Window window)
        {
            DisplayArea displayArea = DisplayArea.GetFromWindowId(window.AppWindow.Id,
                DisplayAreaFallback.Primary);

            int x = displayArea.WorkArea.X + (displayArea.WorkArea.Width - 1750) / 2;
            int y = displayArea.WorkArea.Y + (displayArea.WorkArea.Height - 900) / 2;
            window.AppWindow.Move(new(x, y));
        }
    }
}
