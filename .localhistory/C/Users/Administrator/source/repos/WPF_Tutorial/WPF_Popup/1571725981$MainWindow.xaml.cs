using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

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
            popup1.CustomPopupPlacementCallback =
                new CustomPopupPlacementCallback(placePopup);
        }
        private void onClick(object sender, RoutedEventArgs args)
        {
            popup1.IsOpen = !popup1.IsOpen;

        }

        //<SnippetDelegateInstance>
        public CustomPopupPlacement[] placePopup(Size popupSize,
                                                   Size targetSize,
                                                   Point offset)
        {


            //var height = Screen.PrimaryScreen.- System.Windows.SystemParameters.WorkArea.Height;
            //var width = System.Windows.SystemParameters.WorkArea.Width;
            var width = Screen.PrimaryScreen.WorkingArea.Width - _text.Width;
            var height = Screen.PrimaryScreen.WorkingArea.Height - _text.Height;
            Debug.WriteLine("Width = " + Screen.PrimaryScreen.WorkingArea.Width + " - " + _text.Width + "=" +width);
            Debug.WriteLine("Height = " + Screen.PrimaryScreen.WorkingArea.Height + " - " + _text.Height + "=" + height);
            CustomPopupPlacement placement1 =
               new CustomPopupPlacement(new Point(width, height), PopupPrimaryAxis.None);

//            CustomPopupPlacement placement2 =
 //               new CustomPopupPlacement(new Point(2000, 20), PopupPrimaryAxis.Horizontal);

            CustomPopupPlacement[] ttplaces =
                    new CustomPopupPlacement[] { placement1 };
            return ttplaces;
        }
        //</SnippetDelegateInstance>


    }
}


