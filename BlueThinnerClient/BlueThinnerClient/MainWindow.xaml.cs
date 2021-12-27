using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlueThinnerClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ToolsWindow toolsWindow = new();
            DefinitionLBL.Content = "Sending you to Tools...";
            _ = toolsWindow.ShowDialog();
            DefinitionLBL.Content = "Welcome back.";
            Task.Delay(5000).GetAwaiter().GetResult();
            DefinitionLBL.Content = "Main";
        }

        public static async Task StartWindow(Window target)
        {
            var opened = target.ShowDialog();
            if (opened ?? false)
            {

            }
            else if (!opened ?? true)
            {

            }
        }
        
    }
}
