using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPF_TrayIcon
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

        public System.Windows.Forms.NotifyIcon notify;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Windows.Forms.ContextMenu menu = new System.Windows.Forms.ContextMenu();
                notify = new System.Windows.Forms.NotifyIcon();
                notify.Icon = Properties.Resources.tray;
                notify.Visible = true;
                notify.ContextMenu = menu;
                notify.Text = "Test";

                notify.DoubleClick += Noyify_DoubleClick;
                System.Windows.Forms.MenuItem item1 = new System.Windows.Forms.MenuItem();
                menu.MenuItems.Add(item1);
                item1.Index = 0;
                item1.Text = "프로그램 종료";
                item1.Click += delegate (object click, EventArgs eClick)
                 {
                     System.Windows.Application.Current.Shutdown();
                     notify.Dispose();
                 };

                System.Windows.Forms.MenuItem item2 = new System.Windows.Forms.MenuItem();
                menu.MenuItems.Add(item2);
                item2.Index = 0;
                item2.Text = "프로그램 설정";
                item2.Click += delegate (object click, EventArgs eClick)
                {
                    this.Close();
                };
                this.Close();
            }
            catch(Exception ee)
            {

            }
        }

        private void Noyify_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = WindowState.Normal;
            this.Visibility = Visibility.Visible;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            base.OnClosing(e);
        }
    }
}
