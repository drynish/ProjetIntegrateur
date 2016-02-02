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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Objectif : Afficher la forme pour modifier son mot de passe. Cacher la forme actuelle.
            frmMotDePasse frmMDP = new frmMotDePasse();
            frmMDP.AccRefConnect = this;
            this.Hide();
            frmMDP.Show();
           
        }

        private void btnCreation_Click(object sender, EventArgs e)
        {
            frmCreation frmCreation = new frmCreation();
            frmCreation.AccRefCreation = this;
            this.Hide();
            frmCreation.Show();
        }

        private void btnConnect_Click(object sender, EventArgs e) 
        {

            if (txtNom.Text != "" && txtMDP.Text != "") 
            {
                frmCheck frmCreation = new frmCheck();
                this.Hide();
                frmCreation.Show();
            }
            else
                MessageBox.Show("Veuillez entrer votre nom et votre mot de passe !");
            
        }
    }
}