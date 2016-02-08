using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CAI
{
    public partial class frmPeriodes : Form
    {
        public frmPeriodes()
        {
            InitializeComponent();
        }

        private void frmPeriodes_Load(object sender, EventArgs e) 
        {
            //List<string> entreesPeriodes = new List<String>(); //Les périodes se trouvant dans la base de donnée.

            //La commande est exécutée et le résultat est ajouté à la liste.
            using (SqlCommand commande = new SqlCommand())
            {
                //con.Open();
                using (SqlDataReader resultat = commande.ExecuteReader())
                {
                    string texteListe = "";

                    while (resultat.Read())
                    {
                        texteListe = resultat.GetInt32(0) + ". " + resultat.GetString(1) + " à " + resultat.GetString(2);
                        cmbPeriodes.Items.Add(texteListe);
                    }
                }
            }

            //Le premier élément est sélectionné.
            cmbPeriodes.SelectedIndex = 0;

        }



        //MÉTHODES
        /// <summary>
        /// Gère les touches entrées au clavier pour permettre uniquement les chiffres et le retour en arrière.
        /// </summary>
        /// <param name="sender">Le contrôle graphique qui a déclancher l'appel</param>
        /// <param name="e"></param>
        public void gererTouchesPeriodes(object sender, EventArgs e)
        {
            KeyEventArgs ke = (KeyEventArgs)e;

            //allows backspace key
            if (ke.KeyValue != '\b')
            {
                //allows just number keys
                ke.Handled = !char.IsNumber((char)ke.KeyValue);
            }
        }


        /// <summary>
        /// Vérifie si l'heure entrée est valide. (Sur un format de 24h).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void verifierHeures(object sender, EventArgs e)
        {
            TextBox txtSource = (TextBox)sender;

            //Si l'heure entrée est plus petite que 0 et plus grande que 23,
            //un message est affiché, et la valeur est retirée.
            if ((Convert.ToInt32(txtSource.Text) < 0) || (Convert.ToInt32(txtSource.Text) > 23))
            {
                MessageBox.Show("L'heure doit se situer entre 0 et 23 (inclusivement)");
                txtSource.Text = "";
            }
        }


        /// <summary>
        /// Vérifie si les minutes entrées est valide..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void verifierMinutes(object sender, EventArgs e)
        {
            TextBox txtSource = (TextBox)sender;

            //Si l'heure entrée est plus petite que 0 et plus grande que 23,
            //un message est affiché, et la valeur est retirée.
            if ((Convert.ToInt32(txtSource.Text) < 0) || (Convert.ToInt32(txtSource.Text) > 59))
            {
                MessageBox.Show("Le nombre de minutes doit se situer entre 0 et 59 (inclusivement)");
                txtSource.Text = "";
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {

        }

        private void btnSupp_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {

        }
    }
}
