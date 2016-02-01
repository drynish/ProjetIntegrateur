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
    public partial class frmHoraireSel : Form
    {
        DateTime horaire; 
        public frmHoraireSel()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            /*
            string strHoraire = ""; 

            if (chkLundi.Checked)
                strHoraire = strHoraire + " Lundi " + cmbDebutLundi.Text + " à " + cmbFinLundi.Text;
            if (chkMardi.Checked)
                strHoraire = strHoraire +  " Mardi " + cmbDebutMardi.Text + " à " + cmbFinMardi.Text;
            if (chkMercredi.Checked)
                strHoraire = strHoraire + " Mercredi " + cmbDebutMercredi.Text + " à " + cmbFinMercredi.Text;
            if (chkJeudi.Checked)
                strHoraire = strHoraire + " Jeudi " + cmbDebutJeudi.Text + " à " + cmbFinJeudi.Text;
            if (chkVendredi.Checked)
                strHoraire = strHoraire +  " Vendredi " + cmbDebutVendredi.Text + " à " + cmbFinVendredi.Text;

            horaire = Convert.ToDateTime(strHoraire);
            
            this.Dispose();*/
        }

        public DateTime AccHoraire 
        {
            get
            {
                return horaire;
            }
        }

        private void frmHoraireSel_Load(object sender, EventArgs e) 
        {
            cmbJours.Items.Add("Lundi");
            cmbJours.Items.Add("Mardi");
            cmbJours.Items.Add("Mercredi");
            cmbJours.Items.Add("Jeudi");
            cmbJours.Items.Add("Vendredi");

            cmbJours.SelectedIndex = 0;
 
        }
    }
}
