using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using Avalonia.Markup.Xaml.Data;
using ReactiveUI;

namespace GameLauncherExperimental.ViewModels
{
    public class LauncherWindowViewModel : ViewModelBase
    {
        private string _launchButtonName = "Launch";
        public string LaunchButtonName => _launchButtonName;
        private int _progressBarValue = 10;
        public int ProgressBarValue => _progressBarValue;
        
        public LauncherWindowViewModel()
        {
            LaunchButton = ReactiveCommand.Create(LaunchButtonPressed);
        }
        public ReactiveCommand<Unit, Unit> LaunchButton { get; }
        void LaunchButtonPressed()
        {
            _launchButtonName = "Launching..";
            _progressBarValue += 10;
            Console.WriteLine(ProgressBarValue);

        }
    }
}
