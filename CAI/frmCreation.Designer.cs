namespace CAI
{
    partial class frmCreation
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomUsager = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmerMDP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(158, 144);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(144, 23);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(9, 144);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(144, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirmer";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(158, 90);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.PasswordChar = '*';
            this.txtMDP.Size = new System.Drawing.Size(144, 20);
            this.txtMDP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mot de passe";
            // 
            // txtNomUsager
            // 
            this.txtNomUsager.Location = new System.Drawing.Point(158, 65);
            this.txtNomUsager.Name = "txtNomUsager";
            this.txtNomUsager.Size = new System.Drawing.Size(144, 20);
            this.txtNomUsager.TabIndex = 3;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 65);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(82, 13);
            this.lblNom.TabIndex = 13;
            this.lblNom.Text = "Adresse courriel";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(158, 12);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(144, 20);
            this.txtPrenom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Prénom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(158, 39);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(144, 20);
            this.txtNom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Confirmer votre mot de passe";
            // 
            // txtConfirmerMDP
            // 
            this.txtConfirmerMDP.Location = new System.Drawing.Point(158, 116);
            this.txtConfirmerMDP.Name = "txtConfirmerMDP";
            this.txtConfirmerMDP.PasswordChar = '*';
            this.txtConfirmerMDP.Size = new System.Drawing.Size(144, 20);
            this.txtConfirmerMDP.TabIndex = 5;
            // 
            // frmCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 174);
            this.Controls.Add(this.txtConfirmerMDP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomUsager);
            this.Controls.Add(this.lblNom);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(999, 999);
            this.MinimumSize = new System.Drawing.Size(323, 202);
            this.Name = "frmCreation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création de compte";
            this.Load += new System.EventHandler(this.frmCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomUsager;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmerMDP;
    }
}