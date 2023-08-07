using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;

namespace LiteVPN
{
    public partial class Form1 : Form
    {
        //yo
        #region Allmänt
        public Form1()
        {
            InitializeComponent();
        }

        public bool connectionStatus;
        public bool killswitchToggle = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            checkStatus();
            if (CheckForInternet()==false)
            {
                MessageBox.Show("You need an internet connection to use liteVPN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
        #endregion

        #region kontroller
        private void checkStatus()
        {
            if (CheckForVPNInterface()==true)
            {
                connectBtn.Text = "Disconnect";
                connectionstatusLbl.Text = "Connected";
                connectionstatusLbl.ForeColor = Color.Lime;
                connectionStatus = true;
            }
            else
            {
                connectBtn.Text = "Connect";
                connectionstatusLbl.Text = "Unconnected";
                connectionstatusLbl.ForeColor = Color.Orange;
                connectionStatus = false;
            }
            // detta hämtar användarens public ip address men den funkar ibland inte när en vpn anslutning gjordes
            /*try
            {
                System.Net.WebClient pubIp4 = new System.Net.WebClient();
                publicip4Lbl.Text = "Public IPv4: " + await pubIp4.DownloadStringTaskAsync(new Uri("https://api.ipify.org"));
                pubIp4.Dispose();
            }
            catch (Exception ex)
            {
                logsTxt.Text = "ERROR: " + ex;
            }*/
        }

        // Kollar alla nätverk interfaces för en PPP adapter vilket betyder att användaren är VPN ansluten
        public bool CheckForVPNInterface()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                NetworkInterface[] interfaces =
                NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface Interface in interfaces)
                {
                    if ((Interface.NetworkInterfaceType == NetworkInterfaceType.Ppp) && (Interface.NetworkInterfaceType != NetworkInterfaceType.Loopback) && (Interface.OperationalStatus == OperationalStatus.Up))
                    {
                        logsTxt.Text = "Currently connected to " + Interface.Name;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CheckForInternet()
        {
            // Öppnar en dataström från google, om misslyckas så är internet troligen nere
            // Använder webclients openread istället för ping eftersom att ICMP requests kan blockas
            try
            {
                using (WebClient client = new WebClient())
                {
                    using (client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                // utifall google är blockad eller nere så testas öst alternativet, bra för Iran och Kina användare
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        using (client.OpenRead("http://www.baidu.com"))
                        {
                            return true;
                        }
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region Specialfunktioner
        private async void killSwitch()
        {
            if (CheckForVPNInterface()==false)
            {
                Process.Start("ipconfig", "/release");
                MessageBox.Show("hi");
                killswitchToggle = false;
            }
            await Task.Delay(100);
            if (killswitchToggle==true)
            {
                killSwitch();
            }
        }
        #endregion

        #region VPN Anslutning/Avslutning
        // Huvudkomponent
        private void connectBtn_Click(object sender, EventArgs e)
        {
            connectBtn.Enabled = false;
            logsTxt.Text = null;
            if (connectionStatus==false)
            {
                if (killswitchCheck.Checked==true)
                {
                    killswitchToggle = true;
                }
                connectionstatusLbl.Text = "Connecting...";
                connectionstatusLbl.ForeColor = Color.Yellow;
                // skapar en .pbk fil med användarens angivna server address i temp albumet
                using (StreamWriter sw = File.CreateText(Path.GetTempPath() + "liteVPN.pbk"))
                {
                    sw.WriteLine("[" + serveraddressTxt.Text + "]");
                    sw.WriteLine("MEDIA=rastapi");
                    sw.WriteLine("Port=VPN2-0");
                    sw.WriteLine("DEVICE=WAN Miniport (IKEv2)");
                    sw.WriteLine("DEVICE=vpn");
                    sw.WriteLine("phoneNumber=" + serveraddressTxt.Text);
                    sw.Close();
                }
                // startar gömd cmd process med rasdial kommando riktat mot nyligen skapade .pbk filen
                using (var Terminal = new Process())
                {
                    Terminal.StartInfo.Arguments = "/C rasdial \"" + serveraddressTxt.Text + "\" " + serveruserTxt.Text + " " + serverpassTxt.Text + " /phonebook:\"" + Path.GetTempPath() + "liteVPN.pbk\"& exit";
                    Terminal.StartInfo.UseShellExecute = false;
                    Terminal.StartInfo.RedirectStandardOutput = true;
                    Terminal.StartInfo.RedirectStandardError = true;
                    Terminal.StartInfo.CreateNoWindow = true;
                    Terminal.StartInfo.FileName = "CMD.exe";
                    Terminal.EnableRaisingEvents = true;
                    Terminal.Start();
                    Terminal.BeginOutputReadLine();
                    Terminal.BeginErrorReadLine();

                    // läs CMD feedback och skriv ner det i logsTxt, logsTxt måste uppenbarligen invokas för det är en annan thread
                    Terminal.OutputDataReceived += (s, evt) => {
                        if (evt.Data != null)
                        {
                            BeginInvoke(new MethodInvoker(() => {
                                logsTxt.AppendText(evt.Data + Environment.NewLine);
                                logsTxt.ScrollToCaret();
                            }));
                        }
                    };

                    Terminal.ErrorDataReceived += (s, evt) => {
                        if (evt.Data != null)
                        {
                            BeginInvoke(new Action(() => {
                                logsTxt.AppendText(evt.Data + Environment.NewLine);
                                logsTxt.ScrollToCaret();
                                checkStatus();
                                connectBtn.Enabled = true;
                                Terminal.Close();
                                return;
                            }));
                        }
                    };

                    // Loop som kollar om CMD processen är avslutad, Terminal.Exited funkade inte
                    // FUL KOD, ska fixa
                    while (true)
                    {
                        if (Terminal.HasExited)
                        {
                            checkStatus();
                            connectBtn.Enabled = true;
                            Terminal.Dispose();
                            if (CheckForVPNInterface() == true) {
                                    if (killswitchToggle == true)
                                    {
                                        killSwitch();
                                    }
                            }
                            return;
                        };
                    }
                }
            }
            else
            {
                connectionstatusLbl.Text = "Disconnecting...";
                connectionstatusLbl.ForeColor = Color.Yellow;
                killswitchToggle = false;
                using (var Terminal = new Process())
                {
                    Terminal.StartInfo.Arguments = "/C rasdial/d& exit";
                    Terminal.StartInfo.UseShellExecute = false;
                    Terminal.StartInfo.RedirectStandardOutput = true;
                    Terminal.StartInfo.RedirectStandardError = true;
                    Terminal.StartInfo.CreateNoWindow = true;
                    Terminal.StartInfo.FileName = "CMD.exe";
                    Terminal.EnableRaisingEvents = true;
                    Terminal.Start();
                    Terminal.BeginOutputReadLine();
                    Terminal.BeginErrorReadLine();


                    Terminal.OutputDataReceived += (s, evt) => {
                        if (evt.Data != null)
                        {
                            BeginInvoke(new MethodInvoker(() => {
                                logsTxt.AppendText(evt.Data + Environment.NewLine);
                                logsTxt.ScrollToCaret();
                            }));
                        }
                    };

                    Terminal.ErrorDataReceived += (s, evt) => {
                        if (evt.Data != null)
                        {
                            BeginInvoke(new Action(() => {
                                logsTxt.AppendText(evt.Data + Environment.NewLine);
                                logsTxt.ScrollToCaret();
                            }));
                        }
                    };

                    while (true)
                    {
                        if (Terminal.HasExited)
                        {
                              checkStatus();
                              connectBtn.Enabled = true;
                              Terminal.Close();
                              return;
                        };
                    }
                }
            }
        }
        #endregion

        #region Inställningspanelen
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = true;
        }

        private void exitsettingsBtn_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
        }

        private void killswitchCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (killswitchCheck.Checked==true)
            {
                killswitchToggle = true;
                if (CheckForVPNInterface() == true)
                {
                    killSwitch();
                }
            }
            else {
                killswitchToggle = false;
            }
        }
        #endregion
    }
}
