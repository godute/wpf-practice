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

        private void FramePageBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            switch(button.Name)
            {
                case "playBtn":
                    listFrame.Navigate(this.mainWindow.activityPage);
                    break;
                case "listBtn":
                    listFrame.Navigate(this.mainWindow.listPage);
                    break;
                case "notiBtn":
                    listFrame.Navigate(this.mainWindow.notiPage);
                    break;
                case "setBtn":
                    break;
                case "infoBtn":
                    listFrame.Navigate(this.mainWindow.infoPage);
                    break;

                case "studioBtn":
                    break;
                case "workcenterBtn":
                    break;
                case "offBtn":
                    break;
            }
        }
    }
}
