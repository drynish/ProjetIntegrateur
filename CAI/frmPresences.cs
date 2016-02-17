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
    public partial class frmPresences : Form
    {
        private string FID;
        private string FNomUtilisateur;
        private string FMDP;
        public frmPresences(string _nom, string _id, string _NomUtilisateur, string _MDP)
        {
            InitializeComponent();

            this.Text = this.Text + " " + _nom;
            FID = _id;
            FNomUtilisateur = _NomUtilisateur;
            FMDP = _MDP;
        }

        private void frmPresences_Load(object sender, EventArgs e)
        {
            AfficherPresences();
            AfficherTotal();
        }

        private void AfficherPresences()
        {
            string[] paramIN = new string[3];

            paramIN[0] = FNomUtilisateur;
            paramIN[1] = FMDP;
            paramIN[2] = FID;

            DataTable TableRequete = new DataTable();
            TableRequete = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherPresencesPasses", paramIN);

            for (int i = 0; i < TableRequete.Rows.Count; i++)
            {
                GVPresences.Rows.Add();
                GVPresences.Rows[i].Cells[0].Value = TableRequete.Rows[i][0].ToString();
                GVPresences.Rows[i].Cells[1].Value = TableRequete.Rows[i][1].ToString();
                GVPresences.Rows[i].Cells[2].Value = TableRequete.Rows[i][2].ToString();
                GVPresences.Rows[i].Cells[3].Value = TableRequete.Rows[i][3].ToString();
                GVPresences.Rows[i].Cells[4].Value = TableRequete.Rows[i][4].ToString();
                GVPresences.Rows[i].Cells[5].Value = TableRequete.Rows[i][5].ToString();
            }

         }

        private void AfficherTotal()
        {
            string[] paramIN = new string[3];

            paramIN[0] = FNomUtilisateur;
            paramIN[1] = FMDP;
            paramIN[2] = FID;

            DataTable TableRequete = new DataTable();
            TableRequete = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherHeuresEleve", paramIN);

            lblTotal.Text = TableRequete.Rows[0][0].ToString();

        }
    }
}
