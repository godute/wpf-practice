using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini.Model;

namespace Mini.ViewModel
{
    public class ActivityViewModel :INotifyPropertyChanged
    {
        private MainWindow mainWindow;
        public Dictionary<string, List<Schedule>> Ori_Dicts;
        private Dictionary<string, List<Schedule>> _dicts;
        public Dictionary<string, List<Schedule>> Dicts
        {
            get { return _dicts; }
            set
            {
                _dicts = value;
                OnPropertyChanged("Dicts");
            }
        }
        public ActivityViewModel(MainWindow window)
        {
            this.mainWindow = window;
            Dicts = new Dictionary<string, List<Schedule>>();
            Ori_Dicts = new Dictionary<string, List<Schedule>>();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
       
    }
}
