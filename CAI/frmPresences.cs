/* Projet intégrateur 1 (frmPresences)

    Travail sur les présences du centre d'aide en informatique du Cegep de Joliette

    Fiche montrant toutes les présences passées des élèves

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
using System.Windows.Forms;

namespace CAI
{
    /// <summary>
    /// Représente la forme pour l'affichage des présences passées pour un élève.
    /// </summary>
    public partial class frmPresences : Form
    {
        /// <summary>
        /// Représente l'id de l'étudiant
        /// </summary>
        private string FID;
        /// <summary>
        /// Représente le nom d'utilisateur de l'usager connecté
        /// </summary>
        private string FNomUtilisateur;
        /// <summary>
        /// Représente le mot de passe de l'usager connecté
        /// </summary>
        private string FMDP;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="_nom"></param>
        /// <param name="_id"></param>
        /// <param name="_NomUtilisateur"></param>
        /// <param name="_MDP"></param>

        public frmPresences(string _nom, string _id, string _NomUtilisateur, string _MDP)
        {
            InitializeComponent();

            this.Text = this.Text + " " + _nom; //Affiche le nom de l'élève dans le texte de la fenêtre
            FID = _id;
            FNomUtilisateur = _NomUtilisateur;
            FMDP = _MDP;
        }

        /// <summary>
        /// Afficher les présences passées d'un élève et son total d'heures
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPresences_Load(object sender, EventArgs e)
        {
            AfficherPresences();
            AfficherTotal();
        }

        /// <summary>
        /// Afficher les présences passées d'un élève
        /// </summary>
        private void AfficherPresences()
        {

            string[] paramIN = new string[3];

            paramIN[0] = FNomUtilisateur;
            paramIN[1] = FMDP;
            paramIN[2] = FID;

            DataTable TableRequete = new DataTable();
            TableRequete = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherPresencesPasses", paramIN); //Mettre dans une table le résultat de la requête

            if (TableRequete != null)
            {
                //Pour toutes les présences passées
                for (int i = 0; i < TableRequete.Rows.Count; i++)
                {
                    //Afficher dans la grille les informations relatives aux présences
                    GVPresences.Rows.Add();
                    GVPresences.Rows[i].Cells[0].Value = TableRequete.Rows[i][0].ToString();
                    GVPresences.Rows[i].Cells[1].Value = TableRequete.Rows[i][1].ToString();
                    GVPresences.Rows[i].Cells[2].Value = TableRequete.Rows[i][2].ToString();
                    GVPresences.Rows[i].Cells[3].Value = TableRequete.Rows[i][3].ToString();
                    GVPresences.Rows[i].Cells[4].Value = TableRequete.Rows[i][4].ToString();
                    GVPresences.Rows[i].Cells[5].Value = TableRequete.Rows[i][5].ToString();
                }
            }

         }

        /// <summary>
        /// Afficher le total d'heures des présences passées pour un élève
        /// </summary>
        private void AfficherTotal()
        {
            string[] paramIN = new string[3];

            paramIN[0] = FNomUtilisateur;
            paramIN[1] = FMDP;
            paramIN[2] = FID;

            DataTable TableRequete = new DataTable();
            TableRequete = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherHeuresEleve", paramIN); //Mettre dans une table le résultat de la requête

            if (TableRequete != null)
                lblTotal.Text = TableRequete.Rows[0][0].ToString(); // Afficher dans un label le nombre total d'heures pour cet élève
            else
                lblTotal.Text = "0";

        }
    }
}
