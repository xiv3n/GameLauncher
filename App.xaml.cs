using Avalonia;
using Avalonia.Markup.Xaml;

namespace GameLauncherExperimental
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}