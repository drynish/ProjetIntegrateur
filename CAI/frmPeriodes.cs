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
    public partial class frmPeriodes : Form
    {
        /// <summary>
        /// Représente si l'on souhaite de ne pas déclencher l'événement OnSelectedIndexChanged.
        /// </summary>
        private bool FEmpecherEventDeDeclencher;
        /// <summary>
        /// Représente le nom d'utilisteur de l'utilisateur connecté en ce moment.
        /// </summary>
        private string FNomUtilisateur = "f";
        /// <summary>
        /// Représente le mot de passe de l'utilisteur connecté en ce moment.
        /// </summary>
        private string FMotDePasse = "f";
        /// <summary>
        /// Si l'utilisateur vient d'ajouter une période.
        /// </summary>
        private bool FVientAjoutePeriode;
        /// <summary>
        /// Représente le tableau des ID des périodes
        /// </summary>
        private int[] FTabPeriodesID;

        public frmPeriodes()
        {
            InitializeComponent();
        }
  
        public frmPeriodes(string _NomUtilisateur, string _MotDePasse)
        {
            FNomUtilisateur            = _NomUtilisateur;
            FMotDePasse                = _MotDePasse;
            FVientAjoutePeriode        = false;
            FEmpecherEventDeDeclencher = false;
            FTabPeriodesID             = null;

            InitializeComponent();
        }

        private void frmPeriodes_Load(object sender, EventArgs e) 
        {
            chargerPeriodes();
        }

        private void gererTouchesPeriodes(object sender, KeyPressEventArgs e)
        {
            // Autoriser le caractère Backspace.
            if (e.KeyChar != '\b')
            {
                // Autoriser seulement les numéros.
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }

        /// <summary>
        /// Appelle le script de supression de la dernière période.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (FTabPeriodesID.Length > 0)
            {
                //La commande de suppression est exécutée.
                CExecuteur.ObtenirCExecuteur().ExecPs("spSupprimerPeriode", new string[] { FNomUtilisateur, FMotDePasse });

                MessageBox.Show("Vous avez supprimé la période " + FTabPeriodesID.Length.ToString(), "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FVientAjoutePeriode = false;
                btnConfirmer.Enabled = false;
                btnSupp.Enabled = false;
                cmbPeriodes.Enabled = false;
                txtHeureDebut.Enabled = false;
                txtHeureFin.Enabled = false;
                txtMinuteDebut.Enabled = false;
                txtMinuteFin.Enabled = false;
                txtHeureDebut.Text = txtHeureFin.Text = txtMinuteDebut.Text = txtMinuteFin.Text = "";
                chargerPeriodes();
            }
            else
                MessageBox.Show("Il n'y a aucune période dans la base de données!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Ferme la fenêtre et retourne au menu précédent.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Appelle le script d'ajout des périodes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (FTabPeriodesID.Length == 14)
                MessageBox.Show("Vous ne pouvez pas ajouter une période, car vous avez atteint la limite maximale!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!FVientAjoutePeriode)
            {
                FVientAjoutePeriode = true;
                FEmpecherEventDeDeclencher = true;

                cmbPeriodes.Items.Add("Nouvelle période...");
                cmbPeriodes.SelectedIndex = (cmbPeriodes.Items.Count - 1);
                FEmpecherEventDeDeclencher = false;

                txtHeureDebut.Text = txtHeureFin.Text = "hh";
                txtMinuteDebut.Text = txtMinuteFin.Text = "mm";

                btnConfirmer.Enabled = true;
                cmbPeriodes.Enabled = true;
                txtHeureDebut.Enabled = true;
                txtHeureFin.Enabled = true;
                txtMinuteDebut.Enabled = true;
                txtMinuteFin.Enabled = true;
            }
        }

        /// <summary>
        /// Charge les périodes dans le comboBox.
        /// </summary>
        private void chargerPeriodes()
        {
            cmbPeriodes.Items.Clear();
            Array.Resize(ref FTabPeriodesID, 0);

            //La commande est exécutée et le résultat est ajouté à la liste.
            DataTable resultat = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherPeriodes", new string[] { FNomUtilisateur, FMotDePasse });

            if (resultat != null)
            {
                Array.Resize(ref FTabPeriodesID, resultat.Rows.Count);
                for (int i = 0; i < resultat.Rows.Count; i++)
                {
                    FTabPeriodesID[i] = Convert.ToInt32(resultat.Rows[i][0].ToString());
                    cmbPeriodes.Items.Add("Période " + resultat.Rows[i][1].ToString() + " : " + resultat.Rows[i][2].ToString() + " à " + resultat.Rows[i][3].ToString());
                }
                // Le premier élément est sélectionné.
                cmbPeriodes.SelectedIndex = 0;
            }
            else
                cmbPeriodes.SelectedIndex = -1;
        }


        /// <summary>
        /// Appelle le script de modification des périodes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdConfirmer_Click(object sender, EventArgs e)
        {
            if (VerifierHeureDebut() &&
                VerifierMinuteDebut() &&
                VerifierHeureFin() &&
                VerifierMinuteFin() &&
                VerifierCoherenceHeure())
            {
                string HeureDebut; // Heure de début de la période que l'on souhaite ajouter.
                string HeureFin;   // Heure de fin de la période que l'on souhaite ajouter

                HeureDebut = txtHeureDebut.Text + ":" + txtMinuteDebut.Text;
                HeureFin = txtHeureFin.Text + ":" + txtMinuteFin.Text;

                // S'il vient d'ajouter une période
                if (FVientAjoutePeriode)
                {
                    CExecuteur.ObtenirCExecuteur().ExecPs("spAjouterPeriode", new string[] { FNomUtilisateur, FMotDePasse, HeureDebut, HeureFin });
                    FVientAjoutePeriode = false;
                    MessageBox.Show("La période " + (FTabPeriodesID.Length + 1).ToString() + " a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CExecuteur.ObtenirCExecuteur().ExecPs("spModifierPeriode", new string[] { FNomUtilisateur, FMotDePasse, HeureDebut, HeureFin, Convert.ToString(FTabPeriodesID[cmbPeriodes.SelectedIndex]) });
                    MessageBox.Show("La période " + (cmbPeriodes.SelectedIndex + 1).ToString() + " a été sauvegardé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Les périodes sont rechargées.
                chargerPeriodes();
            }
            else
                MessageBox.Show("Votre temps n'est pas valide. Veuillez réessayer.\nVoici un exemple du format à respecter: 1:00 à 20:01", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbPeriodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FEmpecherEventDeDeclencher && cmbPeriodes.SelectedIndex < FTabPeriodesID.Length)
            {
                string idPeriode = Convert.ToString(FTabPeriodesID[cmbPeriodes.SelectedIndex]);
                string contenuSelection = cmbPeriodes.Items[cmbPeriodes.SelectedIndex].ToString();
                string[] tempoSplit;//Tableau temporaire pour le split.

                //La commande est exécutée et le résultat est ajouté à la liste.
                DataTable resultat = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherPeriodeSelonID", new string[] { FNomUtilisateur, FMotDePasse, idPeriode });

                if (FVientAjoutePeriode)
                {
                    cmbPeriodes.Items.RemoveAt(cmbPeriodes.Items.Count - 1);
                    FVientAjoutePeriode = false;
                }   
                
                //Le résultat est séparé pour être affiché correctement dans les textBox du formulaire.
                tempoSplit = resultat.Rows[0][2].ToString().Split(':');

                txtHeureDebut.Text = tempoSplit[0];
                txtMinuteDebut.Text = tempoSplit[1];


                tempoSplit = resultat.Rows[0][3].ToString().Split(':');

                txtHeureFin.Text = tempoSplit[0];
                txtMinuteFin.Text = tempoSplit[1];

                btnConfirmer.Enabled = true;
                btnSupp.Enabled = true;
                cmbPeriodes.Enabled = true;
                txtHeureDebut.Enabled = true;
                txtHeureFin.Enabled = true;
                txtMinuteDebut.Enabled = true;
                txtMinuteFin.Enabled = true;
            }
        }


        private void txtHeures_Click(object sender, EventArgs e)
        {
            TextBox txtActuel = (sender as TextBox);

            if (txtActuel.Text == "hh" || txtActuel.Text == "mm")
                txtActuel.Clear();
        }

        /// <summary>
        /// Vérifier si l'heure de début est correctement écrite.
        /// </summary>
        /// <returns>Retourne vrai txtHeureDebut est correctement écrit. Sinon, retourne faux.</returns>
        private bool VerifierHeureDebut()
        {
            return (txtHeureDebut.Text.Length >= 1 && (txtHeureDebut.Text != "hh") && (txtHeureDebut.Text != "h") &&
                   ((Convert.ToInt32(txtHeureDebut.Text) >= 0) || (Convert.ToInt32(txtHeureDebut.Text) <= 23)));   
        }

        /// <summary>
        /// Vérifier si l'heure de fin est correctement écrite.
        /// </summary>
        /// <returns>Retourne vrai txtHeureFin est correctement écrit. Sinon, retourne faux.</returns>
        private bool VerifierHeureFin()
        {
            return (txtHeureFin.Text.Length >= 1 && (txtHeureFin.Text != "hh") && (txtHeureFin.Text != "h") && 
                   ((Convert.ToInt32(txtHeureFin.Text) >= 0) || (Convert.ToInt32(txtHeureFin.Text) <= 23)));
        }

        /// <summary>
        /// Vérifier si les minutes du début sont correctement écrits.
        /// </summary>
        /// <returns>Retourne vrai txtMinuteDebut est correctement écrit. Sinon, retourne faux.</returns>
        private bool VerifierMinuteDebut()
        {
            return (txtMinuteDebut.Text.Length == 2 && (txtMinuteDebut.Text != "mm") && (txtMinuteDebut.Text != "m") && 
                   ((Convert.ToInt32(txtMinuteDebut.Text) >= 0) || (Convert.ToInt32(txtMinuteDebut.Text) <= 59)));
        }

        /// <summary>
        /// Vérifier si les minutes de fin sont correctement écrits.
        /// </summary>
        /// <returns>Retourne vrai txtMinuteFin est correctement écrit. Sinon, retourne faux.</returns>
        private bool VerifierMinuteFin()
        {
            return (txtMinuteFin.Text.Length == 2 && (txtMinuteFin.Text != "mm") && (txtMinuteFin.Text != "m") && 
                   ((Convert.ToInt32(txtMinuteFin.Text) >= 0) || (Convert.ToInt32(txtMinuteFin.Text) <= 59)));
        }

        /// <summary>
        /// Vérifie si l'heure de début est avant l'heure de fin.
        /// </summary>
        /// <returns>Retourne "vrai" si l'heure de début est avant l'heure de fin.</returns>
        private bool VerifierCoherenceHeure()
        {
            return (Convert.ToInt32(txtHeureDebut.Text) < Convert.ToInt32(txtHeureFin.Text)) ||
                   ((Convert.ToInt32(txtHeureDebut.Text) == Convert.ToInt32(txtHeureFin.Text)) &&
                    (Convert.ToInt32(txtMinuteDebut.Text) < Convert.ToInt32(txtMinuteFin.Text)));
        }
    }
}
