﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Popup
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         .  PositionCircles();
        }

        private void PositionCircles()
        {
            double circleLeft;
            double circleTop;

            if (popup1.PlacementRectangle.IsEmpty)
            {
                circleLeft = canvas1.Width / 2 - canvasEllipse.Width / 2;
                circleTop = canvas1.Height / 2 - canvasEllipse.Height / 2;
            }
            else
            {
                Rect rect = popup1.PlacementRectangle;

                circleLeft = rect.Left + rect.Width / 2 - canvasEllipse.Width / 2;
                circleTop = rect.Top + rect.Height / 2 - canvasEllipse.Height / 2;
            }

            Canvas.SetTop(canvasEllipse, circleTop);
            Canvas.SetLeft(canvasEllipse, circleLeft);

            circleLeft = popupCanvas.Width / 2 - popupEllipse.Width / 2;
            circleTop = popupCanvas.Height / 2 - popupEllipse.Height / 2;

            Canvas.SetTop(popupEllipse, circleTop);
            Canvas.SetRight(popupEllipse, circleLeft);
        }

    }
}


