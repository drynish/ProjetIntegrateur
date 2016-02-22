/* Projet intégrateur 1 (frmPresences)

    Travail sur les présences du centre d'aide en informatique du Cegep de Joliette

    Fiche permettant de faire la gestion des présences requises pour un élève.

    Fait par :

    -Antoine Monzerol
    -Félix Roy
    -Jonathan Clavet-Grenier
    -Alexandre Gratton
    -Samuel Nadeau

    Contact : 514-475-2623
*/

using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CAI
{
    /// <summary>
    /// Fiche permettant de faire la gestion des présences requises pour un élève.
    /// </summary>
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
        /// ID du compte sélectionné pour choisir ses présences requises.
        /// </summary>
        private int FID;

        /// <summary>
        /// Constructeur par défaut. Initialiser les données membres et sauvegarder celles-ci.
        /// </summary>
        /// <param name="_NomUtilisateur">Nom d'utilisateur du compte connecté présentement.</param>
        /// <param name="_MotDePasse">Mot de passe du compte connecté présentement.</param>
        /// <param name="_Id">Représente l'ID de l'utilisateur sélectionné pour qu'on sélectionne son horaire.</param>
        public frmHoraireSel(string _NomUtilisateur, string _MotDePasse, int _Id)
        {
            FNomUtilisateur = _NomUtilisateur;
            FMotDePasse     = _MotDePasse;
            FID             = _Id;

            InitializeComponent();
        }
        /// <summary>
        /// Bouton pour confirmer les présences sélectionnées.
        /// Suppression des présences déjà enregistrées pour ne pas créer de conflits.
        /// Ajout dans la base de données les présences pour l'élève.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Suppressions des présences requises déjà en place
            CExecuteur.ObtenirCExecuteur().ExecPs("spSupprimerPresenceRequise", new string[] { FNomUtilisateur, FMotDePasse, Convert.ToString(FID) });

            //Boucle sur tous les contrôles de la forme pour trouver les checkbox
            foreach (Control Chb in Controls)
            {
                if (Chb is CheckBox)
                {
                    /* Si le checkbox est sélectionné,
                        Créer un array qui contient toutes les informations à ajouter dans la db
                        appeler la méthode du Executeur pour ajouter dans la db avec les paramètres en array
                    */
                    if ((Chb as CheckBox).Checked)
                    {
                        string[] TabParametres = new string[5]; // Array de paramètres que l'on envoit à la procédure stockée.
                        string strPeriode = Regex.Match(Chb.Name, @"\d+").Value;
                        strPeriode = strPeriode.ToString();  //Conversion du nom du checkbox en string période
                        TabParametres[0] = FNomUtilisateur;  //Nom d'utilisateur
                        TabParametres[1] = FMotDePasse;  //Mot de passe
                        TabParametres[2] = FID.ToString();  //ID de l'élève en string
                        TabParametres[3] = Chb.Tag.ToString();  //La journée
                        TabParametres[4] = strPeriode;  //La période
                        CExecuteur.ObtenirCExecuteur().ExecPs("spAjouterPresenceRequise", TabParametres);  //Ajout dans la bd
                    }
                }
            }

            //Afficher un message de confirmation
            MessageBox.Show("Les présences ont été sauvegardés avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        /// <summary>
        /// Afficher les checkbox lors du chargement de la forme
        /// Afficher les présences déjà enregristrées lors du chargement de la forme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHoraireSel_Load(object sender, EventArgs e)
        {

            AfficherBoites();
            AfficherPresences();
        }

        /// <summary>
        /// Affichage des checkbox selon le nombre de périodes par jour
        /// Passage du nom d'utilisateur et du mot de passe pour s'assurer que l'uttilisateur qui veut voir les présences
        /// est bien un admin et non un élève
        /// </summary>

        private void AfficherBoites()
        {
            string[] paramIN = new string[2];  //Array de paramètres pour la procédure stockée

            int RatioPosition = 75;  //Ratio pour la position initiale des checkbox
            paramIN[0] = FNomUtilisateur;  //Nom d'utilisateur
            paramIN[1] = FMotDePasse;  //Mot de passe
            DataTable TableRequete = new DataTable();  //DataTable pour recevoir les infos de la bd
            TableRequete = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherPeriodes", paramIN);  //Exécuter la procédure stockée avec les paramètres


            //Si la requête retourne au moins 1 enregistrement
            if (TableRequete != null)
            {
                //Ajustement de la largeur de la forme et du bouton confirmer selon le nombre de périodes
                int Largeur = (25 * TableRequete.Rows.Count);
                Width = (Largeur + 86);
                btnConfirm.Width = (Width - 26);

                //boucle pour chaque ligne de la requête IE : le nombre de périodes par jour
                for (int i = 0; i < TableRequete.Rows.Count; i++)
                {
                    Label Periode = new Label();  //le label pour afficher le numéro de la période

                    //ajout de 5 checkbox pour chacune des journées de la semaine
                    CheckBox Lundi = new CheckBox();
                    CheckBox Mardi = new CheckBox();
                    CheckBox Mercredi = new CheckBox();
                    CheckBox Jeudi = new CheckBox();
                    CheckBox Vendredi = new CheckBox();

                    //propriétés des labels Période
                    Periode.Name = "lblPeriode" + TableRequete.Rows[i][1].ToString();
                    Periode.Location = new Point(RatioPosition + (i * 25), 9);
                    Periode.Text = (i + 1).ToString();
                    Periode.AutoSize = true;

                    //Propriétés des checkbox
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

                    //Positionnement des checkbox
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


                    //Ajout des contrôles
                    Controls.Add(Periode);
                    Controls.Add(Lundi);
                    Controls.Add(Mardi);
                    Controls.Add(Mercredi);
                    Controls.Add(Jeudi);
                    Controls.Add(Vendredi);

                }

            }

            else
            {
                //erreur de connexion avec la bd
                MessageBox.Show("Une erreur inconnue est survenu. Veuillez réessayer plus tard.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }    
            
        }

        /// <summary>
        /// Affichage des présences selon les infos dans la base de données
        /// </summary>
        private void AfficherPresences()
        {
            string BoxToCheck;  //String pour la concaténation sur le nom du checkbox à cocher
            string[] paramIN = new string[1];  //array de paramètres pour la requête sur la base de données
            paramIN[0] = FID.ToString();  //ID de l'élève pour l'affichage des bonnes périodes
            DataTable TableRequete = new DataTable();  //DataTable pour recevoir les infos de la bd
            TableRequete = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherPresencesRequisesDeUnEleveSelonID", paramIN); //Exécuter la procédure stockée avec les paramètres

            if (TableRequete != null)
            {
                //boucle sur chaque ligne de la requête
                for (int i = 0; i < TableRequete.Rows.Count; i++)
                {
                    /* La procédure stockée retourne la journée et la période
                       sur chaque ligne, vérifier quelle journée est sélectionnée
                       pour la journée sélectionnée, concaténer le nom du checkbox selon la période
                       cocher la bonne checkbox selon son nom
                    */

                    BoxToCheck = "ChB" + TableRequete.Rows[i][0].ToString() + TableRequete.Rows[i][1].ToString();
                    Control[] Chb = this.Controls.Find(BoxToCheck, false);
                    (Chb[0] as CheckBox).Checked = true;

                }
            }

        }
    }

}
