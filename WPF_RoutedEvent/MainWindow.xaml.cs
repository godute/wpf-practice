﻿using System;
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

namespace WPF_RoutedEvent
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly RoutedEvent TapEvent = EventManager.RegisterRoutedEvent(
            "Tap", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MyButtonSimple));
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CommonClickHandler(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            switch(feSource.Name)
            {
                case "YesButton":
                    break;
                case "NoButton":
                    break;
                case "CancelButton":
                    break;
            }
            e.Handled = true;
        }
    }
}
