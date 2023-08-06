namespace LiteVPN
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.serverpassTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serveruserTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serveraddressTxt = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.logsTxt = new System.Windows.Forms.TextBox();
            this.connectionstatusLbl = new System.Windows.Forms.Label();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.vpnprotocolSelection = new System.Windows.Forms.ListBox();
            this.killswitchCheck = new System.Windows.Forms.CheckBox();
            this.exitsettingsBtn = new System.Windows.Forms.Button();
            this.sidePanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.sidePanel.Controls.Add(this.label3);
            this.sidePanel.Controls.Add(this.serverpassTxt);
            this.sidePanel.Controls.Add(this.label2);
            this.sidePanel.Controls.Add(this.serveruserTxt);
            this.sidePanel.Controls.Add(this.label1);
            this.sidePanel.Controls.Add(this.serveraddressTxt);
            this.sidePanel.Controls.Add(this.connectBtn);
            this.sidePanel.ForeColor = System.Drawing.Color.White;
            this.sidePanel.Location = new System.Drawing.Point(0, -2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(239, 234);
            this.sidePanel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // serverpassTxt
            // 
            this.serverpassTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.serverpassTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverpassTxt.ForeColor = System.Drawing.Color.White;
            this.serverpassTxt.Location = new System.Drawing.Point(8, 125);
            this.serverpassTxt.Name = "serverpassTxt";
            this.serverpassTxt.Size = new System.Drawing.Size(223, 26);
            this.serverpassTxt.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username";
            // 
            // serveruserTxt
            // 
            this.serveruserTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.serveruserTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serveruserTxt.ForeColor = System.Drawing.Color.White;
            this.serveruserTxt.Location = new System.Drawing.Point(8, 75);
            this.serveruserTxt.Name = "serveruserTxt";
            this.serveruserTxt.Size = new System.Drawing.Size(223, 26);
            this.serveruserTxt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Server Address";
            // 
            // serveraddressTxt
            // 
            this.serveraddressTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.serveraddressTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serveraddressTxt.ForeColor = System.Drawing.Color.White;
            this.serveraddressTxt.Location = new System.Drawing.Point(8, 25);
            this.serveraddressTxt.Name = "serveraddressTxt";
            this.serveraddressTxt.Size = new System.Drawing.Size(223, 26);
            this.serveraddressTxt.TabIndex = 8;
            // 
            // connectBtn
            // 
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.ForeColor = System.Drawing.Color.White;
            this.connectBtn.Location = new System.Drawing.Point(8, 155);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(223, 42);
            this.connectBtn.TabIndex = 8;
            this.connectBtn.Text = "Checking Status...";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // logsTxt
            // 
            this.logsTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.logsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logsTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsTxt.ForeColor = System.Drawing.Color.White;
            this.logsTxt.Location = new System.Drawing.Point(237, 1);
            this.logsTxt.Multiline = true;
            this.logsTxt.Name = "logsTxt";
            this.logsTxt.ReadOnly = true;
            this.logsTxt.Size = new System.Drawing.Size(431, 168);
            this.logsTxt.TabIndex = 8;
            // 
            // connectionstatusLbl
            // 
            this.connectionstatusLbl.AutoSize = true;
            this.connectionstatusLbl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionstatusLbl.ForeColor = System.Drawing.Color.White;
            this.connectionstatusLbl.Location = new System.Drawing.Point(237, 172);
            this.connectionstatusLbl.Name = "connectionstatusLbl";
            this.connectionstatusLbl.Size = new System.Drawing.Size(84, 24);
            this.connectionstatusLbl.TabIndex = 9;
            this.connectionstatusLbl.Text = "Loading";
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsBtn.BackgroundImage")));
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Location = new System.Drawing.Point(642, 172);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(23, 24);
            this.settingsBtn.TabIndex = 14;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.settingsPanel.Controls.Add(this.label4);
            this.settingsPanel.Controls.Add(this.vpnprotocolSelection);
            this.settingsPanel.Controls.Add(this.killswitchCheck);
            this.settingsPanel.Controls.Add(this.exitsettingsBtn);
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(668, 205);
            this.settingsPanel.TabIndex = 15;
            this.settingsPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Selected VPN Protocol";
            this.label4.Visible = false;
            // 
            // vpnprotocolSelection
            // 
            this.vpnprotocolSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.vpnprotocolSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vpnprotocolSelection.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vpnprotocolSelection.ForeColor = System.Drawing.Color.Lime;
            this.vpnprotocolSelection.FormattingEnabled = true;
            this.vpnprotocolSelection.ItemHeight = 18;
            this.vpnprotocolSelection.Items.AddRange(new object[] {
            "PPTP"});
            this.vpnprotocolSelection.Location = new System.Drawing.Point(20, 103);
            this.vpnprotocolSelection.Name = "vpnprotocolSelection";
            this.vpnprotocolSelection.Size = new System.Drawing.Size(291, 92);
            this.vpnprotocolSelection.TabIndex = 18;
            this.vpnprotocolSelection.Visible = false;
            // 
            // killswitchCheck
            // 
            this.killswitchCheck.AutoSize = true;
            this.killswitchCheck.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killswitchCheck.ForeColor = System.Drawing.Color.White;
            this.killswitchCheck.Location = new System.Drawing.Point(20, 12);
            this.killswitchCheck.Name = "killswitchCheck";
            this.killswitchCheck.Size = new System.Drawing.Size(186, 26);
            this.killswitchCheck.TabIndex = 16;
            this.killswitchCheck.Text = "Activate Kill Switch";
            this.killswitchCheck.UseVisualStyleBackColor = true;
            this.killswitchCheck.CheckedChanged += new System.EventHandler(this.killswitchCheck_CheckedChanged);
            // 
            // exitsettingsBtn
            // 
            this.exitsettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitsettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitsettingsBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitsettingsBtn.ForeColor = System.Drawing.Color.White;
            this.exitsettingsBtn.Location = new System.Drawing.Point(642, 172);
            this.exitsettingsBtn.Name = "exitsettingsBtn";
            this.exitsettingsBtn.Size = new System.Drawing.Size(23, 24);
            this.exitsettingsBtn.TabIndex = 15;
            this.exitsettingsBtn.Text = ">";
            this.exitsettingsBtn.UseVisualStyleBackColor = true;
            this.exitsettingsBtn.Click += new System.EventHandler(this.exitsettingsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(668, 200);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.connectionstatusLbl);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.logsTxt);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LiteVPN - www.github.com/JohnFlorinus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox serveraddressTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverpassTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serveruserTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logsTxt;
        private System.Windows.Forms.Label connectionstatusLbl;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Button exitsettingsBtn;
        private System.Windows.Forms.CheckBox killswitchCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox vpnprotocolSelection;
    }
}

