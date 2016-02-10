using System;
using System.Data;
using System.Windows.Forms;

namespace CAI
{
    public partial class frmLogin : Form
    {
    
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Objectif : Afficher la forme pour modifier son mot de passe. Cacher la forme actuelle.
            frmMotDePasse frmMDP = new frmMotDePasse();
            frmMDP.AccRefConnect = this;
            Hide();
            frmMDP.Show();
           
        }

        private void btnCreation_Click(object sender, EventArgs e)
        {
            frmCreation frmCreation = new frmCreation();
            frmCreation.AccRefCreation = this;
            Hide();
            frmCreation.Show();
        }

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
                        frmAdmin.ShowDialog();
                    }
                    // Si c'est un utilisateur
                    else if (DroitUtilisateur.Rows[0][0].ToString() == "1")
                    {
                        frmCheck frmUtilisateur = new frmCheck(txtNom.Text, txtMDP.Text);
                        frmUtilisateur.ShowDialog();
                    }
                    else if (DroitUtilisateur.Rows[0][0].ToString() == "-1")
                        MessageBox.Show("Votre compte n'est pas confirmé. Veuillez contacter l'administrateur de votre système.");
                    else
                        MessageBox.Show("Mauvais utilisateur ou mot de passe! Veuillez réessayer.");
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
    }
}
