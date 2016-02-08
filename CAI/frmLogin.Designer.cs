namespace CAI
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCreation = new System.Windows.Forms.Button();
            this.btnNouveauMDP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(84, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom d\'utilisateur";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 32);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mot de passe";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(102, 6);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(147, 20);
            this.txtNom.TabIndex = 2;
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(102, 29);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.PasswordChar = '*';
            this.txtMDP.Size = new System.Drawing.Size(147, 20);
            this.txtMDP.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(15, 55);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connectez-vous";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCreation
            // 
            this.btnCreation.Location = new System.Drawing.Point(135, 55);
            this.btnCreation.Name = "btnCreation";
            this.btnCreation.Size = new System.Drawing.Size(114, 23);
            this.btnCreation.TabIndex = 5;
            this.btnCreation.Text = "Créer un compte";
            this.btnCreation.UseVisualStyleBackColor = true;
            this.btnCreation.Click += new System.EventHandler(this.btnCreation_Click);
            // 
            // btnNouveauMDP
            // 
            this.btnNouveauMDP.Location = new System.Drawing.Point(15, 84);
            this.btnNouveauMDP.Name = "btnNouveauMDP";
            this.btnNouveauMDP.Size = new System.Drawing.Size(234, 23);
            this.btnNouveauMDP.TabIndex = 6;
            this.btnNouveauMDP.Text = "Mot de passe oublié";
            this.btnNouveauMDP.UseVisualStyleBackColor = true;
            this.btnNouveauMDP.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 115);
            this.Controls.Add(this.btnNouveauMDP);
            this.Controls.Add(this.btnCreation);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNom);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(276, 153);
            this.MinimumSize = new System.Drawing.Size(276, 153);
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCreation;
        private System.Windows.Forms.Button btnNouveauMDP;
    }
}

