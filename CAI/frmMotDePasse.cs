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
    public partial class frmMotDePasse : Form
    {
        frmLogin RefAFrmConnection;
        public frmMotDePasse()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //Objectif : Détruite cette fenêtre et revenir à la fenêtre principale.
            this.Dispose();
            this.RefAFrmConnection.Show();
        }

        public frmLogin AccRefConnect
        {
            get { return RefAFrmConnection; }
            set { RefAFrmConnection = value; }

        }
    }
}
