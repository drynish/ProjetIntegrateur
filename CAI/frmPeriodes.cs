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
    public partial class frmPeriodes : Form
    {
        public frmPeriodes()
        {
            InitializeComponent();
        }

        private void frmPeriodes_Load(object sender, EventArgs e) 
        {

            cmbPeriodes.SelectedIndex = 0;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows backspace key
            if (e.KeyChar != '\b')
            {
                //allows just number keys
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }
    }
}
