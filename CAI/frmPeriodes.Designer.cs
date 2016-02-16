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
            this.txtMinuteDebut = new System.Windows.Forms.TextBox();
            this.txtHeureDebut = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtMinuteFin = new System.Windows.Forms.TextBox();
            this.txtHeureFin = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblHeureDebut = new System.Windows.Forms.Label();
            this.lblHeureFin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPeriodes
            // 
            this.cmbPeriodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodes.FormattingEnabled = true;
            this.cmbPeriodes.Location = new System.Drawing.Point(36, 12);
            this.cmbPeriodes.Name = "cmbPeriodes";
            this.cmbPeriodes.Size = new System.Drawing.Size(121, 21);
            this.cmbPeriodes.TabIndex = 1;
            this.cmbPeriodes.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodes_SelectedIndexChanged);
            // 
            // txtMinuteDebut
            // 
            this.txtMinuteDebut.Location = new System.Drawing.Point(46, 62);
            this.txtMinuteDebut.MaxLength = 2;
            this.txtMinuteDebut.Name = "txtMinuteDebut";
            this.txtMinuteDebut.Size = new System.Drawing.Size(28, 20);
            this.txtMinuteDebut.TabIndex = 3;
            this.txtMinuteDebut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gererTouchesPeriodes);
            this.txtMinuteDebut.Leave += new System.EventHandler(this.verifierMinutes);
            // 
            // txtHeureDebut
            // 
            this.txtHeureDebut.Location = new System.Drawing.Point(12, 62);
            this.txtHeureDebut.MaxLength = 2;
            this.txtHeureDebut.Name = "txtHeureDebut";
            this.txtHeureDebut.Size = new System.Drawing.Size(28, 20);
            this.txtHeureDebut.TabIndex = 2;
            this.txtHeureDebut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gererTouchesPeriodes);
            this.txtHeureDebut.Leave += new System.EventHandler(this.verifierHeures);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 139);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            this.btnAjouter.Leave += new System.EventHandler(this.btnAjouter_Leave);
            // 
            // txtMinuteFin
            // 
            this.txtMinuteFin.Location = new System.Drawing.Point(149, 62);
            this.txtMinuteFin.MaxLength = 2;
            this.txtMinuteFin.Name = "txtMinuteFin";
            this.txtMinuteFin.Size = new System.Drawing.Size(28, 20);
            this.txtMinuteFin.TabIndex = 5;
            this.txtMinuteFin.Click += new System.EventHandler(this.verifierMinutes);
            this.txtMinuteFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gererTouchesPeriodes);
            this.txtMinuteFin.Leave += new System.EventHandler(this.verifierMinutes);
            // 
            // txtHeureFin
            // 
            this.txtHeureFin.Location = new System.Drawing.Point(115, 62);
            this.txtHeureFin.MaxLength = 2;
            this.txtHeureFin.Name = "txtHeureFin";
            this.txtHeureFin.Size = new System.Drawing.Size(28, 20);
            this.txtHeureFin.TabIndex = 4;
            this.txtHeureFin.Click += new System.EventHandler(this.verifierMinutes);
            this.txtHeureFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gererTouchesPeriodes);
            this.txtHeureFin.Leave += new System.EventHandler(this.verifierHeures);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(12, 197);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(93, 139);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(87, 81);
            this.btnSupp.TabIndex = 8;
            this.btnSupp.Text = "Supprimer la dernière période";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Leave += new System.EventHandler(this.btnSupp_Leave);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Location = new System.Drawing.Point(12, 168);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(75, 23);
            this.cmdModifier.TabIndex = 7;
            this.cmdModifier.Text = "Modifier";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            this.cmdModifier.Leave += new System.EventHandler(this.cmdModifier_Leave);
            // 
            // lblInformation
            // 
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.Blue;
            this.lblInformation.Location = new System.Drawing.Point(12, 103);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(168, 13);
            this.lblInformation.TabIndex = 19;
            this.lblInformation.Text = "La période #444 à été supprimée";
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeureDebut
            // 
            this.lblHeureDebut.AutoSize = true;
            this.lblHeureDebut.Location = new System.Drawing.Point(9, 46);
            this.lblHeureDebut.Name = "lblHeureDebut";
            this.lblHeureDebut.Size = new System.Drawing.Size(81, 13);
            this.lblHeureDebut.TabIndex = 23;
            this.lblHeureDebut.Text = "Heure de début";
            // 
            // lblHeureFin
            // 
            this.lblHeureFin.AutoSize = true;
            this.lblHeureFin.Location = new System.Drawing.Point(112, 46);
            this.lblHeureFin.Name = "lblHeureFin";
            this.lblHeureFin.Size = new System.Drawing.Size(65, 13);
            this.lblHeureFin.TabIndex = 24;
            this.lblHeureFin.Text = "Heure de fin";
            // 
            // frmPeriodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 229);
            this.Controls.Add(this.lblHeureFin);
            this.Controls.Add(this.lblHeureDebut);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.txtMinuteFin);
            this.Controls.Add(this.txtHeureFin);
            this.Controls.Add(this.txtMinuteDebut);
            this.Controls.Add(this.txtHeureDebut);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cmbPeriodes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPeriodes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Périodes";
            this.Load += new System.EventHandler(this.frmPeriodes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbPeriodes;
        private System.Windows.Forms.TextBox txtMinuteDebut;
        private System.Windows.Forms.TextBox txtHeureDebut;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtMinuteFin;
        private System.Windows.Forms.TextBox txtHeureFin;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblHeureDebut;
        private System.Windows.Forms.Label lblHeureFin;
    }
}