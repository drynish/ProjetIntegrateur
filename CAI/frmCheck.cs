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
    /// <summary>
    /// Classe permettant de signer sa présence lord d'un "CheckIn" ou d'un "CheckOut"
    /// </summary>
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
            //Représente la configuration et les statistiques de l'interface réseau
            NetworkInterface[] Nics = NetworkInterface.GetAllNetworkInterfaces();
            //Représente la MacAdresse sous la forme d'une chaine de caractère
            string MacAddress = string.Empty;

            foreach (NetworkInterface Adapter in Nics)
            {
                if (MacAddress == string.Empty)
                    MacAddress = Adapter.GetPhysicalAddress().ToString();       
            }
            return MacAddress;
        }

        /// <summary>
        /// Permet d'obtenir l'adresse IP de l'utilisateur
        /// </summary>
        /// <returns>L'adresse IP sous la forme d'une chaine de caractères</returns>
        public static string GetIpAddress()
        {
            //Représente les informations d'adresse d'hôte internet
            IPHostEntry IpEntry = Dns.GetHostEntry(GetCompCode());
            //Représente l'adresse Ip de la machine
            IPAddress[] addr = IpEntry.AddressList;
            return addr[2].ToString();
        }

        /// <summary>
        /// Permet d'obtenir le nom de l'ordinateur de l'utilisateur
        /// </summary>
        /// <returns>Le nom de l'ordinateur sous la forme d'une chaine de caractères</returns>
        public static string GetCompCode()
        {
            return Dns.GetHostName();
        }

        /// <summary>
        /// Permet de confirmer sa présence lors d'un "CheckIn" ou d'un CheckOut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Tableau contenant les paramètres de la procédure
            string[] TabParametres = new string[5];
            //Tableau représentant si les paramètres sont en output          
            bool[] TabParamOutput = new bool[5];                

            TabParametres[0] = FNomUtilisateur;
            TabParametres[1] = FMotDePasse;
            TabParametres[2] = GetIpAddress();
            TabParametres[3] = GetMACAddress();
            TabParametres[4] = "";

            TabParamOutput[0] = false;
            TabParamOutput[1] = false;
            TabParamOutput[2] = false;
            TabParamOutput[3] = false;
            TabParamOutput[4] = true;

            CExecuteur.ObtenirCExecuteur().ExecPs("spSignerPresence", ref TabParametres, TabParamOutput);

            // Permet d'afficher le bon message selon le résultat de la requête
            switch (TabParametres[4])
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

        /// <summary>
        /// Permet de faire afficher la date de la journée en cours
        /// Permet d'avertir l'utilisteur s'il a des présences pour la journée en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCheck_Shown(object sender, EventArgs e)
        {
            //Représente le fournisseur pour la conversion de la date
            CultureInfo Fournisseur = new CultureInfo("fr-FR");
            //Représente le tableau des paramètres nécessaires pour la requête
            string[] TabParametres = new string[0];
            //DataTable contenant le résultat de la requête
            DataTable DroitUtilisateur = CExecuteur.ObtenirCExecuteur().ExecPs("spObtenirDateEtHeure", TabParametres);
            //Représente la date actuelle du serveur
            string Date = DroitUtilisateur.Rows[0][0].ToString();
            Date = Date.Remove(Date.Length - 3);
            //Représente la date sous la forme d'un DateTime
            DateTime Datetime = DateTime.ParseExact(Date, "g", Fournisseur);
            lblDate.Text = Datetime.ToLongDateString() + ' ' + Datetime.ToShortTimeString();
            TabParametres = new string[1];
            TabParametres[0] = FNomUtilisateur;
            DroitUtilisateur = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherPresencesRequisesDeUnEleve", TabParametres);
            //Permet de faire afficher les information selon le résultat de la requête
            if (DroitUtilisateur != null)
            {
                Date = "";
                for (int i=0; i< DroitUtilisateur.Rows.Count; i++)
                {
                    if (i == DroitUtilisateur.Rows.Count - 2)
                        Date = Date + DroitUtilisateur.Rows[i][0].ToString() + " et ";
                    else
                        Date = Date + DroitUtilisateur.Rows[i][0].ToString() + " , ";
                }
                if (DroitUtilisateur.Rows.Count > 1)
                    lblNote.Text = lblNote.Text + " Vous avez des présences requises aujourd'hui à " + Date.Remove(Date.Length - 2) + ".";
                else
                    lblNote.Text = lblNote.Text + " Vous avez une présence requise aujourd'hui à " + Date.Remove(Date.Length - 2) + ".";
            }
            else
            {
                lblNote.Text = lblNote.Text + " Vous n'avez pas de présences requises aujourd'hui ";
                btnConfirm.Enabled = false;
            }


        }
        /// <summary>
        /// Perme de fermer la form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
