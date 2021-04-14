using HomeOffice.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeOffice
{
    public class SettingsController
    {
        private readonly SettingsModel model;

        public SettingsController(SettingsModel model)
        {
            this.model = model;

            LoadSettings();
        }

        private void LoadSettings()
        {
            model.ServerIpAddress = Settings.Default.ServerIpAddress;
            model.ServerPort = Settings.Default.ServerPort;
            model.UseDefaultPort = Settings.Default.UseDefaultPort;
            model.ComputerIpAddress = Settings.Default.ComputerIpAddress;
            model.ComputerMacAddress = Settings.Default.ComputerMacAddress;
            model.CloseAfterConnect = Settings.Default.CloseAfterConnect;
            model.DelayBeforeRdpConnect = Settings.Default.DelayBeforeRdpConnect;
        }

        public void SaveSettings()
        {
            Settings.Default.ServerIpAddress = model.ServerIpAddress;
            Settings.Default.ServerPort = model.ServerPort;
            Settings.Default.UseDefaultPort = model.UseDefaultPort;
            Settings.Default.ComputerIpAddress = model.ComputerIpAddress;
            Settings.Default.ComputerMacAddress = model.ComputerMacAddress;
            Settings.Default.CloseAfterConnect = model.CloseAfterConnect;
            Settings.Default.DelayBeforeRdpConnect = model.DelayBeforeRdpConnect;
            Settings.Default.Save();
        }

        public void OpenProgrammPath()
        {
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            Process.Start(di.FullName);
        }
    }
}
