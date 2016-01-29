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
        string horaire;
        public frmHoraireSel()
        {
            InitializeComponent();
        }

        private void frmHoraireSel_Load(object sender, EventArgs e)
        {
            string min = "00";
            string heure = "08";
            foreach (var comboBox in this.Controls.OfType<ComboBox>())
            {
                while (Convert.ToInt32(heure) < 19)
                {
                    if (min == "60")
                    {
                        min = "00";
                        heure = (Convert.ToInt32(heure) + 1).ToString();
                    }
                    comboBox.Items.Add(heure + ":" + min );
                    comboBox.SelectedIndex = 0;
                    
                    min = (Convert.ToInt32(min) + 30).ToString(); ;
                }

                heure = "08";
                min = "00";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (chkLundi.Checked)
                horaire = horaire + " Lundi " + cmbDebutLundi.Text + " à " + cmbFinLundi.Text;
            if (chkMardi.Checked)
                horaire = horaire +  " Mardi " + cmbDebutMardi.Text + " à " + cmbFinMardi.Text;
            if (chkMercredi.Checked)
                horaire = horaire + " Mercredi " + cmbDebutMercredi.Text + " à " + cmbFinMercredi.Text;
            if (chkJeudi.Checked)
                horaire = horaire + " Jeudi " + cmbDebutJeudi.Text + " à " + cmbFinJeudi.Text;
            if (chkVendredi.Checked)
                horaire = horaire +  " Vendredi " + cmbDebutVendredi.Text + " à " + cmbFinVendredi.Text;

            
            this.Dispose();
        }

        public string AccHoraire
        {
            get
            {
                return horaire;
            }
        }
    }
}
