using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace CAI
{
    public partial class frmCreation : Form
    {
        frmLogin RefAFrmCreation;

        public frmCreation()
        {
            InitializeComponent();
        }
        public frmLogin AccRefCreation
        {
            get { return RefAFrmCreation; }
            set { RefAFrmCreation = value; }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //Objectif : Détruite cette fenêtre et revenir à la fenêtre principale.
            this.Dispose();
            this.RefAFrmCreation.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e) 
        {

            if (txtNomUsager.Text == "" && txtMDP.Text == "" && txtNom.Text == "" && txtPrenom.Text == "")
                MessageBox.Show("Vous n'avez pas entrer tous les champs !");
            else  if (txtMDP.TextLength < 8)
                MessageBox.Show("Votre mot de passe doit contenir au moins 8 caractères !");
            else if (!AdresseValide(txtNomUsager.Text))
                MessageBox.Show("Le nom d'usager n'est pas une adresse valide !");

        }

        public bool AdresseValide(string emailaddress) 
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
