namespace HomeOffice
{
    partial class SettingsView
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
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.cbUseDefaultPort = new System.Windows.Forms.CheckBox();
            this.nudServerPort = new System.Windows.Forms.NumericUpDown();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.tbServerIpAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbComputer = new System.Windows.Forms.GroupBox();
            this.tbComputerMacAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbComputerIpAddress = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDelayConnect = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCloseAfterConnect = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lkLabelOpenProgPath = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).BeginInit();
            this.gbComputer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayConnect)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.cbUseDefaultPort);
            this.gbServer.Controls.Add(this.nudServerPort);
            this.gbServer.Controls.Add(this.lblServerPort);
            this.gbServer.Controls.Add(this.tbServerIpAddress);
            this.gbServer.Controls.Add(this.label1);
            this.gbServer.Location = new System.Drawing.Point(10, 10);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(386, 140);
            this.gbServer.TabIndex = 0;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "WakeOnLan-Server";
            // 
            // cbUseDefaultPort
            // 
            this.cbUseDefaultPort.AutoSize = true;
            this.cbUseDefaultPort.Location = new System.Drawing.Point(14, 99);
            this.cbUseDefaultPort.Name = "cbUseDefaultPort";
            this.cbUseDefaultPort.Size = new System.Drawing.Size(232, 24);
            this.cbUseDefaultPort.TabIndex = 4;
            this.cbUseDefaultPort.Text = "Standard-Port verwenden";
            this.cbUseDefaultPort.UseVisualStyleBackColor = true;
            // 
            // nudServerPort
            // 
            this.nudServerPort.Location = new System.Drawing.Point(155, 67);
            this.nudServerPort.Maximum = new decimal(new int[] {
            49151,
            0,
            0,
            0});
            this.nudServerPort.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudServerPort.Name = "nudServerPort";
            this.nudServerPort.Size = new System.Drawing.Size(120, 26);
            this.nudServerPort.TabIndex = 3;
            this.nudServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudServerPort.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(10, 70);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(47, 20);
            this.lblServerPort.TabIndex = 2;
            this.lblServerPort.Text = "Port:";
            // 
            // tbServerIpAddress
            // 
            this.tbServerIpAddress.Location = new System.Drawing.Point(155, 29);
            this.tbServerIpAddress.Name = "tbServerIpAddress";
            this.tbServerIpAddress.Size = new System.Drawing.Size(214, 26);
            this.tbServerIpAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP-Adresse:";
            // 
            // gbComputer
            // 
            this.gbComputer.Controls.Add(this.tbComputerMacAddress);
            this.gbComputer.Controls.Add(this.label3);
            this.gbComputer.Controls.Add(this.label4);
            this.gbComputer.Controls.Add(this.tbComputerIpAddress);
            this.gbComputer.Location = new System.Drawing.Point(10, 156);
            this.gbComputer.Name = "gbComputer";
            this.gbComputer.Size = new System.Drawing.Size(386, 159);
            this.gbComputer.TabIndex = 1;
            this.gbComputer.TabStop = false;
            this.gbComputer.Text = "Remote-Computer";
            // 
            // tbComputerMacAddress
            // 
            this.tbComputerMacAddress.Location = new System.Drawing.Point(155, 67);
            this.tbComputerMacAddress.Name = "tbComputerMacAddress";
            this.tbComputerMacAddress.Size = new System.Drawing.Size(214, 26);
            this.tbComputerMacAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "MAC-Adresse:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP-Adresse:";
            // 
            // tbComputerIpAddress
            // 
            this.tbComputerIpAddress.Location = new System.Drawing.Point(155, 29);
            this.tbComputerIpAddress.Name = "tbComputerIpAddress";
            this.tbComputerIpAddress.Size = new System.Drawing.Size(214, 26);
            this.tbComputerIpAddress.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(668, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(10, 321);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 30);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudDelayConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbCloseAfterConnect);
            this.groupBox1.Location = new System.Drawing.Point(402, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RDP-Verbindungsaufbau";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "erfolgreichem Aufwecken:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "(Sek.)";
            // 
            // nudDelayConnect
            // 
            this.nudDelayConnect.Location = new System.Drawing.Point(232, 57);
            this.nudDelayConnect.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDelayConnect.Name = "nudDelayConnect";
            this.nudDelayConnect.Size = new System.Drawing.Size(88, 26);
            this.nudDelayConnect.TabIndex = 2;
            this.nudDelayConnect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Verzögerung Computer ist Online nach";
            // 
            // cbCloseAfterConnect
            // 
            this.cbCloseAfterConnect.AutoSize = true;
            this.cbCloseAfterConnect.Location = new System.Drawing.Point(14, 99);
            this.cbCloseAfterConnect.Name = "cbCloseAfterConnect";
            this.cbCloseAfterConnect.Size = new System.Drawing.Size(293, 24);
            this.cbCloseAfterConnect.TabIndex = 4;
            this.cbCloseAfterConnect.Text = "Nach Aufbau Programm beenden";
            this.cbCloseAfterConnect.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lkLabelOpenProgPath);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(402, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 159);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RDP-Verbindungsdateien";
            // 
            // lkLabelOpenProgPath
            // 
            this.lkLabelOpenProgPath.AutoSize = true;
            this.lkLabelOpenProgPath.Location = new System.Drawing.Point(10, 125);
            this.lkLabelOpenProgPath.Name = "lkLabelOpenProgPath";
            this.lkLabelOpenProgPath.Size = new System.Drawing.Size(245, 20);
            this.lkLabelOpenProgPath.TabIndex = 4;
            this.lkLabelOpenProgPath.TabStop = true;
            this.lkLabelOpenProgPath.Text = "Programmverzeichniss öffnen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "und in der Menüleiste angezeigt.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(350, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Diese werden beim Programmstart erkannt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(356, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "RDP-Verbindungsdateien abgelegt werden.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Im Programmverzeichniss können diverse";
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(801, 363);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbComputer);
            this.Controls.Add(this.gbServer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "SettingsView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Einstellungen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsView_FormClosing);
            this.Load += new System.EventHandler(this.SettingsView_Load);
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).EndInit();
            this.gbComputer.ResumeLayout(false);
            this.gbComputer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayConnect)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.TextBox tbServerIpAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbComputer;
        private System.Windows.Forms.TextBox tbComputerMacAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbComputerIpAddress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown nudServerPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbCloseAfterConnect;
        private System.Windows.Forms.CheckBox cbUseDefaultPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDelayConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lkLabelOpenProgPath;
        private System.Windows.Forms.Label label10;
    }
}