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
                    string[] paramIN = new string[4];
                    paramIN[0] = txtNom.Text;
                    paramIN[1] = txtMDPActuel.Text;
                    paramIN[2] = txtMDP.Text;
                    paramIN[3] = "0";

                    bool[] paramOUT = new bool[4];
                    paramOUT[0] = false;
                    paramOUT[1] = false;
                    paramOUT[2] = false;
                    paramOUT[3] = true;
                    CExecuteur.ObtenirCExecuteur().ExecPs("spChangerMDP", ref paramIN, paramOUT);

                    if (paramIN[3] == "-1")
                    {
                        txtMDP.Text = "";
                        txtMDPActuel.Text = "";
                        txtNom.Text = "";
                        MessageBox.Show("Mauvais nom d'usager et/ou mot de passe");
                    }
                    if (paramIN[3] == "1")
                    {
                        MessageBox.Show("Succès !");
                        this.Dispose();
                        this.RefAFrmConnection.Show();
                    }
                }
                else
                    MessageBox.Show("Votre mot de passe doit contenir au moins 8 caractères !");
            }
            else
                MessageBox.Show("Veuillez entrer votre courriel et/ou votre mot de passe");
        }
    }
}
