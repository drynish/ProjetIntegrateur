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
        string FNomUtilisateur = "f";
        string FMotDePasse = "f";
        List<string> FIdPeriodes = new List<string>();

        public frmPeriodes()
        {
            InitializeComponent();
        }
  
        public frmPeriodes(string _NomUtilisateur, string _MotDePasse)
        {
            FNomUtilisateur = _NomUtilisateur;
            FMotDePasse = _MotDePasse;
            InitializeComponent();

            lblInformation.Text = "";
        }

        private void frmPeriodes_Load(object sender, EventArgs e) 
        {
            chargerPeriodes();
        }

        private void gererTouchesPeriodes(object sender, KeyPressEventArgs e)
        {
            //allows backspace key
            if (e.KeyChar != '\b')
            {
                //allows just number keys
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }

   

        /// <summary>
        /// Vérifie si l'heure entrée est valide. (Sur un format de 24h).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void verifierHeures(object sender, EventArgs e)
            {
            TextBox txtSource = (TextBox)sender;

            //Si l'heure entrée est plus petite que 0 et plus grande que 23,
            //un message est affiché, et la valeur est retirée.
            if (txtSource.Text.Length == 2)
            {
                if ((Convert.ToInt32(txtSource.Text) < 0) || (Convert.ToInt32(txtSource.Text) > 23))
                {
                    MessageBox.Show("L'heure doit se situer entre 0 et 23 (inclusivement)");
                    txtSource.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Les boîtes de textes doivent contenir deux caractères.");
            }
        }


        /// <summary>
        /// Vérifie si les minutes entrées est valide..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void verifierMinutes(object sender, EventArgs e)
        {
            TextBox txtSource = (TextBox)sender;

            //Si l'heure entrée est plus petite que 0 et plus grande que 23,
            //un message est affiché, et la valeur est retirée.
            if (txtSource.Text.Length == 2)
            {
                if ((Convert.ToInt32(txtSource.Text) < 0) || (Convert.ToInt32(txtSource.Text) > 59))
                {
                    MessageBox.Show("Le nombre de minutes doit se situer entre 0 et 59 (inclusivement)");
                    txtSource.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Les boîtes de textes doivent contenir deux caractères.");
            }
        }

        /// <summary>
        /// Appelle le script de supression de la dernière période.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (cmbPeriodes.Items.Count > 0)
            {
                //Contiens le id du dernier item de la comboBox.
                string idDernierePeriode = cmbPeriodes.Items[cmbPeriodes.Items.Count - 1].ToString();
                string[] tempoSplit;//Tableau temporaire pour le split.

                //La chaîne est séparé et seul le id est gardé.
                tempoSplit = idDernierePeriode.Split('.');
                idDernierePeriode = tempoSplit[0];

                //La commande de suppression est exécutée.
                CExecuteur.ObtenirCExecuteur().ExecPs("spSupprimerPeriode", new string[] { FNomUtilisateur, FMotDePasse });

                //Les périodes sont rechargées.
                chargerPeriodes();

                //Le message de confirmation est mis à jour.
                lblInformation.Text = "La période #" + idDernierePeriode + " à été supprimée.";
            }
            else
            {
                lblInformation.Text = "Il n'y a aucune période à supprimer.";
            }

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
            string heureDebut; //Nouvelle heure de début de la période.
            string heureFin; //Nouvelle heure de fin de la période.

            heureDebut = txtHeureDebut.Text + ":" + txtMinuteDebut.Text;
            heureFin = txtHeureFin.Text + ":" + txtMinuteFin.Text;

            //La commande d'ajout est exécutée.
            if (verificationCoherenceHeure())
            {
                CExecuteur.ObtenirCExecuteur().ExecPs("spAjouterPeriode", new string[] { FNomUtilisateur, FMotDePasse, heureDebut, heureFin });

                //Les périodes sont rechargées.
                chargerPeriodes();
            }
        }



        /// <summary>
        /// Charge les périodes dans le comboBox.
        /// </summary>
        private void chargerPeriodes()
        {
            //La commande est exécutée et le résultat est ajouté à la liste.
            DataTable resultat = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherPeriodes", new string[] { FNomUtilisateur, FMotDePasse });

            string texteListe = "";

            if (resultat != null)
            {
                for (int i = 0; i < resultat.Rows.Count; i++)
                {
                    FIdPeriodes.Add(resultat.Rows[i][0].ToString());
                    texteListe = (i + 1) + ". " + resultat.Rows[i][1] + " à " + resultat.Rows[i][2];
                    cmbPeriodes.Items.Add(texteListe);
                }
            }

            //Le premier élément est sélectionné.
            cmbPeriodes.SelectedIndex = 0;
        }


        /// <summary>
        /// Appelle le script de modification des périodes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdModifier_Click(object sender, EventArgs e)
        {
            if (cmbPeriodes.Items.Count > 0)
            {
                if (
                (txtHeureDebut.Text != "") &&
                (txtHeureFin.Text != "") &&
                (txtMinuteDebut.Text != "") &&
                (txtMinuteFin.Text != "") 
                )
                {
                    if (verificationCoherenceHeure())
                    {
                        //Contiens le id du dernier item de la comboBox.
                        int idPeriode = cmbPeriodes.SelectedIndex;
                        string heureDebut; //Nouvelle heure de début de la période.
                        string heureFin; //Nouvelle heure de fin de la période.

                        heureDebut = txtHeureDebut.Text + ":" + txtMinuteDebut.Text;
                        heureFin = txtHeureFin.Text + ":" + txtMinuteFin.Text;

                        //La commande de suppression est exécutée.
                        CExecuteur.ObtenirCExecuteur().ExecPs("spModifierPeriode", new string[] { FNomUtilisateur, FMotDePasse, heureDebut, heureFin, idPeriode.ToString() });

                        //Le message de confirmation est affiché.
                        lblInformation.Text = "La période #" + FIdPeriodes[idPeriode] + " à été mis à jour.";

                        //Les périodes sont rechargées.
                        chargerPeriodes();
                    }
                }
                else
                {
                    lblInformation.Text = "Tous les blocs de temps doivent être remplis.";
                }
            }
            else
            {
                lblInformation.Text = "Il n'y a aucune période à modifier.";
            }
}


        

        private void cmbPeriodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idPeriode = FIdPeriodes[cmbPeriodes.SelectedIndex];
            string contenuSelection = cmbPeriodes.Items[cmbPeriodes.SelectedIndex].ToString();
            string[] tempoSplit;//Tableau temporaire pour le split.

            //La chaîne est séparé et seul le id est gardé.
            //tempoSplit = contenuSelection.Split('.');
            

            //La commande d'obtension de période est exécutée.

            //La commande est exécutée et le résultat est ajouté à la liste.
            DataTable resultat = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherPeriodeSelonID", new string[] { FNomUtilisateur, FMotDePasse, idPeriode });

            //Le résultat est séparé pour être affiché correctement dans les textBox du formulaire.
            tempoSplit = resultat.Rows[0][1].ToString().Split(':');

            txtHeureDebut.Text = tempoSplit[0];
            txtMinuteDebut.Text = tempoSplit[1];


            tempoSplit = resultat.Rows[0][2].ToString().Split(':');

            txtHeureFin.Text = tempoSplit[0];
            txtMinuteFin.Text = tempoSplit[1];

        }


        private void txtHeureDebut_Click(object sender, EventArgs e)
        {
            /*TextBox txtActuel = (sender as TextBox);

            if (txtActuel.Text == "hh" || txtActuel.Text == "mm")
                txtActuel.Clear();*/
        }

        private void btnSupp_Leave(object sender, EventArgs e)
        {
            lblInformation.Text = "";
        }

        private void btnAjouter_Leave(object sender, EventArgs e)
        {
            lblInformation.Text = "";
        }

        private void cmdModifier_Leave(object sender, EventArgs e)
        {
            lblInformation.Text = "";
        }


        /// <summary>
        /// Vérifie si l'heure de début est avant l'heure de fin.
        /// Retourne "vrai" si l'heure de début est avant l'heure de fin.
        /// </summary>
        /// <returns></returns>
        private bool verificationCoherenceHeure()
        {
            bool estCoherent = true;

            if (Convert.ToInt32(txtHeureDebut.Text) <= Convert.ToInt32(txtHeureFin.Text))
            {
                if (
                    Convert.ToInt32(txtHeureDebut.Text) == Convert.ToInt32(txtHeureFin.Text) &&
                    Convert.ToInt32(txtMinuteDebut.Text) >= Convert.ToInt32(txtMinuteFin.Text)
                    )
                {
                    MessageBox.Show("L'heure de fin doit être plus tard que l'heure de début.");
                    txtMinuteFin.Text = "";
                    estCoherent = false;
                }
            }

            return estCoherent;
        }
    }
}
