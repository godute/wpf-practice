using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_mvvm.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int iNum;
        public int Number
        {
            get { return iNum; }
            set
            {
                int OldNum = iNum;
                iNum = value;

                OnPropertyChanged("Number");

                if(iNum > 0 && iNum <11)
                {
                    OnPropertyChanged("PlusEnable");
                    OnPropertyChanged("MinusEnable");
                    PageContents = string.Format("{0} 페이지를 보고 있어요. ", iNum);
                }
                else
                {
                    MessageBox.Show("1~10 페이지만 입력 가능합니다.");
                    iNum = OldNum;
                    OnPropertyChanged("Number");
                }
            }
        }

        public MainViewModel()
        {
            Number = 1;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged!= null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
        public bool MinusEnable
        {
            get { return Number > 1 ? true : false; }
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

        public bool PlusEnable
        {
            get { return Number < 10 ? true : false; }
        }
        private ICommand plusCommand;
        public ICommand PlusCommand
        {
            get { return (this.plusCommand) ?? (this.plusCommand = new DelegateCommand(Plus)); }
        }
        private void Plus()
        {
            Number++;
        }

        private string pageContent;
        public string PageContents
        {
            get { return pageContent; }
            set
            {
                pageContent = value;
                OnPropertyChanged("PageContents");
            }
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
        public void RaiseCanExecuteChanged()
        {
            if(this.CanExecuteChanged != null)
            {
                this.CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}
