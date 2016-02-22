﻿using System;
using System.Windows.Forms;

namespace CAI
{
    /// <summary>
    /// Classe permettant de réinitialiser son mot de passe.
    /// </summary>
    public partial class frmMotDePasse : Form
    {
        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public frmMotDePasse()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            const string MSG_OUBLIE_MDP = "-1"; // Représente le code d'erreur qui représente un mot de passe oublié
            const string MSG_SUCCES     = "1";  // Représente le code d'erreur qui représente le succès

            if (txtNom.TextLength != 0 || txtMDPActuel.TextLength < 8)
            {
                if (txtMDP.TextLength >= 8 && txtMDP.TextLength <= 40) {
                    string[] TabParamIN = new string[4];
                    bool[] TabParamOUT = new bool[4];

                    TabParamIN[0] = txtNom.Text;
                    TabParamIN[1] = txtMDPActuel.Text;
                    TabParamIN[2] = txtMDP.Text;
                    TabParamIN[3] = "0";

                    TabParamOUT[0] = false;
                    TabParamOUT[1] = false;
                    TabParamOUT[2] = false;
                    TabParamOUT[3] = true;

                    // Exécution de la procédure pour changer le mot de passe.
                    CExecuteur.ObtenirCExecuteur().ExecPs("spChangerMDP", ref TabParamIN, TabParamOUT);

                    // Si ça n'a pas fonctionné à cause que l'utilisateur et/ou mot de passe ne concorde pas
                    switch (TabParamIN[3])
                    {
                        // Si ça n'a pas fonctionné à cause de l'utilisateur et/ou mot de passe
                        case MSG_OUBLIE_MDP:
                            txtMDP.Text = "";
                            txtMDPActuel.Text = "";
                            txtNom.Text = "";
                            MessageBox.Show("Mauvais nom d'utilisateur et/ou mot de passe. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        // Si ça la fonctionné
                        case MSG_SUCCES:
                            MessageBox.Show("Votre mot de passe a été changé.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                            break;
                        default:
                            txtMDP.Text = "";
                            txtMDPActuel.Text = "";
                            txtNom.Text = "";
                            MessageBox.Show("Une erreur inconnue est survenue. Veuillez réessayer plus tard.");
                            break;
                    }
                }
                else
                    MessageBox.Show("Votre mot de passe doit contenir au moins 8 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Veuillez entrer votre courriel et/ou votre mot de passe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
