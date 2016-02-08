namespace CAI
{
    partial class frmPeriodes
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
            this.cmbPeriodes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinuteDebut = new System.Windows.Forms.TextBox();
            this.txtHeureDebut = new System.Windows.Forms.TextBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinutesFin = new System.Windows.Forms.TextBox();
            this.txtHeureFin = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPeriodes
            // 
            this.cmbPeriodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodes.FormattingEnabled = true;
            this.cmbPeriodes.Location = new System.Drawing.Point(15, 40);
            this.cmbPeriodes.Name = "cmbPeriodes";
            this.cmbPeriodes.Size = new System.Drawing.Size(121, 21);
            this.cmbPeriodes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir le numéro de la période";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Début de la période";
            // 
            // txtMinuteDebut
            // 
            this.txtMinuteDebut.Location = new System.Drawing.Point(62, 91);
            this.txtMinuteDebut.MaxLength = 2;
            this.txtMinuteDebut.Name = "txtMinuteDebut";
            this.txtMinuteDebut.Size = new System.Drawing.Size(28, 20);
            this.txtMinuteDebut.TabIndex = 9;
            this.txtMinuteDebut.Click += new System.EventHandler(this.gererTouchesPeriodes);
            this.txtMinuteDebut.Leave += new System.EventHandler(this.verifierMinutes);
            // 
            // txtHeureDebut
            // 
            this.txtHeureDebut.Location = new System.Drawing.Point(15, 91);
            this.txtHeureDebut.MaxLength = 2;
            this.txtHeureDebut.Name = "txtHeureDebut";
            this.txtHeureDebut.Size = new System.Drawing.Size(28, 20);
            this.txtHeureDebut.TabIndex = 8;
            this.txtHeureDebut.Click += new System.EventHandler(this.gererTouchesPeriodes);
            this.txtHeureDebut.Leave += new System.EventHandler(this.verifierHeures);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(62, 178);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmer.TabIndex = 5;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fin de la période";
            // 
            // txtMinutesFin
            // 
            this.txtMinutesFin.Location = new System.Drawing.Point(62, 143);
            this.txtMinutesFin.MaxLength = 2;
            this.txtMinutesFin.Name = "txtMinutesFin";
            this.txtMinutesFin.Size = new System.Drawing.Size(28, 20);
            this.txtMinutesFin.TabIndex = 13;
            this.txtMinutesFin.Click += new System.EventHandler(this.gererTouchesPeriodes);
            this.txtMinutesFin.Leave += new System.EventHandler(this.verifierMinutes);
            // 
            // txtHeureFin
            // 
            this.txtHeureFin.Location = new System.Drawing.Point(15, 143);
            this.txtHeureFin.MaxLength = 2;
            this.txtHeureFin.Name = "txtHeureFin";
            this.txtHeureFin.Size = new System.Drawing.Size(28, 20);
            this.txtHeureFin.TabIndex = 12;
            this.txtHeureFin.Click += new System.EventHandler(this.gererTouchesPeriodes);
            this.txtHeureFin.Leave += new System.EventHandler(this.verifierHeures);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(62, 236);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 16;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(15, 207);
            this.btnSupp.MaximumSize = new System.Drawing.Size(165, 23);
            this.btnSupp.MinimumSize = new System.Drawing.Size(165, 23);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(165, 23);
            this.btnSupp.TabIndex = 17;
            this.btnSupp.Text = "Supprimer la dernière période";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // frmPeriodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 268);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMinutesFin);
            this.Controls.Add(this.txtHeureFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinuteDebut);
            this.Controls.Add(this.txtHeureDebut);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.cmbPeriodes);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(208, 306);
            this.MinimumSize = new System.Drawing.Size(208, 306);
            this.Name = "frmPeriodes";
            this.Text = "frmPeriodes";
            this.Load += new System.EventHandler(this.frmPeriodes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbPeriodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinuteDebut;
        private System.Windows.Forms.TextBox txtHeureDebut;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinutesFin;
        private System.Windows.Forms.TextBox txtHeureFin;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSupp;
    }
}