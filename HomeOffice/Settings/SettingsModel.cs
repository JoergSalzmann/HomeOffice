using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeOffice
{
    public class SettingsModel
    {
        public string ServerIpAddress { get; set; }
        public int ServerPort { get; set; }
        public bool UseDefaultPort { get; set; }
        public bool UseOwnPort { get { return !UseDefaultPort; } }
        public string ComputerIpAddress { get; set; }
        public string ComputerMacAddress { get; set; }
        public bool CloseAfterConnect { get; set; }
        public int DelayBeforeRdpConnect { get; set; }
    }
}
