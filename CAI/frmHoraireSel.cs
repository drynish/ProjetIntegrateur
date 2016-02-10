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
    public partial class frmHoraireSel : Form
    {
        /// <summary>
        /// Nom utilisateur du compte.
        /// </summary>
        private string FNomUtilisateur;
        /// <summary>
        /// Mot de passe du compte.
        /// </summary>
        private string FMotDePasse;

        DateTime horaire; 
        public frmHoraireSel(string _NomUtilisateur, string _MotDePasse)
        {
            FNomUtilisateur = _NomUtilisateur;
            FMotDePasse = _MotDePasse;
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            /*
            string strHoraire = ""; 

            if (chkLundi.Checked)
                strHoraire = strHoraire + " Lundi " + cmbDebutLundi.Text + " à " + cmbFinLundi.Text;
            if (chkMardi.Checked)
                strHoraire = strHoraire +  " Mardi " + cmbDebutMardi.Text + " à " + cmbFinMardi.Text;
            if (chkMercredi.Checked)
                strHoraire = strHoraire + " Mercredi " + cmbDebutMercredi.Text + " à " + cmbFinMercredi.Text;
            if (chkJeudi.Checked)
                strHoraire = strHoraire + " Jeudi " + cmbDebutJeudi.Text + " à " + cmbFinJeudi.Text;
            if (chkVendredi.Checked)
                strHoraire = strHoraire +  " Vendredi " + cmbDebutVendredi.Text + " à " + cmbFinVendredi.Text;

            horaire = Convert.ToDateTime(strHoraire);
            
            this.Dispose();*/
        }

        public DateTime AccHoraire 
        {
            get
            {
                return horaire;
            }
        }

        private void frmHoraireSel_Load(object sender, EventArgs e)
        {
            string[] paramIN = new string[2];

            int RatioPosition = 75;
            paramIN[0] = FNomUtilisateur;
            paramIN[1] = FMotDePasse;
            DataTable TableRequete = new DataTable();
            TableRequete = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherPeriodes", paramIN);

            CheckBox Lundi;
            CheckBox Mardi;
            CheckBox Mercredi;
            CheckBox Jeudi;
            CheckBox Vendredi;
            Label Periode;

            for (int i = 0; i < TableRequete.Rows.Count; i++)
            {
                Periode = new Label();
                Lundi = new CheckBox();
                Mardi = new CheckBox();
                Mercredi = new CheckBox();
                Jeudi = new CheckBox();
                Vendredi = new CheckBox();

                Periode.Name = "lblPeriode" + i.ToString();
                Periode.Location = new Point(RatioPosition + (i * 25), 9);
                Periode.Text = (i + 1).ToString();
                Periode.AutoSize = true;

                Lundi.Name = "ChBLundi" + i.ToString();
                Mardi.Name = "ChBMardi" + i.ToString();
                Mercredi.Name = "ChBMercredi" + i.ToString();
                Jeudi.Name = "ChBJeudi" + i.ToString();
                Vendredi.Name = "ChBVendredi" + i.ToString();

                Lundi.Location = new Point(RatioPosition + (i * 25), 50);
                Lundi.AutoSize = true;
                Mardi.Location = new Point(RatioPosition + (i * 25), 72);
                Mardi.AutoSize = true;
                Mercredi.Location = new Point(RatioPosition + (i * 25), 94);
                Mercredi.AutoSize = true;
                Jeudi.Location = new Point(RatioPosition + (i * 25), 116);
                Jeudi.AutoSize = true;
                Vendredi.Location = new Point(RatioPosition + (i * 25), 138);
                Vendredi.AutoSize = true;

                Controls.Add(Periode);
                Controls.Add(Lundi);
                Controls.Add(Mardi);
                Controls.Add(Mercredi);
                Controls.Add(Jeudi);
                Controls.Add(Vendredi);

            }
        }
    }
}
