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
                return ServerState switch
                {
                    EServerState.Error => Resources.Red.ToBitmap(),
                    EServerState.Online => Resources.Green.ToBitmap(),
                    EServerState.Offline => Resources.Yellow.ToBitmap(),
                    EServerState.Connecting => Resources.Blue.ToBitmap(),
                    _ => Resources.Blue.ToBitmap(),
                };
            }
        }
        public string ServerInfo
        {
            get
            {
                return ServerState switch
                {
                    EServerState.Error => "Überprüfen Sie die Server-Einstellungen",
                    EServerState.Online => "Server ist Online",
                    EServerState.Offline => "Server ist nicht erreichbar",
                    EServerState.Connecting => "Verbinde mit Server",
                    _ => string.Empty,
                };
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
                return ComputerState switch
                {
                    EComputerState.Error => Resources.Red.ToBitmap(),
                    EComputerState.Online => Resources.Green.ToBitmap(),
                    EComputerState.Offline => Resources.Yellow.ToBitmap(),
                    EComputerState.Connecting => Resources.Blue.ToBitmap(),
                    EComputerState.WakeUp => Resources.Wecker,
                    EComputerState.RdpStarted => Resources.RemoteControl,
                    _ => Resources.Blue.ToBitmap(),
                };
            }
        }
        public string ComputerInfo
        {
            get
            {
                return ComputerState switch
                {
                    EComputerState.Error => "Überprüfen Sie die Computer-Einstellungen",
                    EComputerState.Online => "Computer ist Online",
                    EComputerState.Offline => "Computer ist nicht erreichbar",
                    EComputerState.Connecting => "Verbinde mit Computer",
                    EComputerState.WakeUp => "Der Computer wurde aufgeweckt",
                    EComputerState.RdpStarted => "Remote Desktop wurde gestartet",
                    _ => string.Empty,
                };
            }
        }

        public static string ServerIpAddress { get { return Settings.Default.ServerIpAddress; } }
        public static int ServerPort { get { return Settings.Default.ServerPort; } }
        public static bool UseDefaultPort { get { return Settings.Default.UseDefaultPort; } }
        public static string ComputerIpAddress { get { return Settings.Default.ComputerIpAddress; } }
        public static string ComputerMacAddress { get { return Settings.Default.ComputerMacAddress; } }
        public static bool CloseAfterConnect { get { return Settings.Default.CloseAfterConnect; } }
        public static int DelayBeforeRdpConnect { get { return Settings.Default.DelayBeforeRdpConnect; } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(object PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName.ToString()));
        }
    }
}
