using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_mvvm.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int iNuml;
        public int Number
        {
            get { return iNuml; }
            set
            {
                iNuml = value;
                OnPropertyChanged("Number");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged!= null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
        private ICommand minusCommand;
        public ICommand MinusCommand
        {
            get { return (this.minusCommand) ?? (this.minusCommand = new DelegateCommand(Minus)); }
        }
        private void Minus()
        {
            Number--;
        }
    }

    public class DelegateCommand : ICommand
    {
        private readonly Func<bool> canExecute;
        private readonly Action execute;

        public DelegateCommand(Action execute) : this(execute, null)
        {
        }
        
        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object o)
        {
            if(this.canExecute == null)
            {
                return true;
            }
            return this.canExecute();
        }
        public void Execute(object o)
        {
            this.execute();
        }
    }
}
