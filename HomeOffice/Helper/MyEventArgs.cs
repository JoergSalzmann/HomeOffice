using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeOffice
{
    public class BoolEventArgs : EventArgs
    {
        public bool Value { get; private set; }

        public BoolEventArgs(bool Value)
        {
            this.Value = Value;
        }
    }

    public class StringEventArgs:EventArgs
    {
        public string Value { get; private set; }

        public StringEventArgs(string Value)
        {
            this.Value = Value;
        }
    }
}
