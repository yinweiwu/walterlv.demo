﻿using System.Windows;

namespace Walterlv.Demo
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var window = new MainWindow();
            window.Show();

            base.OnStartup(e);
        }
    }
}