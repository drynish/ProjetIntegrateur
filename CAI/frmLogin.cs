/* Projet intégrateur 1 (frmLogin)
    Travail sur les présences du centre d'aide en informatique du Cegep de Joliette
    
    Fiche permettant de se connecter pour afficher la bonne fiche selon le droit de l'utilisateur.

    Fait par :

    -Antoine Monzerol
    -Félix Roy
    -Jonathan Clavet-Grenier
    -Alexandre Gratton
    -Samuel Nadeau

    Contact : 514-475-2623
*/

using System;
using System.Data;
using System.Windows.Forms;

namespace CAI
{
    public partial class frmLogin : Form
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permet de faire afficher la form permettant de modifier le mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNouveauMDP_Click(object sender, EventArgs e)
        {
            frmMotDePasse FrmMDP = new frmMotDePasse(); // Représente la fiche permettant de changer de mot de passe
            FrmMDP.ShowDialog();
        }

        /// <summary>
        /// Permet de faire afficher la form permettant de créer un nouveau compte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreation_Click(object sender, EventArgs e)
        {
            frmCreation frmCreation = new frmCreation(); // Représente la fiche permettant de créer un compte
            frmCreation.Show();
        }

        /// <summary>
        /// Permet à l'usager de se connecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e) 
        {
            string[] TabParametres = new string[2]; // Paramètre que l'on envoit à la procédure.

            TabParametres[0] = txtNom.Text;
            TabParametres[1] = txtMDP.Text;

            if (txtNom.Text != "" && txtMDP.Text != "") 
            {
                try
                {
                    DataTable DroitUtilisateur = CExecuteur.ObtenirCExecuteur().ExecFn("fnRetournerDroit", TabParametres);
                    // Si c'est un administrateur
                    if (DroitUtilisateur.Rows[0][0].ToString() == "0")
                    {
                        frmCoordonnateur frmAdmin = new frmCoordonnateur(txtNom.Text, txtMDP.Text);
                        txtNom.Text = "";
                        txtMDP.Text = "";
                        frmAdmin.ShowDialog();
                    
                    }
                    // Si c'est un utilisateur
                    else if (DroitUtilisateur.Rows[0][0].ToString() == "1")
                    {
                        frmCheck frmUtilisateur = new frmCheck(txtNom.Text, txtMDP.Text);
                        txtNom.Text = "";
                        txtMDP.Text = "";
                        frmUtilisateur.ShowDialog();
                    }
                    else
                        MessageBox.Show("Mauvais utilisateur et/ou mot de passe! Veuillez réessayer.");
                }
                catch
                {
                    MessageBox.Show("Une erreur inconnue s'est produite. Veuillez réessayer plus tard.");
                    Application.Exit();
                }
            }
            else
                MessageBox.Show("Veuillez entrer votre nom et votre mot de passe !");   
        }

        /// <summary>
        /// Permet de fermer l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
