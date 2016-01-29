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
            GVUsagers.Rows[e.RowIndex].Cells[2].Value = false;
            GVUsagers.Rows[e.RowIndex].Cells[3].Value = false;
            GVUsagers.Rows[e.RowIndex].Cells[4].Value = false;

            GVUsagers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
        }
    }
}
