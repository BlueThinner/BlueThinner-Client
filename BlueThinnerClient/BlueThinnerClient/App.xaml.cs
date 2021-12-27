global using System.Windows.Threading;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace BlueThinnerClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void UnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            try
            {
                //Handle code, currently nothing.
                return;
                e.Handled = true;
            }
            catch
            {
                e.Handled = false;
            }
        }
    }
}
