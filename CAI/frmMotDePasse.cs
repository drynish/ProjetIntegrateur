using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAI
{
    public partial class frmMotDePasse : Form
    {
        frmLogin RefAFrmConnection;
        public frmMotDePasse()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //Objectif : Détruite cette fenêtre et revenir à la fenêtre principale.
            this.Dispose();
            this.RefAFrmConnection.Show();
        }

        public frmLogin AccRefConnect
        {
            get { return RefAFrmConnection; }
            set { RefAFrmConnection = value; }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtNom.TextLength != 0 || txtMDPActuel.TextLength < 8)
            {
                if (txtMDP.TextLength >= 8 && txtMDP.TextLength <= 40) {
                    string[] param = new string[3];
                    param[0] = txtNom.Text;
                    param[1] = txtMDPActuel.Text;
                    param[2] = txtMDP.Text;
                    CExecuteur.ObtenirCExecuteur().ExecPs("spChangerMDP", param);
                }
                else
                    MessageBox.Show("Votre mot de passe doit contenir au moins 8 caractères !");
            }
            else
                MessageBox.Show("Veuillez entrer votre courriel et/ou votre mot de passe");
        }
    }
}
