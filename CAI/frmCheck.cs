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
        /// <summary>
        /// Nom d'utilisateur du compte.
        /// </summary>
        private string FNomUtilisateur;
        /// <summary>
        /// Mot de passe du compte.
        /// </summary>
        private string FMotDePasse;

        public frmCheck()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructeur par défaut. On devrait utiliser ce constructeur.
        /// </summary>
        /// <param name="_NomUtilisateur">Correspond au nom d'utilisateur du compte.</param>
        /// <param name="_MotDePasse">Correspond au mot de passe du compte.</param>
        public frmCheck(string _NomUtilisateur, string _MotDePasse)
        {
            FNomUtilisateur = _NomUtilisateur;
            FMotDePasse     = _MotDePasse;
            InitializeComponent();
        }

        private void frmCheck_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Permet de trouver la MAC adresse de l'utilisateur
        /// </summary>
        /// <returns>La MAC adresse sous la forme d'une chaine de caractères</returns>
        public static string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            string sMacAddress = string.Empty;

            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == string.Empty)
                    sMacAddress = adapter.GetPhysicalAddress().ToString();       
            }
            return sMacAddress;
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
