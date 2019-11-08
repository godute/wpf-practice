using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Mini.Pages
{
    /// <summary>
    /// LoginPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginPage : Page
    {
        private MainWindow mainWindow;
        public LoginPage(MainWindow window)
        {
            InitializeComponent();
            this.mainWindow = window;
        }

        
        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            if(idText.Text.Equals(string.Empty))
            {
                errorText.Visibility = Visibility.Visible;
            }
            else
            {
                errorText.Visibility = Visibility.Collapsed;
                mainWindow.mainFrame.Navigate(mainWindow.framePage);
            }
        }
    }
}
