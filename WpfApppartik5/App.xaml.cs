using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfNotes;

namespace WpfApppartik5
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainViewModel viewModel = new MainViewModel();

            MainWindow mainWindow = new MainWindow();

            mainWindow.DataContext = viewModel;

            mainWindow.Show();
        }
    }
}
