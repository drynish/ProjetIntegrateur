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
using System.Globalization;

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
            string[] TabParametres = new string[5];
            bool[] TabParamOutput = new bool[5];

            string Message = "";

            TabParametres[0] = FNomUtilisateur;
            TabParametres[1] = FMotDePasse;
            TabParametres[2] = GetIpAddress();
            TabParametres[3] = GetMACAddress();
            TabParametres[4] = Message;

            TabParamOutput[0] = false;
            TabParamOutput[1] = false;
            TabParamOutput[2] = false;
            TabParamOutput[3] = false;
            TabParamOutput[4] = true;

            CExecuteur.ObtenirCExecuteur().ExecPs("spSignerPresence", ref TabParametres, TabParamOutput);

            switch (Message)
            {
                case "0":
                    MessageBox.Show("Vous avez signé votre présence (check-in) avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "1":
                    MessageBox.Show("Vous avez signé votre présence (check-out) avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Une erreur inconnue est survenue. Veuillez réessayer plus tard.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            Close();

        }

        private void frmCheck_Shown(object sender, EventArgs e)
        {
            CultureInfo provider = new CultureInfo("fr-FR");
            string[] TabParametres = new string[0];
            DataTable DroitUtilisateur = CExecuteur.ObtenirCExecuteur().ExecPs("spObtenirDateEtHeure", TabParametres);
            string date = DroitUtilisateur.Rows[0][0].ToString();
            date = date.Remove(date.Length - 3);
            DateTime datetime = DateTime.ParseExact(date, "g", provider);
            lblDate.Text = datetime.ToLongDateString() + ' ' + datetime.ToShortTimeString();
            string[] TabParametres2 = new string[1];
            TabParametres2[0] = FNomUtilisateur;
            DataTable DroitUtilisateur2 = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherPresencesRequisesDeUnEleve", TabParametres2);
            if (DroitUtilisateur2 != null)
            {
                string date2 = DroitUtilisateur2.Rows[0][0].ToString();
                lblNote.Text = lblNote.Text + " Vous avez un Check in aujourd'hui à " + date2;
            }
            else
            {
                lblNote.Text = lblNote.Text + " Vous n'avez pas de Check in aujourd'hui ";
                btnConfirm.Enabled = false;
            }


        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
