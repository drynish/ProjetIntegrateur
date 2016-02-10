﻿using System;
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

        public frmCoordonnateur()
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

        private void GVUsagers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
                {
                    GVUsagers.Rows[e.RowIndex].Cells[3].Value = false;
                    GVUsagers.Rows[e.RowIndex].Cells[4].Value = false;
                    GVUsagers.Rows[e.RowIndex].Cells[5].Value = false;

                    GVUsagers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                else if (e.ColumnIndex == 6)
                {
                    frmHoraireSel frmHorSel = new frmHoraireSel(FNomUtilisateur, FMotDePasse);
                    frmHorSel.ShowDialog();
                   
                }


            }
        }

        private void btnPeriodes_Click(object sender, EventArgs e)
        {
            frmPeriodes frmPeriodes = new frmPeriodes();
            frmPeriodes.ShowDialog();
        }

        private void frmCoordonnateur_Load(object sender, EventArgs e)
        {
            string[] paramIN = new string[2];

            paramIN[0] = FNomUtilisateur;
            paramIN[1] = FMotDePasse;
            DataTable TableRequete = new DataTable();
            TableRequete = CExecuteur.ObtenirCExecuteur().ExecPs("spAfficherUsagers", paramIN);

            for (int i = 0; i < TableRequete.Rows.Count; i++)
            {
                GVUsagers.Rows.Add();
                GVUsagers.Rows[i].Cells[0].Value = TableRequete.Rows[i][0].ToString();
                GVUsagers.Rows[i].Cells[1].Value = TableRequete.Rows[i][1].ToString();
                GVUsagers.Rows[i].Cells[2].Value = TableRequete.Rows[i][2].ToString();

                if (TableRequete.Rows[i][3].ToString() == "-1")
                {
                    GVUsagers.Rows[i].Cells[3].Value = false;
                    GVUsagers.Rows[i].Cells[4].Value = false;
                    GVUsagers.Rows[i].Cells[5].Value = true;
                }
                else if (TableRequete.Rows[i][3].ToString() == "1")
                {
                    GVUsagers.Rows[i].Cells[3].Value = false;
                    GVUsagers.Rows[i].Cells[4].Value = true;
                    GVUsagers.Rows[i].Cells[5].Value = false;
                }
                else if (TableRequete.Rows[i][3].ToString() == "0")
                {
                    GVUsagers.Rows[i].Cells[3].Value = true;
                    GVUsagers.Rows[i].Cells[4].Value = false;
                    GVUsagers.Rows[i].Cells[5].Value = false;
                }
            }
        }
    }
}
