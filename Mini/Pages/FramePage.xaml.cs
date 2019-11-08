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

namespace Mini.Pages
{
    /// <summary>
    /// FramePage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FramePage : Page
    {
        private MainWindow mainWindow;
        public FramePage(MainWindow window)
        {
            InitializeComponent();
            this.mainWindow = window;
            listFrame.Navigate(this.mainWindow.activityPage);
        }

        private void InfoBtn_Click(object sender, RoutedEventArgs e)
        {
            listFrame.Navigate(this.mainWindow.infoPage);
            Panel.SetZIndex(this.mainWindow.infoPage, 10);
        }
    }
}
