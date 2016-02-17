using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        
        /// <summary>
        /// ID de l'usager sélectionné.
        /// </summary>
        private int FID;


        public frmHoraireSel(string _NomUtilisateur, string _MotDePasse, int _id)
        {
            FNomUtilisateur = _NomUtilisateur;
            FMotDePasse = _MotDePasse;
            FID = _id;
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Suppressions des présences requises déjà en place
            CExecuteur.ObtenirCExecuteur().ExecPs("spSupprimerPresenceRequise", new string[] { FNomUtilisateur, FMotDePasse, Convert.ToString(FID) });

            foreach (Control chb in Controls)
            {
                if (chb is CheckBox)
                {
                    if ((chb as CheckBox).Checked)
                    {
                        string[] TabParametres = new string[5]; // Paramètre que l'on envoit à la procédure.
                        string strPeriode = Regex.Match(chb.Name, @"\d+").Value;
                        strPeriode = strPeriode.ToString();
                        TabParametres[0] = FNomUtilisateur;
                        TabParametres[1] = FMotDePasse;
                        TabParametres[2] = FID.ToString();
                        TabParametres[3] = chb.Tag.ToString();
                        TabParametres[4] = strPeriode;
                        CExecuteur.ObtenirCExecuteur().ExecPs("spAjouterPresenceRequise", TabParametres);
                    }
                }
            }
            MessageBox.Show("Les présences ont été sauvegardés avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }


        private void frmHoraireSel_Load(object sender, EventArgs e)
        {
            afficherBoites();
            afficherPresences();
        }

        private void afficherBoites()
        {
            string[] paramIN = new string[2];

            int RatioPosition = 75;
            paramIN[0] = FNomUtilisateur;
            paramIN[1] = FMotDePasse;
            DataTable TableRequete = new DataTable();
            TableRequete = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherPeriodes", paramIN);

            if (TableRequete != null)
            {
                for (int i = 0; i < TableRequete.Rows.Count; i++)
                {
                    Label Periode = new Label();
                    CheckBox Lundi = new CheckBox();
                    CheckBox Mardi = new CheckBox();
                    CheckBox Mercredi = new CheckBox();
                    CheckBox Jeudi = new CheckBox();
                    CheckBox Vendredi = new CheckBox();

                    Periode.Name = "lblPeriode" + TableRequete.Rows[i][1].ToString();
                    Periode.Location = new Point(RatioPosition + (i * 25), 9);
                    Periode.Text = (i + 1).ToString();
                    Periode.AutoSize = true;

                    Lundi.Name = "ChBLundi" + (i + 1).ToString();
                    Mardi.Name = "ChBMardi" + (i + 1).ToString();
                    Mercredi.Name = "ChBMercredi" + (i + 1).ToString();
                    Jeudi.Name = "ChBJeudi" + (i + 1).ToString();
                    Vendredi.Name = "ChBVendredi" + (i + 1).ToString();

                    Lundi.Tag = "Lundi";
                    Mardi.Tag = "Mardi";
                    Mercredi.Tag = "Mercredi";
                    Jeudi.Tag = "Jeudi";
                    Vendredi.Tag = "Vendredi";

                    Lundi.Location = new Point(RatioPosition + (i * 25), 66);
                    Lundi.AutoSize = true;
                    Mardi.Location = new Point(RatioPosition + (i * 25), 88);
                    Mardi.AutoSize = true;
                    Mercredi.Location = new Point(RatioPosition + (i * 25), 110);
                    Mercredi.AutoSize = true;
                    Jeudi.Location = new Point(RatioPosition + (i * 25), 132);
                    Jeudi.AutoSize = true;
                    Vendredi.Location = new Point(RatioPosition + (i * 25), 154);
                    Vendredi.AutoSize = true;

                    Controls.Add(Periode);
                    Controls.Add(Lundi);
                    Controls.Add(Mardi);
                    Controls.Add(Mercredi);
                    Controls.Add(Jeudi);
                    Controls.Add(Vendredi);

                }
                if (TableRequete.Rows.Count > 0)
                {
                    int test = (25 * TableRequete.Rows.Count);
                    Width = (test + 86);
                    btnConfirm.Width = (Width - 26);
                }
                    
                else
                    MessageBox.Show("Une erreur inconnue est survenu. Veuillez réessayer plus tard.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void afficherPresences()
        {
            string BoxToCheck;
            string[] paramIN = new string[1];
            paramIN[0] = FID.ToString();
            DataTable TableRequete = new DataTable();
            TableRequete = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherPresencesRequisesDeUnEleveSelonID", paramIN);

            for (int i = 0; i < TableRequete.Rows.Count; i++)
            {
                if (TableRequete.Rows[i][0].ToString() == "Lundi")
                {
                    BoxToCheck = "ChBLundi" + TableRequete.Rows[i][1].ToString();
                    Control[] chb = this.Controls.Find(BoxToCheck, false);
                    (chb[0] as CheckBox).Checked = true;
                }
                else if (TableRequete.Rows[i][0].ToString() == "Mardi")
                {
                    BoxToCheck = "ChBMardi" + TableRequete.Rows[i][1].ToString();
                    Control[] chb = this.Controls.Find(BoxToCheck, false);
                    (chb[0] as CheckBox).Checked = true;
                }
                else if (TableRequete.Rows[i][0].ToString() == "Mercredi")
                {
                    BoxToCheck = "ChBMercredi" + TableRequete.Rows[i][1].ToString();
                    Control[] chb = this.Controls.Find(BoxToCheck, false);
                    (chb[0] as CheckBox).Checked = true;
                }
                else if (TableRequete.Rows[i][0].ToString() == "Jeudi")
                {
                    BoxToCheck = "ChBJeudi" + TableRequete.Rows[i][1].ToString();
                    Control[] chb = this.Controls.Find(BoxToCheck, false);
                    (chb[0] as CheckBox).Checked = true;
                }
                else if (TableRequete.Rows[i][0].ToString() == "Vendredi")
                {
                    BoxToCheck = "ChBVendredi" + TableRequete.Rows[i][1].ToString();
                    Control[] chb = this.Controls.Find(BoxToCheck, false);
                    (chb[0] as CheckBox).Checked = true;
                }
            }
        }
    }

}
