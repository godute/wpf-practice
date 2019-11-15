using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini.Model
{
    public class Schedule
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private bool _isLocal;
        public bool IsLocal
        {
            get { return _isLocal; }
            set { _isLocal = value; }
        }
    }
}
