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
using Mini.Model;
using Mini.ViewModel;

namespace Mini.Pages
{
    /// <summary>
    /// MyListPage.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 
    
    public partial class MyListPage : Page
    {
        private MainWindow mainWindow;
        public MyListViewModel viewmodel;
        public MyListPage(MainWindow window)
        {
            this.mainWindow = window;
            InitializeComponent();
            viewmodel = new MyListViewModel(window);
            this.DataContext = viewmodel;

        }
        
    }
    
}
