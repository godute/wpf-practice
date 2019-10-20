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

namespace WPF_Style
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button btnC = new Button();
            btnC.Style = Application.Current.Resources["btnCstyle"] as Style;

            Button btnA = new Button();
            btnA.Style = Application.Current.Resources["btnAstyle"] as Style;

            stp.Children.Add(btnC);
            stp.Children.Add(btnA);
        }
    }
}
