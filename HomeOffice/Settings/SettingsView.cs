using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeOffice
{
    public partial class SettingsView : Form
    {
        private readonly SettingsModel model;
        private readonly SettingsController controller;

        public SettingsView()
        {
            InitializeComponent();

            //Model und Controller initialisieren
            model = new SettingsModel();
            controller = new SettingsController(model);

            //Icon für Einstellungen
            Icon = Properties.Resources.Settings;
        }

        private void SettingsView_Load(object sender, EventArgs e)
        {
            //Einstellungen binden
            tbServerIpAddress.DataBindings.Add(nameof(Text), model, nameof(SettingsModel.ServerIpAddress));
            nudServerPort.DataBindings.Add(nameof(NumericUpDown.Value), model, nameof(SettingsModel.ServerPort));
            nudServerPort.DataBindings.Add(nameof(Enabled), model, nameof(SettingsModel.UseOwnPort), false, DataSourceUpdateMode.OnPropertyChanged);
            lblServerPort.DataBindings.Add(nameof(Enabled), model, nameof(SettingsModel.UseOwnPort), false, DataSourceUpdateMode.OnPropertyChanged);
            cbUseDefaultPort.DataBindings.Add(nameof(CheckBox.Checked), model, nameof(SettingsModel.UseDefaultPort), false, DataSourceUpdateMode.OnPropertyChanged);
            tbComputerIpAddress.DataBindings.Add(nameof(Text), model, nameof(SettingsModel.ComputerIpAddress));
            tbComputerMacAddress.DataBindings.Add(nameof(Text), model, nameof(SettingsModel.ComputerMacAddress));
            nudDelayConnect.DataBindings.Add(nameof(NumericUpDown.Value), model, nameof(SettingsModel.DelayBeforeRdpConnect));
            cbCloseAfterConnect.DataBindings.Add(nameof(CheckBox.Checked), model, nameof(SettingsModel.CloseAfterConnect));

            lkLabelOpenProgPath.LinkClicked += (s, ea) =>
              {
                  try { SettingsController.OpenProgrammPath(); }
                  catch (Exception ex) { MessageBox.Show("Das Programmverzeichniss konnte nicht geöffnet werden:\n\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
              };
        }

        private void SettingsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Nur bei Dialog-Result OK wird gespeichert
            if (DialogResult == DialogResult.OK)
                controller.SaveSettings();
        }
    }
}
