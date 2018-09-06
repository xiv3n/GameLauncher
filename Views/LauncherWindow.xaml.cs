using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GameLauncherExperimental.Views
{
    public class LauncherWindow : Window
    {
        public LauncherWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}