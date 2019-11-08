using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Mini.Pages;

namespace Mini
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public Size _currentWindowSize;
        
        private LoginPage _loginPage;
        public LoginPage loginPage
        {
            get { return _loginPage; }
            set { _loginPage = value; }
        }
        
        private ActivityPage _activityPage;
        public ActivityPage activityPage
        {
            get { return _activityPage; }
            set { _activityPage = value; }
        }
        private FramePage _framePage;
        public FramePage framePage
        {
            get { return _framePage; }
            set { _framePage = value; }
        }
        private InformationPage _infoPage;
        public InformationPage infoPage
        {
            get { return _infoPage; }
            set { _infoPage = value; }
        }

        private double _aspectRatio;
        private bool? _adjustingHeight = null;

        internal enum SWP
        {
            NOMOVE = 0x0002
        }
        internal enum WM
        {
            WINDOWPOSCHANGING = 0x0046,
            EXITSIZEMOVE = 0x0232,
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct WINDOWPOS
        {
            public IntPtr hwnd;
            public IntPtr hwndInsertAfter;
            public int x;
            public int y;
            public int cx;
            public int cy;
            public int flags;
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetCursorPos(ref Win32Point pt);

        [StructLayout(LayoutKind.Sequential)]
        internal struct Win32Point
        {
            public Int32 X;
            public Int32 Y;
        };

        public static Point GetMousePosition() // mouse position relative to screen
        {
            Win32Point w32Mouse = new Win32Point();
            GetCursorPos(ref w32Mouse);
            return new Point(w32Mouse.X, w32Mouse.Y);
        }


        private void Window_SourceInitialized(object sender, EventArgs ea)
        {
            HwndSource hwndSource = (HwndSource)HwndSource.FromVisual((Window)sender);
            hwndSource.AddHook(DragHook);

            _aspectRatio = this.Width / this.Height;
        }

        private IntPtr DragHook(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            switch ((WM)msg)
            {
                case WM.WINDOWPOSCHANGING:
                    {
                        WINDOWPOS pos = (WINDOWPOS)Marshal.PtrToStructure(lParam, typeof(WINDOWPOS));

                        if ((pos.flags & (int)SWP.NOMOVE) != 0)
                            return IntPtr.Zero;

                        Window wnd = (Window)HwndSource.FromHwnd(hwnd).RootVisual;
                        if (wnd == null)
                            return IntPtr.Zero;

                        // determine what dimension is changed by detecting the mouse position relative to the 
                        // window bounds. if gripped in the corner, either will work.
                        if (!_adjustingHeight.HasValue)
                        {
                            Point p = GetMousePosition();

                            double diffWidth = Math.Min(Math.Abs(p.X - pos.x), Math.Abs(p.X - pos.x - pos.cx));
                            double diffHeight = Math.Min(Math.Abs(p.Y - pos.y), Math.Abs(p.Y - pos.y - pos.cy));

                            _adjustingHeight = diffHeight > diffWidth;
                        }

                        if (_adjustingHeight.Value)
                            pos.cy = (int)(pos.cx / _aspectRatio); // adjusting height to width change
                        else
                            pos.cx = (int)(pos.cy * _aspectRatio); // adjusting width to heigth change

                        Marshal.StructureToPtr(pos, lParam, true);
                        handled = true;
                    }
                    break;
                case WM.EXITSIZEMOVE:
                    _adjustingHeight = null; // reset adjustment dimension and detect again next time window is resized
                    break;
            }

            return IntPtr.Zero;
        }

        
        public MainWindow()
        {
            InitializeComponent();
            InitPage();
            this.SourceInitialized += Window_SourceInitialized;
        }
        public void InitPage()
        {
            loginPage = new LoginPage(this);
            activityPage = new ActivityPage(this);
            framePage = new FramePage(this);
            infoPage = new InformationPage(this);
            _currentWindowSize = new Size(this.Width, this.Height);
            mainFrame.Navigate(loginPage);
        }
        
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            switch (button.Name)
            {
                case "minimize_Btn":
                    this.WindowState = WindowState.Minimized;
                    
                    break;
                case "maximize_Btn":
                    if(button.Content.ToString().Equals("O"))
                    {
                        _currentWindowSize.Height = this.Height;
                        _currentWindowSize.Width = this.Width;
                        this.Width = 483;
                        this.Height = 800;
                        button.Content = "o";
                        //button.Tag = this.Resources["IsMaxState"];
                    }
                    else
                    {
                        this.Height = _currentWindowSize.Height;
                        this.Width = _currentWindowSize.Width;
                        button.Content = "O";
                        //button.Tag = this.Resources["IsNotMaxState"];
                    }
                    break;
                case "close_Btn":
                    this.Close();
                    break;
            }
        }

        private void Rectangle_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
