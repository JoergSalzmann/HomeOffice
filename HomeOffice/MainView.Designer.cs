namespace HomeOffice
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbServer = new System.Windows.Forms.PictureBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.pbComputer = new System.Windows.Forms.PictureBox();
            this.lblComputer = new System.Windows.Forms.Label();
            this.ribbonMain = new System.Windows.Forms.Ribbon();
            this.rtMain = new System.Windows.Forms.RibbonTab();
            this.rpSettings = new System.Windows.Forms.RibbonPanel();
            this.rbSettings = new System.Windows.Forms.RibbonButton();
            this.rbInfo = new System.Windows.Forms.RibbonButton();
            this.rpAutoJobs = new System.Windows.Forms.RibbonPanel();
            this.rbWakeUp = new System.Windows.Forms.RibbonButton();
            this.rbWuConnect = new System.Windows.Forms.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbServer
            // 
            this.pbServer.Location = new System.Drawing.Point(12, 88);
            this.pbServer.Name = "pbServer";
            this.pbServer.Size = new System.Drawing.Size(64, 64);
            this.pbServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbServer.TabIndex = 3;
            this.pbServer.TabStop = false;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(82, 110);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(57, 20);
            this.lblServer.TabIndex = 4;
            this.lblServer.Text = "label1";
            // 
            // pbComputer
            // 
            this.pbComputer.Location = new System.Drawing.Point(12, 148);
            this.pbComputer.Name = "pbComputer";
            this.pbComputer.Size = new System.Drawing.Size(64, 64);
            this.pbComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbComputer.TabIndex = 5;
            this.pbComputer.TabStop = false;
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(82, 170);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(57, 20);
            this.lblComputer.TabIndex = 7;
            this.lblComputer.Text = "label1";
            // 
            // ribbonMain
            // 
            this.ribbonMain.CaptionBarVisible = false;
            this.ribbonMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbonMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonMain.Minimized = false;
            this.ribbonMain.Name = "ribbonMain";
            // 
            // 
            // 
            this.ribbonMain.OrbDropDown.BorderRoundness = 8;
            this.ribbonMain.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbonMain.OrbDropDown.Name = "";
            this.ribbonMain.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbonMain.OrbDropDown.TabIndex = 0;
            this.ribbonMain.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbonMain.OrbVisible = false;
            this.ribbonMain.PanelCaptionHeight = 0;
            // 
            // 
            // 
            this.ribbonMain.QuickAccessToolbar.Visible = false;
            this.ribbonMain.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbonMain.Size = new System.Drawing.Size(684, 75);
            this.ribbonMain.TabIndex = 11;
            this.ribbonMain.Tabs.Add(this.rtMain);
            this.ribbonMain.TabsMargin = new System.Windows.Forms.Padding(6, 2, 20, 0);
            this.ribbonMain.TabSpacing = 3;
            this.ribbonMain.Text = "ribbon1";
            // 
            // rtMain
            // 
            this.rtMain.Name = "rtMain";
            this.rtMain.Panels.Add(this.rpSettings);
            this.rtMain.Panels.Add(this.rpAutoJobs);
            this.rtMain.Text = "";
            // 
            // rpSettings
            // 
            this.rpSettings.ButtonMoreEnabled = false;
            this.rpSettings.ButtonMoreVisible = false;
            this.rpSettings.Items.Add(this.rbSettings);
            this.rpSettings.Items.Add(this.rbInfo);
            this.rpSettings.Items.Add(this.rbWakeUp);
            this.rpSettings.Name = "rpSettings";
            this.rpSettings.Text = "";
            // 
            // rbSettings
            // 
            this.rbSettings.Image = global::HomeOffice.Properties.Resources.Settings1;
            this.rbSettings.LargeImage = global::HomeOffice.Properties.Resources.Settings1;
            this.rbSettings.Name = "rbSettings";
            this.rbSettings.SmallImage = global::HomeOffice.Properties.Resources.Settings_16;
            this.rbSettings.Text = "Einstellungen";
            // 
            // rbInfo
            // 
            this.rbInfo.Image = global::HomeOffice.Properties.Resources.Info;
            this.rbInfo.LargeImage = global::HomeOffice.Properties.Resources.Info;
            this.rbInfo.Name = "rbInfo";
            this.rbInfo.SmallImage = global::HomeOffice.Properties.Resources.Info_16;
            this.rbInfo.Text = "Über HomeOffice";
            // 
            // rpAutoJobs
            // 
            this.rpAutoJobs.ButtonMoreEnabled = false;
            this.rpAutoJobs.ButtonMoreVisible = false;
            this.rpAutoJobs.Items.Add(this.rbWuConnect);
            this.rpAutoJobs.Name = "rpAutoJobs";
            this.rpAutoJobs.Text = "";
            // 
            // rbWakeUp
            // 
            this.rbWakeUp.Image = global::HomeOffice.Properties.Resources.Wecker;
            this.rbWakeUp.LargeImage = global::HomeOffice.Properties.Resources.Wecker;
            this.rbWakeUp.Name = "rbWakeUp";
            this.rbWakeUp.SmallImage = global::HomeOffice.Properties.Resources.Wecker_16;
            this.rbWakeUp.Text = "Nur aufwecken";
            // 
            // rbWuConnect
            // 
            this.rbWuConnect.Image = global::HomeOffice.Properties.Resources.RemoteControl;
            this.rbWuConnect.LargeImage = global::HomeOffice.Properties.Resources.RemoteControl;
            this.rbWuConnect.MinimumSize = new System.Drawing.Size(90, 0);
            this.rbWuConnect.Name = "rbWuConnect";
            this.rbWuConnect.SmallImage = global::HomeOffice.Properties.Resources.RemoteControl_16;
            this.rbWuConnect.Text = "Aufwecken und Verbinden";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 236);
            this.Controls.Add(this.ribbonMain);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.pbComputer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.pbServer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.PictureBox pbComputer;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Ribbon ribbonMain;
        private System.Windows.Forms.RibbonTab rtMain;
        private System.Windows.Forms.RibbonPanel rpSettings;
        private System.Windows.Forms.RibbonButton rbSettings;
        private System.Windows.Forms.RibbonButton rbInfo;
        private System.Windows.Forms.RibbonPanel rpAutoJobs;
        private System.Windows.Forms.RibbonButton rbWakeUp;
        private System.Windows.Forms.RibbonButton rbWuConnect;
    }
}