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
    public partial class frmCreation : Form
    {
        frmMain RefAFrmCreation;

        public frmCreation()
        {
            InitializeComponent();
        }
        public frmMain AccRefCreation
        {
            get { return RefAFrmCreation; }
            set { RefAFrmCreation = value; }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //Objectif : Détruite cette fenêtre et revenir à la fenêtre principale.
            this.Dispose();
            this.RefAFrmCreation.Show();
        }
    }
}
