using HomeOffice.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeOffice
{
    public class MainController
    {
        private bool Running = true;
        private readonly MainModel model;
        private readonly string ProgramName;

        public MainController(MainModel model, string ProgramName)
        {
            this.model = model;
            this.ProgramName = ProgramName;

            //Main-Thread initialisieren
            InitMainThread();
        }

        private void InitMainThread()
        {
            Thread th = new Thread(new ThreadStart(delegate
            {
                //Zum Start beide Stati auf Connection setzen
                model.ServerState = MainModel.EServerState.Connecting;
                model.ComputerState = MainModel.EComputerState.Connecting;

                while (Running)
                {
                    //Regelmäßig aktualisieren
                    Thread.Sleep(500);
                    CheckServerState();
                    Thread.Sleep(500);
                    CheckComputerState();
                }
            }));

            //Thread starten
            th.Start();
        }

        public List<string> GetRdpButtons()
        {
            List<string> li = new List<string>();

            try
            {
                DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
                foreach (FileInfo fi in di.GetFiles())
                    if (fi.Extension.ToLower().Contains("rdp"))
                        li.Add(fi.Name);

                return li;
            }
            catch { return li; }
        }

        private void CheckServerState()
        {
            try
            {
                //Durch Ping überprüfen, ob Server Online ist
                PingReply pingReply = new Ping().Send(model.ServerIpAddress);

                //Status dem entsprechend anpassen
                if (pingReply.Status == IPStatus.Success)
                    model.ServerState = MainModel.EServerState.Online;
                else model.ServerState = MainModel.EServerState.Offline;
            }
            //Fehler ausgaben
            catch { model.ServerState = MainModel.EServerState.Error; }
        }

        private void CheckComputerState()
        {
            //Vor dem Computer-Status zunächst den Server-Status prüfen
            switch (model.ServerState)
            {
                //Server verbindet -> Computer gleichsetzen
                case MainModel.EServerState.Connecting:
                    model.ComputerState = MainModel.EComputerState.Connecting;
                    return;
                //Server Online -> weiter mit unten
                case MainModel.EServerState.Online:
                    break;
                //Computer Offline, da Server nicht erreichbar
                default:
                    model.ComputerState = MainModel.EComputerState.Offline;
                    return;
            }

            try
            {
                //Computer-Status durch Ping ermitteln
                PingReply pingReply = new Ping().Send(model.ComputerIpAddress);

                //Computer Online
                if (pingReply.Status == IPStatus.Success)
                {
                    //Wartezeit, wenn PC nach dem Aufwecken Online ist
                    if (model.ComputerState == MainModel.EComputerState.WakeUp)
                        Thread.Sleep(model.DelayBeforeRdpConnect * 1000);

                    //Online-Status, wenn noch keine RDP-Verbindung aufgebaut
                    if (model.ComputerState != MainModel.EComputerState.RdpStarted)
                        model.ComputerState = MainModel.EComputerState.Online;

                    //Evtl. RDP-Verbindung starten
                    if (model.AutoJobWakeUpAndConnect)
                        ConnectRDP();
                }
                //Computer offline
                else
                {
                    //AutoWakeUp vorgewählt -> Computer aufwecken
                    if (model.ComputerState != MainModel.EComputerState.WakeUp)
                        if (model.AutoJobWakeUp || model.AutoJobWakeUpAndConnect)
                            WakeUpComputer();

                    //Andere Status als WakeUp -> Offline melden
                    if (model.ComputerState != MainModel.EComputerState.WakeUp)
                        model.ComputerState = MainModel.EComputerState.Offline;
                }
            }
            //Fehler ausgeben
            catch { model.ComputerState = MainModel.EComputerState.Error; }
        }

        public void ResetState()
        {
            //Alle Stati auf Connecting setzen
            model.AutoJobRdpName = string.Empty;
            model.AutoJob = MainModel.EAutoJob.None;
            model.ServerState = MainModel.EServerState.Connecting;
            model.ComputerState = MainModel.EComputerState.Connecting;
        }

        public void WakeUp()
        {
            model.AutoJobRdpName = string.Empty;
            model.AutoJob = model.AutoJob == MainModel.EAutoJob.WakeUp ? MainModel.EAutoJob.None : MainModel.EAutoJob.WakeUp;
            RefreshServerComputerState();
        }
        public void WakeUpAndConnect()
        {
            model.AutoJobRdpName = string.Empty;
            model.AutoJob = model.AutoJob == MainModel.EAutoJob.WakeUpAndConnect ? MainModel.EAutoJob.None : MainModel.EAutoJob.WakeUpAndConnect;
            RefreshServerComputerState();
        }
        public void WakeUpAndConnect(string RdpName)
        {
            if (model.AutoJobRdpName != RdpName)
            {
                model.AutoJobRdpName = RdpName;
                model.AutoJob = MainModel.EAutoJob.WakeUpAndConnect;
            }
            else if (model.AutoJob == MainModel.EAutoJob.WakeUpAndConnect)
            {
                model.AutoJobRdpName = string.Empty;
                model.AutoJob = MainModel.EAutoJob.None;
            }

            RefreshServerComputerState();
        }
        private void RefreshServerComputerState()
        {
            //model.ServerState = MainModel.EServerState.Connecting;
            //model.ComputerState = MainModel.EComputerState.Connecting;

            if (model.ComputerState == MainModel.EComputerState.RdpStarted)
                model.ComputerState = MainModel.EComputerState.Online;
            if (model.ComputerState == MainModel.EComputerState.WakeUp)
                model.ComputerState = MainModel.EComputerState.Connecting;
        }

        private void WakeUpComputer()
        {
            try
            {
                //Computer aufwecken
                if (WakeUpComputer(out string Result))
                {
                    if (model.AutoJob == MainModel.EAutoJob.WakeUp)
                        model.AutoJob = MainModel.EAutoJob.None;
                    model.ComputerState = MainModel.EComputerState.WakeUp;
                }
                else
                {
                    model.AutoJobRdpName = string.Empty;
                    model.AutoJob = MainModel.EAutoJob.None;
                    OnErrorMessage("Fehler beim Aufwecken des Computers: \n\n" + Result);
                }
            }
            catch (Exception ex)
            {
                model.AutoJobRdpName = string.Empty;
                model.AutoJob = MainModel.EAutoJob.None;
                OnErrorMessage("Fehler beim Aufwecken des Computers: \n\n" + ex.Message);
            }
        }

        private bool WakeUpComputer(out string Result)
        {
            if (model.UseDefaultPort)
                return new WakeOnLan.Client().WakeUpByServer(model.ServerIpAddress, model.ComputerMacAddress, ProgramName, out Result);
            else return new WakeOnLan.Client().WakeUpByServer(model.ServerIpAddress, model.ComputerMacAddress, ProgramName, model.ServerPort, out Result);
        }

        private void ConnectRDP()
        {
            try
            {
                //Neuen Status setzen
                string RdpName = model.AutoJobRdpName;
                model.AutoJobRdpName = string.Empty;
                model.AutoJob = MainModel.EAutoJob.None;
                model.ComputerState = MainModel.EComputerState.RdpStarted;

                //RDP-Verbindung aufbauen
                if (string.IsNullOrEmpty(RdpName))
                    Process.Start("mstsc.exe", "/v:" + model.ComputerIpAddress + " /f");
                else new Process() { StartInfo = new ProcessStartInfo(RdpName) { UseShellExecute = true } }.Start();

                //Evtl. Anwendung beenden
                if (model.CloseAfterConnect)
                    OnCloseProgramm();
            }
            catch (Exception ex) { OnErrorMessage("Fehler beim Aufbauen der RDP-Verbindung: \n\n" + ex.Message); }
        }

        public void StopRefreshing()
        {
            //Beenden
            Running = false;
            model.AutoJobRdpName = string.Empty;
            model.AutoJob = MainModel.EAutoJob.None;
        }

        public event EventHandler CloseProgramm;
        protected virtual void OnCloseProgramm()
        {
            CloseProgramm?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler<BoolEventArgs> ChangeCursor;
        protected virtual void OnChangeCursor(bool Wait)
        {
            ChangeCursor?.Invoke(this, new BoolEventArgs(Wait));
        }

        public event EventHandler<StringEventArgs> ErrorMessage;
        protected virtual void OnErrorMessage(string Message)
        {
            ErrorMessage?.Invoke(this, new StringEventArgs(Message));
        }
    }
}
