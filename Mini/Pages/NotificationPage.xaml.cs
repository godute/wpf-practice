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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mini.Pages
{
    /// <summary>
    /// NotificationPage.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 
    

    public class Item
    {
        private string _header;
        public string header
        {
            get { return _header; }
            set { _header = value; }
        }
        private string _body;
        public string body
        {
            get { return _body; }
            set { _body = value; }
        }
        public Item(string h, string b)
        {
            header = h;
            body = b;
        }
    }

    public partial class NotificationPage : Page
    {
        private List<Item> _items;
        public List<Item> items
        {
            get { return _items; }
            set { _items = value; }
        }
        private MainWindow mainWindow;
        public NotificationPage(MainWindow window)
        {
            ItemAdd();
            InitializeComponent();
            this.mainWindow = window;
        }
        public void ItemAdd()
        {
            items = new List<Item>();
            items.Add(new Item("header1", "body1"));
            items.Add(new Item("header2", "body2"));
            items.Add(new Item("header3", "body1"));
            items.Add(new Item("header4", "body2"));
            items.Add(new Item("header5", "body1"));
            items.Add(new Item("header6", "body1"));
            items.Add(new Item("header7", "body2"));
            items.Add(new Item("header8", "body2"));
            items.Add(new Item("header9", "body1"));
            items.Add(new Item("header10", "body2"));
            items.Add(new Item("header11", "body1"));
            items.Add(new Item("header12", "body2"));
            items.Add(new Item("header13", "body1"));
            items.Add(new Item("header14", "body1"));
            items.Add(new Item("header15", "body2"));
            items.Add(new Item("header16", "body2"));
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = new Storyboard();
            Point from = new Point(100, 100);
            Point to = new Point(100, 200);
            DoubleAnimation animY = null;
            DoubleAnimation animX = null;
        }
    }
}
