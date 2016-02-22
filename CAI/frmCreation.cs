/* Projet intégrateur 1 (frmCréation)
    Travail sur les présences du centre d'aide en informatique du Cegep de Joliette
    
    Fiche permettant de créer un compte

    Fait par :

    -Antoine Monzerol
    -Félix Roy
    -Jonathan Clavet-Grenier
    -Alexandre Gratton
    -Samuel Nadeau

    Contact : 514-475-2623
*/

using System;
using System.Windows.Forms;
using System.Net.Mail;

namespace CAI
{
    /// <summary>
    /// Classe permettant de créer un compte
    /// </summary>
    public partial class frmCreation : Form
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public frmCreation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fermer la fiche présentement ouverte et retourner à la fiche de connexion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Permet de confirmer les données entrées par l'utilisateur et de créer le compte si valide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e) 
        {
            const string MSG_UTILISATEUR_INVALIDE = "-1"; // Code d'erreur qui représente que l'utilisateur spécifié est déjà utilisé.
            const string MSG_SUCCES = "1"; // Représente que l'exécution de la procédure stockée s'est effectuée avec succès.

            if (txtNomUsager.Text == "" && txtMDP.Text == "" && txtNom.Text == "" && txtPrenom.Text == "")
                MessageBox.Show("Veuillez remplir tous les champs!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else  if (txtMDP.TextLength < 8)
                MessageBox.Show("Votre mot de passe doit contenir au moins 8 caractères!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!AdresseValide(txtNomUsager.Text))
                MessageBox.Show("Le nom d'usager n'est pas une adresse valide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string[] TabParamIN = new string[5];
                bool[] TabParamOUT  = new bool[5];

                TabParamIN[0] = txtPrenom.Text;
                TabParamIN[1] = txtNom.Text; 
                TabParamIN[2] = txtNomUsager.Text;
                TabParamIN[3] = txtMDP.Text;
                TabParamIN[4] = "0";
                
                TabParamOUT[0] = false;
                TabParamOUT[1] = false;
                TabParamOUT[2] = false;
                TabParamOUT[3] = false;
                TabParamOUT[4] = true;

                CExecuteur.ObtenirCExecuteur().ExecPs("spInsererUsager", ref TabParamIN, TabParamOUT);

                switch (TabParamIN[4])
                {
                    case MSG_UTILISATEUR_INVALIDE:
                        MessageBox.Show("Le nom d'utilisateur existe déjà. Veuillez en choisir un autre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case MSG_SUCCES:
                        MessageBox.Show("Votre compte a été enregistré avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        break;
                    default:
                        MessageBox.Show("Une erreur inconnue est survenue. Veuillez réessayer plus tard.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                    
            }

        }

        /// <summary>
        /// Permet de vérifier si le format du nom d'utilisateur est valide
        /// </summary>
        /// <param name="_AdresseCourriel"></param>
        /// <returns>Retourne true si l'adresse est valide sinon retourne false</returns>
        public bool AdresseValide(string _AdresseCourriel) 
        {
            try
            {
                MailAddress m = new MailAddress(_AdresseCourriel);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
