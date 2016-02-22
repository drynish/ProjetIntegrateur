/* Projet intégrateur 1 (frmCoordonnateur)

Travail sur les présences du centre d'aide en informatique du Cegep de Joliette

Fiche montrant toutes les options qu'un coordonnateur dispose 

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
    public partial class frmCoordonnateur : Form
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
        /// Constructeur obligatoire. On n'est pas supposé de l'initialiser.
        /// </summary>
        private frmCoordonnateur()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        /// <param name="_NomUtilisateur">Nom utilisateur du compte.</param>
        /// <param name="_MotDePasse">Mot de passe du compte.</param>
        public frmCoordonnateur(string _NomUtilisateur, string _MotDePasse)
        {
            FNomUtilisateur = _NomUtilisateur;
            FMotDePasse     = _MotDePasse;
            InitializeComponent();
        }

        /// <summary>
        /// Clique sur la grille Usagers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GVUsagers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
                //Si le clique est valide (dans les marges du tableau)
            {
                if (e.ColumnIndex == 4 || e.ColumnIndex == 5) 
                    //Clique pour confirmer l'état d'un utilisateur (élève/coordonnateur)
                {
                    GVUsagers.Rows[e.RowIndex].Cells[4].Value = false;
                    GVUsagers.Rows[e.RowIndex].Cells[5].Value = false;
                    GVUsagers.Rows[e.RowIndex].Cells[6].Value = false;

                    GVUsagers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
   
                    if (e.ColumnIndex == 4)
                        //Si l'usager est coordonnateur, on modifie ses droits

                        CExecuteur.ObtenirCExecuteur().ExecPs("spModifierDroits", new string[] { FNomUtilisateur, FMotDePasse, GVUsagers.Rows[e.RowIndex].Cells[0].Value.ToString(), "0" });
                    else
                    {
                        // S'il se met lui-même élève, on le déconnecte par la suite.
                        if (GVUsagers.Rows[e.RowIndex].Cells[1].Value.ToString() == FNomUtilisateur)
                        {
                            if (MessageBox.Show("Êtes-vous sûr de vouloir vous mettre élève? Cette opération entraînera une déconnexion immédiate et est irréversible.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                //Modifier les droits de l'utilisateur
                                CExecuteur.ObtenirCExecuteur().ExecPs("spModifierDroits", new string[] { FNomUtilisateur, FMotDePasse, GVUsagers.Rows[e.RowIndex].Cells[0].Value.ToString(), "1" });
                                Close();
                            }
                            else
                            {
                                //S'il ne veut pas se mettre élève, on annule les changements
                                GVUsagers.Rows[e.RowIndex].Cells[5].Value = false;
                                GVUsagers.Rows[e.RowIndex].Cells[4].Value = true;
                            }
                                
                        }
                        else
                            //S'il met un autre usager élève
                            CExecuteur.ObtenirCExecuteur().ExecPs("spModifierDroits", new string[] { FNomUtilisateur, FMotDePasse, GVUsagers.Rows[e.RowIndex].Cells[0].Value.ToString(), "1" });  
                    }
                }
                else if (e.ColumnIndex == 7) 
                    //S'il clique sur le bouton pour afficher la sélection d'horaire
                {
                    if (bool.Parse(GVUsagers.Rows[e.RowIndex].Cells[5].Value.ToString()))
                        //Si l'usager sélectionné est un élève
                    {
                        int id = Convert.ToInt32(GVUsagers.Rows[e.RowIndex].Cells[0].Value);
                        frmHoraireSel frmHorSel = new frmHoraireSel(FNomUtilisateur, FMotDePasse, id);
                        frmHorSel.ShowDialog(); //Afficher la forme
                    }
                    else
                        //Si l'usager sélectionné n'est pas un élève
                        MessageBox.Show("Vous pouvez choisir un horaire seulement pour un élève !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (e.ColumnIndex == 8)
                    //S'il clique sur un bouton pour supprimer un usager
                {
                    if (FNomUtilisateur != GVUsagers.Rows[e.RowIndex].Cells[1].Value.ToString()) 
                        //S'il ne se choisit pas lui même
                    {
                        //Supprimer l'usager et mettre à jour la grille
                        CExecuteur.ObtenirCExecuteur().ExecPs("spSupprimerEleve", new string[] { FNomUtilisateur, FMotDePasse, GVUsagers.Rows[e.RowIndex].Cells[0].Value.ToString()});
                        GVUsagers.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                        //S'il se choisit lui même
                        MessageBox.Show("Vous ne pouvez pas supprimer votre propre compte !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Afficher la fiche de la gestion des périodes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPeriodes_Click(object sender, EventArgs e)
        {
            frmPeriodes FrmPeriodes = new frmPeriodes(FNomUtilisateur, FMotDePasse);
            FrmPeriodes.ShowDialog();
        }

        /// <summary>
        /// Afficher les utilisateurs, les élèves pour les présences et le total d'heures des présences de tous les élèves
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCoordonnateur_Load(object sender, EventArgs e)
        {
            AfficherUtilisateurs();
            AfficherEleves();
            AfficherNbHeureTotal();
        }

        /// <summary>
        /// Afficher tous les utilisateurs dans GVUsagers
        /// </summary>
        private void AfficherUtilisateurs()
        {
            string[] TabParamIN    = new string[2];
            DataTable TableRequete = null;

            TabParamIN[0] = FNomUtilisateur;
            TabParamIN[1] = FMotDePasse;

            TableRequete = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherUsagers", TabParamIN); //Mettre tous les utilisateurs et leurs informations dans une table

            if (TableRequete != null)
                //S'il y a au moins un utilisateur
            {
                for (int i = 0; i < TableRequete.Rows.Count; i++)
                    //Pour tous les utilisateurs, afficher les informations dans la grille
                {
                    GVUsagers.Rows.Add();
                    GVUsagers.Rows[i].Cells[0].Value = TableRequete.Rows[i][0].ToString();
                    GVUsagers.Rows[i].Cells[1].Value = TableRequete.Rows[i][1].ToString();
                    GVUsagers.Rows[i].Cells[2].Value = TableRequete.Rows[i][2].ToString();
                    GVUsagers.Rows[i].Cells[3].Value = TableRequete.Rows[i][3].ToString();


                    //Selon le statut (élève, coordonnateur, non-déterminé), cocher la bonne case
                    if (TableRequete.Rows[i][4].ToString() == "-1")
                    {
                        GVUsagers.Rows[i].Cells[4].Value = false;
                        GVUsagers.Rows[i].Cells[5].Value = false;
                        GVUsagers.Rows[i].Cells[6].Value = true;
                    }
                    else if (TableRequete.Rows[i][4].ToString() == "1")
                    {
                        GVUsagers.Rows[i].Cells[4].Value = false;
                        GVUsagers.Rows[i].Cells[5].Value = true;
                        GVUsagers.Rows[i].Cells[6].Value = false;
                    }
                    else if (TableRequete.Rows[i][4].ToString() == "0")
                    {
                        GVUsagers.Rows[i].Cells[4].Value = true;
                        GVUsagers.Rows[i].Cells[5].Value = false;
                        GVUsagers.Rows[i].Cells[6].Value = false;
                    }
                }
            }

        }

        /// <summary>
        /// Afficher tous les élèves dans GVPresences
        /// </summary>
        
        private void AfficherEleves()
        {
            string[] TabParamIN    = new string[2];
            DataTable TableRequete = null;

            TabParamIN[0] = FNomUtilisateur;
            TabParamIN[1] = FMotDePasse;

            TableRequete = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherEleves", TabParamIN); //Mettre tous les élèves et leurs informations dans une table

            if (TableRequete != null)
            {
                // Pour chaque élève, afficher leurs informations dans la grille
                for (int i = 0; i < TableRequete.Rows.Count; i++)
                {
                    GVPresences.Rows.Add();
                    GVPresences.Rows[i].Cells[0].Value = TableRequete.Rows[i][0].ToString();
                    GVPresences.Rows[i].Cells[1].Value = TableRequete.Rows[i][1].ToString();
                    GVPresences.Rows[i].Cells[2].Value = TableRequete.Rows[i][2].ToString();
                    GVPresences.Rows[i].Cells[3].Value = TableRequete.Rows[i][3].ToString();
                }
            }
            
        }

        /// <summary>
        /// Clique sur la grille Presences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GVPresences_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 4)
                //Si le clique est valide 
            { 
                //Afficher la forme qui montre les présences passées de cet élève
                frmPresences FrmPresences = new frmPresences(GVPresences.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + GVPresences.Rows[e.RowIndex].Cells[3].Value.ToString(), GVPresences.Rows[e.RowIndex].Cells[0].Value.ToString(), FNomUtilisateur, FMotDePasse);
                FrmPresences.ShowDialog();
            }      
        }

        /// <summary>
        /// Afficher le nombre d'heures total de tous les élèves.
        /// </summary>
        private void AfficherNbHeureTotal()
        {
            string[] TabParamIN    = new string[2];
            DataTable TableRequete = null;

            TabParamIN[0] = FNomUtilisateur;
            TabParamIN[1] = FMotDePasse;

            TableRequete = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherHeuresTous", TabParamIN); //Mettre le total d'heures dans une table

            if (TableRequete != null) //Si un total existe
                LblTotal.Text = TableRequete.Rows[0][0].ToString(); // Afficher le nombre total d'heures
            else
                LblTotal.Text = "0"; //Afficher qu'il y a 0 heure d'inscrit 
        }
    }
}
