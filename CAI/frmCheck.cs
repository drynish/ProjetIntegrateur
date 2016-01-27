using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;

namespace CAI
{
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
        }

        private void frmCheck_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Permet d'obtenir l'adresse physique (MAC) de l'utilisateur
        /// </summary>
        /// <param name="allowedURL">
        /// Site sous la forme d'une chaine de caractères auquel on se connecte afin de trouver la MAC adresse
        /// </param>
        /// <returns>L'adresse physique</returns>
        private static PhysicalAddress GetCurrentMAC(string allowedURL)
        {
            TcpClient client = new TcpClient();
            client.Client.Connect(new IPEndPoint(Dns.GetHostAddresses(allowedURL)[0], 80));
            while (!client.Connected)
            {
                Thread.Sleep(500);
            }
            IPAddress address2 = ((IPEndPoint)client.Client.LocalEndPoint).Address;
            client.Client.Disconnect(false);
            NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            client.Close();
            if (allNetworkInterfaces.Length > 0)
            {
                foreach (NetworkInterface interface2 in allNetworkInterfaces)
                {
                    UnicastIPAddressInformationCollection unicastAddresses = interface2.GetIPProperties().UnicastAddresses;
                    if ((unicastAddresses != null) && (unicastAddresses.Count > 0))
                    {
                        for (int i = 0; i < unicastAddresses.Count; i++)
                            if (unicastAddresses[i].Address.Equals(address2))
                                return interface2.GetPhysicalAddress();
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Permet d'obtenir l'adresse IP de l'utilisateur
        /// </summary>
        /// <returns>L'adresse IP sous la forme d'une chaine de caractères</returns>
        public static string GetIpAddress()
        {
            string ip = "";
            IPHostEntry ipEntry = Dns.GetHostEntry(GetCompCode());
            IPAddress[] addr = ipEntry.AddressList;
            ip = addr[2].ToString();
            return ip;
        }

        /// <summary>
        /// Permet d'obtenir le nom de l'ordinateur de l'utilisateur
        /// </summary>
        /// <returns>Le nom de l'ordinateur sous la forme d'une chaine de caractères</returns>
        public static string GetCompCode()
        {
            string strHostName = "";
            strHostName = Dns.GetHostName();
            return strHostName;
        }

    }
}
