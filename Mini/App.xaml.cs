using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Mini
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        private MainWindow mainWindow;
        private Popup popup;
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            mainWindow = new MainWindow();
            mainWindow.Show();
        }
        private void Button_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (popup != null && popup.IsOpen)
            {
                popup.IsOpen = false;
                return;
            }
            popup = new Popup();
            Grid grid = new Grid();
            Border border = new Border();
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "pop up";

            var bc = new BrushConverter();
            border.Background = new SolidColorBrush(Colors.White);
            border.BorderBrush = new SolidColorBrush(Colors.Black);
            border.BorderThickness = new Thickness(2);
            border.Child = textBlock;
            border.Width = mainWindow.Width;
            border.Height = mainWindow.Height;
            popup.Child = border;

            popup.PlacementTarget = this.mainWindow;
            popup.Placement = PlacementMode.Right;
            popup.IsOpen = true;
        }
    }
}
