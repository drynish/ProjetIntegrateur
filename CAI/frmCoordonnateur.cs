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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4)
                {
                    GVUsagers.Rows[e.RowIndex].Cells[2].Value = false;
                    GVUsagers.Rows[e.RowIndex].Cells[3].Value = false;
                    GVUsagers.Rows[e.RowIndex].Cells[4].Value = false;

                    GVUsagers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                else if (e.ColumnIndex == 5)
                {
                    frmHoraireSel frmHorSel = new frmHoraireSel();
                    frmHorSel.ShowDialog();
                   
                }


            }
        }

        private void btnPeriodes_Click(object sender, EventArgs e)
        {
            frmPeriodes frmPeriodes = new frmPeriodes();
            frmPeriodes.ShowDialog();
        }
    }
}
