namespace CAI
{
    partial class frmMotDePasse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMDPActuel = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMDPActuel
            // 
            this.txtMDPActuel.Location = new System.Drawing.Point(141, 43);
            this.txtMDPActuel.Name = "txtMDPActuel";
            this.txtMDPActuel.PasswordChar = '*';
            this.txtMDPActuel.Size = new System.Drawing.Size(154, 20);
            this.txtMDPActuel.TabIndex = 7;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(141, 17);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(154, 20);
            this.txtNom.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 46);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(103, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Mot de passe actuel";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 20);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(82, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Adresse courriel";
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(141, 69);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.PasswordChar = '*';
            this.txtMDP.Size = new System.Drawing.Size(154, 20);
            this.txtMDP.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nouveau mot de passe";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 100);
            this.btnConfirm.MaximumSize = new System.Drawing.Size(0, 200);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(0, 23);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(283, 27);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirmer";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(12, 133);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(283, 27);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmMotDePasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 169);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMDPActuel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNom);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(393, 207);
            this.Name = "frmMotDePasse";
            this.ShowIcon = false;
            this.Text = "Réinitialiser son mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMDPActuel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnAnnuler;
    }
}