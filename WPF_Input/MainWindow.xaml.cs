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

namespace WPF_Input
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
        private void OnButtonKeyDown(object sender, KeyEventArgs e)
        {
            Button source = e.Source as Button;
            if(source != null)
            {
                if(e.Key == Key.Left)
                {
                    source.Background = Brushes.LemonChiffon;
                }
                else
                {
                    source.Background = Brushes.AliceBlue;
                }
            }
        }
        private void OnMouseExampleMouseEnter(object sender, MouseEventArgs e)
        {
            Button source = e.Source as Button;
            if(source != null)
            {
                source.Background = Brushes.Red;
            }
        }
        private void OnMouseExampleMouseLeave(object sender, MouseEventArgs e)
        {
            Button source = e.Source as Button;
            if(source !=null)
            {
                source.Background = Brushes.AliceBlue;
            }
        }

        private void OnTextInputButtonClick(object sender, RoutedEventArgs e)
        {
            handle();
            e.Handled = true;
        }

        private void OnTextInputKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.O && Keyboard.Modifiers == ModifierKeys.Control)
            {
                handle();
                e.Handled = true;
            }
        }
        public void handle()
        {
            MessageBox.Show("Pretend this opens a file");
        }
    }
    
}
