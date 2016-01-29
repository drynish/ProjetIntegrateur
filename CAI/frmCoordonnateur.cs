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
        public frmCoordonnateur()
        {
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
                else if (e.ColumnIndex == 6)
                {
                    frmHoraireSel frmHorSel = new frmHoraireSel();
                    frmHorSel.ShowDialog();

                    GVUsagers.Rows[e.RowIndex].Cells[5].Value = frmHorSel.AccHoraire;
                   
                }


            }
        }
    }
}
