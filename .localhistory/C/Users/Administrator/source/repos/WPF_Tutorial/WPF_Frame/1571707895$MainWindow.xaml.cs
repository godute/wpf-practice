using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WPF_Frame
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            frame_content.Source = new Uri("MainPage.xaml", UriKind.Relative);
        }

        private void BtnOne_Click(object sender, RoutedEventArgs e)
        {
            frame_content.Source = new Uri("Page1.xaml", UriKind.Relative);
        }

        private void BtnTwo_Click(object sender, RoutedEventArgs e)
        {
            frame_content.Source = new Uri("Page2.xaml", UriKind.Relative);
        }
    }
}
