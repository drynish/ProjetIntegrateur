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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPeriodes = new System.Windows.Forms.Button();
            this.tabPresence = new System.Windows.Forms.TabPage();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GVPresences = new System.Windows.Forms.DataGridView();
            this.presenceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presenceNomUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomPresence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPresence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presenceInformations = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabConfirm = new System.Windows.Forms.TabPage();
            this.GVUsagers = new System.Windows.Forms.DataGridView();
            this.tabCoordonnateur = new System.Windows.Forms.TabControl();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomUtilisateurUsager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomUsager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomUsager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoordonnateurUsager = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EleveUsager = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NonDetUsager = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HoraireSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPresence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVPresences)).BeginInit();
            this.tabConfirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVUsagers)).BeginInit();
            this.tabCoordonnateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPeriodes
            // 
            this.btnPeriodes.Location = new System.Drawing.Point(800, 3);
            this.btnPeriodes.Name = "btnPeriodes";
            this.btnPeriodes.Size = new System.Drawing.Size(138, 25);
            this.btnPeriodes.TabIndex = 1;
            this.btnPeriodes.Text = "Configurer les périodes";
            this.btnPeriodes.UseVisualStyleBackColor = true;
            this.btnPeriodes.Click += new System.EventHandler(this.btnPeriodes_Click);
            // 
            // tabPresence
            // 
            this.tabPresence.Controls.Add(this.lbltotal);
            this.tabPresence.Controls.Add(this.label1);
            this.tabPresence.Controls.Add(this.GVPresences);
            this.tabPresence.Location = new System.Drawing.Point(4, 22);
            this.tabPresence.Name = "tabPresence";
            this.tabPresence.Size = new System.Drawing.Size(926, 452);
            this.tabPresence.TabIndex = 2;
            this.tabPresence.Text = "Présences";
            this.tabPresence.UseVisualStyleBackColor = true;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(61, 62);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 20);
            this.lbltotal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total des heures de tous les élèves:";
            // 
            // GVPresences
            // 
            this.GVPresences.AllowUserToAddRows = false;
            this.GVPresences.AllowUserToDeleteRows = false;
            this.GVPresences.AllowUserToResizeColumns = false;
            this.GVPresences.AllowUserToResizeRows = false;
            this.GVPresences.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.GVPresences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVPresences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.presenceID,
            this.presenceNomUtilisateur,
            this.PrenomPresence,
            this.NomPresence,
            this.presenceInformations});
            this.GVPresences.Location = new System.Drawing.Point(187, 16);
            this.GVPresences.MultiSelect = false;
            this.GVPresences.Name = "GVPresences";
            this.GVPresences.RowHeadersVisible = false;
            this.GVPresences.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GVPresences.Size = new System.Drawing.Size(639, 432);
            this.GVPresences.TabIndex = 1;
            this.GVPresences.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVPresences_CellContentClick);
            // 
            // presenceID
            // 
            this.presenceID.Frozen = true;
            this.presenceID.HeaderText = "ID";
            this.presenceID.Name = "presenceID";
            this.presenceID.Visible = false;
            this.presenceID.Width = 43;
            // 
            // presenceNomUtilisateur
            // 
            this.presenceNomUtilisateur.Frozen = true;
            this.presenceNomUtilisateur.HeaderText = "Nom d\'utilisateur";
            this.presenceNomUtilisateur.Name = "presenceNomUtilisateur";
            this.presenceNomUtilisateur.Width = 225;
            // 
            // PrenomPresence
            // 
            this.PrenomPresence.Frozen = true;
            this.PrenomPresence.HeaderText = "Prénom";
            this.PrenomPresence.Name = "PrenomPresence";
            this.PrenomPresence.ReadOnly = true;
            this.PrenomPresence.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrenomPresence.Width = 130;
            // 
            // NomPresence
            // 
            this.NomPresence.Frozen = true;
            this.NomPresence.HeaderText = "Nom";
            this.NomPresence.Name = "NomPresence";
            this.NomPresence.ReadOnly = true;
            this.NomPresence.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomPresence.Width = 130;
            // 
            // presenceInformations
            // 
            this.presenceInformations.HeaderText = "Présences";
            this.presenceInformations.Name = "presenceInformations";
            this.presenceInformations.Width = 150;
            // 
            // tabConfirm
            // 
            this.tabConfirm.Controls.Add(this.GVUsagers);
            this.tabConfirm.Location = new System.Drawing.Point(4, 22);
            this.tabConfirm.Name = "tabConfirm";
            this.tabConfirm.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfirm.Size = new System.Drawing.Size(926, 452);
            this.tabConfirm.TabIndex = 1;
            this.tabConfirm.Text = "Usagers";
            this.tabConfirm.UseVisualStyleBackColor = true;
            // 
            // GVUsagers
            // 
            this.GVUsagers.AllowUserToAddRows = false;
            this.GVUsagers.AllowUserToDeleteRows = false;
            this.GVUsagers.AllowUserToResizeColumns = false;
            this.GVUsagers.AllowUserToResizeRows = false;
            this.GVUsagers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.GVUsagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVUsagers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NomUtilisateurUsager,
            this.PrenomUsager,
            this.NomUsager,
            this.CoordonnateurUsager,
            this.EleveUsager,
            this.NonDetUsager,
            this.HoraireSelect,
            this.btnSupprimer});
            this.GVUsagers.Location = new System.Drawing.Point(6, 9);
            this.GVUsagers.MultiSelect = false;
            this.GVUsagers.Name = "GVUsagers";
            this.GVUsagers.ReadOnly = true;
            this.GVUsagers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GVUsagers.RowHeadersVisible = false;
            this.GVUsagers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GVUsagers.RowTemplate.Height = 24;
            this.GVUsagers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GVUsagers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GVUsagers.ShowCellToolTips = false;
            this.GVUsagers.ShowEditingIcon = false;
            this.GVUsagers.Size = new System.Drawing.Size(926, 452);
            this.GVUsagers.TabIndex = 0;
            this.GVUsagers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVUsagers_CellContentClick);
            // 
            // tabCoordonnateur
            // 
            this.tabCoordonnateur.Controls.Add(this.tabConfirm);
            this.tabCoordonnateur.Controls.Add(this.tabPresence);
            this.tabCoordonnateur.Location = new System.Drawing.Point(4, 12);
            this.tabCoordonnateur.Name = "tabCoordonnateur";
            this.tabCoordonnateur.SelectedIndex = 0;
            this.tabCoordonnateur.Size = new System.Drawing.Size(934, 478);
            this.tabCoordonnateur.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 5;
            // 
            // NomUtilisateurUsager
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NomUtilisateurUsager.DefaultCellStyle = dataGridViewCellStyle1;
            this.NomUtilisateurUsager.Frozen = true;
            this.NomUtilisateurUsager.HeaderText = "Nom d\'utilisateur";
            this.NomUtilisateurUsager.Name = "NomUtilisateurUsager";
            this.NomUtilisateurUsager.ReadOnly = true;
            this.NomUtilisateurUsager.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomUtilisateurUsager.Width = 180;
            // 
            // PrenomUsager
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrenomUsager.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrenomUsager.Frozen = true;
            this.PrenomUsager.HeaderText = "Prénom";
            this.PrenomUsager.Name = "PrenomUsager";
            this.PrenomUsager.ReadOnly = true;
            this.PrenomUsager.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrenomUsager.Width = 180;
            // 
            // NomUsager
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NomUsager.DefaultCellStyle = dataGridViewCellStyle3;
            this.NomUsager.Frozen = true;
            this.NomUsager.HeaderText = "Nom";
            this.NomUsager.Name = "NomUsager";
            this.NomUsager.ReadOnly = true;
            this.NomUsager.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomUsager.Width = 200;
            // 
            // CoordonnateurUsager
            // 
            this.CoordonnateurUsager.Frozen = true;
            this.CoordonnateurUsager.HeaderText = "Coordonnateur";
            this.CoordonnateurUsager.Name = "CoordonnateurUsager";
            this.CoordonnateurUsager.ReadOnly = true;
            this.CoordonnateurUsager.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CoordonnateurUsager.Width = 80;
            // 
            // EleveUsager
            // 
            this.EleveUsager.Frozen = true;
            this.EleveUsager.HeaderText = "Élève";
            this.EleveUsager.Name = "EleveUsager";
            this.EleveUsager.ReadOnly = true;
            this.EleveUsager.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EleveUsager.Width = 38;
            // 
            // NonDetUsager
            // 
            this.NonDetUsager.Frozen = true;
            this.NonDetUsager.HeaderText = "Non déterminé";
            this.NonDetUsager.Name = "NonDetUsager";
            this.NonDetUsager.ReadOnly = true;
            this.NonDetUsager.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NonDetUsager.Width = 82;
            // 
            // HoraireSelect
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HoraireSelect.DefaultCellStyle = dataGridViewCellStyle4;
            this.HoraireSelect.Frozen = true;
            this.HoraireSelect.HeaderText = "Horaire";
            this.HoraireSelect.Name = "HoraireSelect";
            this.HoraireSelect.ReadOnly = true;
            this.HoraireSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HoraireSelect.Text = "";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Frozen = true;
            this.btnSupprimer.HeaderText = "Supprimer ";
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.ReadOnly = true;
            this.btnSupprimer.Width = 60;
            // 
            // frmCoordonnateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 494);
            this.Controls.Add(this.btnPeriodes);
            this.Controls.Add(this.tabCoordonnateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(958, 532);
            this.MinimumSize = new System.Drawing.Size(958, 532);
            this.Name = "frmCoordonnateur";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fenêtre du coordonnateur";
            this.Load += new System.EventHandler(this.frmCoordonnateur_Load);
            this.tabPresence.ResumeLayout(false);
            this.tabPresence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVPresences)).EndInit();
            this.tabConfirm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVUsagers)).EndInit();
            this.tabCoordonnateur.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPeriodes;
        private System.Windows.Forms.TabPage tabPresence;
        private System.Windows.Forms.DataGridView GVPresences;
        private System.Windows.Forms.TabPage tabConfirm;
        private System.Windows.Forms.DataGridView GVUsagers;
        private System.Windows.Forms.TabControl tabCoordonnateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn presenceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn presenceNomUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomPresence;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPresence;
        private System.Windows.Forms.DataGridViewButtonColumn presenceInformations;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomUtilisateurUsager;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomUsager;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomUsager;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CoordonnateurUsager;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EleveUsager;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NonDetUsager;
        private System.Windows.Forms.DataGridViewButtonColumn HoraireSelect;
        private System.Windows.Forms.DataGridViewButtonColumn btnSupprimer;
    }
}