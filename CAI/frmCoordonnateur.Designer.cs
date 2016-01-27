namespace CAI
{
    partial class frmCoordonnateur
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
            this.tabCoordonnateur = new System.Windows.Forms.TabControl();
            this.tabConfirm = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPresence = new System.Windows.Forms.TabPage();
            this.tabCumuls = new System.Windows.Forms.TabPage();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coordonnateur = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Eleve = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NonDet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabCoordonnateur.SuspendLayout();
            this.tabConfirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCoordonnateur
            // 
            this.tabCoordonnateur.Controls.Add(this.tabConfirm);
            this.tabCoordonnateur.Controls.Add(this.tabPresence);
            this.tabCoordonnateur.Controls.Add(this.tabCumuls);
            this.tabCoordonnateur.Location = new System.Drawing.Point(12, 12);
            this.tabCoordonnateur.Name = "tabCoordonnateur";
            this.tabCoordonnateur.SelectedIndex = 0;
            this.tabCoordonnateur.Size = new System.Drawing.Size(710, 470);
            this.tabCoordonnateur.TabIndex = 0;
            // 
            // tabConfirm
            // 
            this.tabConfirm.Controls.Add(this.dataGridView1);
            this.tabConfirm.Location = new System.Drawing.Point(4, 22);
            this.tabConfirm.Name = "tabConfirm";
            this.tabConfirm.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfirm.Size = new System.Drawing.Size(702, 444);
            this.tabConfirm.TabIndex = 1;
            this.tabConfirm.Text = "Usagers";
            this.tabConfirm.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prenom,
            this.Nom,
            this.Coordonnateur,
            this.Eleve,
            this.NonDet});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 432);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPresence
            // 
            this.tabPresence.Location = new System.Drawing.Point(4, 22);
            this.tabPresence.Name = "tabPresence";
            this.tabPresence.Size = new System.Drawing.Size(702, 444);
            this.tabPresence.TabIndex = 2;
            this.tabPresence.Text = "Présences";
            this.tabPresence.UseVisualStyleBackColor = true;
            // 
            // tabCumuls
            // 
            this.tabCumuls.Location = new System.Drawing.Point(4, 22);
            this.tabCumuls.Name = "tabCumuls";
            this.tabCumuls.Size = new System.Drawing.Size(702, 444);
            this.tabCumuls.TabIndex = 3;
            this.tabCumuls.Text = "Cumul des heures";
            this.tabCumuls.UseVisualStyleBackColor = true;
            // 
            // Prenom
            // 
            this.Prenom.Frozen = true;
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Prenom.Width = 170;
            // 
            // Nom
            // 
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nom.Width = 170;
            // 
            // Coordonnateur
            // 
            this.Coordonnateur.Frozen = true;
            this.Coordonnateur.HeaderText = "Coordonnateur";
            this.Coordonnateur.Name = "Coordonnateur";
            this.Coordonnateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Eleve
            // 
            this.Eleve.Frozen = true;
            this.Eleve.HeaderText = "Élève";
            this.Eleve.Name = "Eleve";
            this.Eleve.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NonDet
            // 
            this.NonDet.Frozen = true;
            this.NonDet.HeaderText = "Non déterminé";
            this.NonDet.Name = "NonDet";
            this.NonDet.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmCoordonnateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 494);
            this.Controls.Add(this.tabCoordonnateur);
            this.Name = "frmCoordonnateur";
            this.Text = "Fenêtre du coordonnateur";
            this.tabCoordonnateur.ResumeLayout(false);
            this.tabConfirm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCoordonnateur;
        private System.Windows.Forms.TabPage tabConfirm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPresence;
        private System.Windows.Forms.TabPage tabCumuls;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Coordonnateur;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eleve;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NonDet;
    }
}