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
    public partial class frmLogin : Form
    {
        private CExecuteur FConnexionBD;

        public frmLogin()
        {
            FConnexionBD = new CExecuteur();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Objectif : Afficher la forme pour modifier son mot de passe. Cacher la forme actuelle.
            frmMotDePasse frmMDP = new frmMotDePasse();
            frmMDP.AccRefConnect = this;
            this.Hide();
            frmMDP.Show();
           
        }

        private void btnCreation_Click(object sender, EventArgs e)
        {
            frmCreation frmCreation = new frmCreation();
            frmCreation.AccRefCreation = this;
            this.Hide();
            frmCreation.Show();
        }

        private void btnConnect_Click(object sender, EventArgs e) 
        {
            string[] TabParametres = new string[2];

            TabParametres[0] = "jonathan3698";
            TabParametres[1] = "12345678";

            if (txtNom.Text != "" && txtMDP.Text != "") 
            {
                DataTable DTableTest;
                DTableTest = FConnexionBD.ExecFn("fnRetournerDroit", TabParametres);
                    MessageBox.Show(DTableTest.Rows[0][0].ToString());
                    //Similarly for QuantityInIssueUnit_uom.
                /* frmCheck frmCreation = new frmCheck();
                 this.Hide();
                 frmCreation.Show();*/
            }
            else
                MessageBox.Show("Veuillez entrer votre nom et votre mot de passe !");
            
        }
    }
}
