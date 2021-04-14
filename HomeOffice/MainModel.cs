using HomeOffice.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeOffice
{
    public class MainModel : INotifyPropertyChanged
    {
        public enum EAutoJob { None, WakeUp, WakeUpAndConnect }
        private EAutoJob autoJob = EAutoJob.None;
        public EAutoJob AutoJob
        {
            get { return autoJob; }
            set { autoJob = value; OnPropertyChanged(AutoJob); }
        }
        public string AutoJobRdpName { get; internal set; }
        public bool AutoJobWakeUp { get { return autoJob == EAutoJob.WakeUp; } }
        public bool AutoJobWakeUpAndConnect { get { return autoJob == EAutoJob.WakeUpAndConnect; } }
        public bool AutoJobWakeUpPossible { get { return ComputerState != EComputerState.Online && ComputerState != EComputerState.RdpStarted; } }

        public enum EServerState { Error, Online, Offline, Connecting }
        private EServerState serverState = EServerState.Offline;
        public EServerState ServerState
        {
            get { return serverState; }
            set { serverState = value; OnPropertyChanged(ServerState); }
        }
        public Image ServerImage
        {
            get
            {
                switch (ServerState)
                {
                    case EServerState.Error: return Resources.Red.ToBitmap();
                    case EServerState.Online: return Resources.Green.ToBitmap();
                    case EServerState.Offline: return Resources.Yellow.ToBitmap();
                    case EServerState.Connecting: return Resources.Blue.ToBitmap();
                }

                return Resources.Blue.ToBitmap();
            }
        }
        public string ServerInfo
        {
            get
            {
                switch (ServerState)
                {
                    case EServerState.Error: return "Überprüfen Sie die Server-Einstellungen";
                    case EServerState.Online: return "Server ist Online";
                    case EServerState.Offline: return "Server ist nicht erreichbar";
                    case EServerState.Connecting: return "Verbinde mit Server";
                }

                return string.Empty;
            }
        }

        public enum EComputerState { Error, Online, Offline, Connecting, WakeUp, RdpStarted }
        private EComputerState computerState = EComputerState.Offline;
        public EComputerState ComputerState
        {
            get { return computerState; }
            set { computerState = value; OnPropertyChanged(ComputerState); }
        }
        public Image ComputerImage
        {
            get
            {
                switch (ComputerState)
                {
                    case EComputerState.Error: return Resources.Red.ToBitmap();
                    case EComputerState.Online: return Resources.Green.ToBitmap();
                    case EComputerState.Offline: return Resources.Yellow.ToBitmap();
                    case EComputerState.Connecting: return Resources.Blue.ToBitmap();
                    case EComputerState.WakeUp: return Resources.Wecker;
                    case EComputerState.RdpStarted: return Resources.RemoteControl;
                }

                return Resources.Blue.ToBitmap();
            }
        }
        public string ComputerInfo
        {
            get
            {
                switch (ComputerState)
                {
                    case EComputerState.Error: return "Überprüfen Sie die Computer-Einstellungen";
                    case EComputerState.Online: return "Computer ist Online";
                    case EComputerState.Offline: return "Computer ist nicht erreichbar";
                    case EComputerState.Connecting: return "Verbinde mit Computer";
                    case EComputerState.WakeUp: return "Der Computer wurde aufgeweckt";
                    case EComputerState.RdpStarted: return "Remote Desktop wurde gestartet";
                }

                return string.Empty;
            }
        }

        public string ServerIpAddress { get { return Settings.Default.ServerIpAddress; } }
        public int ServerPort { get { return Settings.Default.ServerPort; } }
        public bool UseDefaultPort { get { return Settings.Default.UseDefaultPort; } }
        public string ComputerIpAddress { get { return Settings.Default.ComputerIpAddress; } }
        public string ComputerMacAddress { get { return Settings.Default.ComputerMacAddress; } }
        public bool CloseAfterConnect { get { return Settings.Default.CloseAfterConnect; } }
        public int DelayBeforeRdpConnect { get { return Settings.Default.DelayBeforeRdpConnect; } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(object PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName.ToString()));
        }
    }
}
