using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeOffice
{
    public partial class MainView : Form
    {
        private readonly MainModel model;
        private readonly MainController controller;

        public MainView()
        {
            InitializeComponent();

            //Titel und Version
            Version v = Assembly.GetExecutingAssembly().GetName().Version;
            Text = "HomeOffice " + v.Major + "." + v.Minor;// + " RC 1";
            Icon = Properties.Resources.Home;

            //Model und Controller initialisieren
            model = new MainModel();
            controller = new MainController(model, Text);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            //Dialog für Einstellungen
            rbSettings.Click += (s, ea) => { if (new SettingsView().ShowDialog() == DialogResult.OK) controller.ResetState(); };

            //Info zur Anwendung
            rbInfo.Click += (s, ea) => { MessageBox.Show(Text + "\n\nVerwendet: WakeOnLan 2.2-beta\n\n\n© 2020-2021 - J. Salzmann", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); };

            //Cursor
            controller.ChangeCursor += (s, ea) => { Invoke(new MethodInvoker(delegate { Cursor = ea.Value ? Cursors.WaitCursor : Cursors.Default; })); };

            //Fehlermeldungen
            controller.ErrorMessage += (s, ea) => { Invoke(new MethodInvoker(delegate { MessageBox.Show(ea.Value, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning); })); };

            //Anwendung beenden
            controller.CloseProgramm += (s, ea) => { Invoke(new MethodInvoker(delegate { Close(); })); };

            //Buttons
            rbWakeUp.Click += (s, ea) => controller.WakeUp();
            rbWuConnect.Click += (s, ea) => controller.WakeUpAndConnect();

            //Dynamische RDP-Buttons
            AddRdpButtons(controller.GetRdpButtons());

            //Aktualisierungen
            model.PropertyChanged += (s, ea) => { RefreshState(); };
            RefreshState();
        }

        private void AddRdpButtons(List<string> RdpNames)
        {
            int NewWidth = RdpNames.Count * 100 + 300;
            if (NewWidth < 500) NewWidth = 500;
            if (NewWidth > 900)
            {
                foreach (RibbonButton btn in rpSettings.Items)
                    btn.MaxSizeMode = RibbonElementSizeMode.Medium;
                NewWidth = 900;
            }
            Width = NewWidth;

            foreach (string s in RdpNames)
                AddRdpButton(s);
        }

        private void AddRdpButton(string RdpName)
        {
            //Standard-Verbindung ausblenden
            rbWuConnect.Visible = false;

            //Neuen Button erstellen und hinzufügen
            RibbonButton btn = new RibbonButton
            {
                Name = RdpName,
                Text = RdpName.Split('.')[0],
                Image = Properties.Resources.RemoteControl,
                SmallImage = Properties.Resources.RemoteControl_16,
                MinimumSize = new Size(100, 0),
            };

            //WakeUp and Connect für den aktuellen Buttons
            btn.Click += (s, ea) => controller.WakeUpAndConnect(RdpName);

            //Button der Auflistung hinzufügen und neue Window-Breite berechnen
            rpAutoJobs.Items.Add(btn);
        }

        private void RefreshState()
        {
            try
            {
                Invoke(new MethodInvoker(delegate
                {
                    //Gucken ob einer der dynamischen Buttons Checked
                    foreach (RibbonButton btn in rpAutoJobs.Items)
                        if (btn.Name == model.AutoJobRdpName)
                            btn.Checked = true;
                        else btn.Checked = false;

                    //Standard-Buttons
                    rbWakeUp.Enabled = model.AutoJobWakeUpPossible;
                    rbWakeUp.Checked = model.AutoJobWakeUp;
                    rbWuConnect.Checked = model.AutoJobWakeUpAndConnect;

                    //Image und Infotext
                    pbServer.Image = model.ServerImage;
                    lblServer.Text = model.ServerInfo;
                    pbComputer.Image = model.ComputerImage;
                    lblComputer.Text = model.ComputerInfo;
                }));
            }
            catch { }
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.StopRefreshing();
        }
    }
}
