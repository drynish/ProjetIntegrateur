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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabCoordonnateur = new System.Windows.Forms.TabControl();
            this.tabConfirm = new System.Windows.Forms.TabPage();
            this.GVUsagers = new System.Windows.Forms.DataGridView();
            this.tabPresence = new System.Windows.Forms.TabPage();
            this.GVPresences = new System.Windows.Forms.DataGridView();
            this.PrenomPresence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPresence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePresence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAIPresence = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DebutPresence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinPresence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidationPresence = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabCumuls = new System.Windows.Forms.TabPage();
            this.GVCumulHeures = new System.Windows.Forms.DataGridView();
            this.PrenomCumul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCumul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCumul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomUsager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomUsager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoordonnateurUsager = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EleveUsager = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NonDetUsager = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HoraireSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPeriodes = new System.Windows.Forms.Button();
            this.tabCoordonnateur.SuspendLayout();
            this.tabConfirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVUsagers)).BeginInit();
            this.tabPresence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVPresences)).BeginInit();
            this.tabCumuls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVCumulHeures)).BeginInit();
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
            this.tabCoordonnateur.Size = new System.Drawing.Size(918, 470);
            this.tabCoordonnateur.TabIndex = 0;
            // 
            // tabConfirm
            // 
            this.tabConfirm.Controls.Add(this.GVUsagers);
            this.tabConfirm.Location = new System.Drawing.Point(4, 22);
            this.tabConfirm.Name = "tabConfirm";
            this.tabConfirm.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfirm.Size = new System.Drawing.Size(910, 444);
            this.tabConfirm.TabIndex = 1;
            this.tabConfirm.Text = "Usagers";
            this.tabConfirm.UseVisualStyleBackColor = true;
            // 
            // GVUsagers
            // 
            this.GVUsagers.AllowUserToDeleteRows = false;
            this.GVUsagers.AllowUserToResizeColumns = false;
            this.GVUsagers.AllowUserToResizeRows = false;
            this.GVUsagers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.GVUsagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVUsagers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrenomUsager,
            this.NomUsager,
            this.CoordonnateurUsager,
            this.EleveUsager,
            this.NonDetUsager,
            this.HoraireSelect});
            this.GVUsagers.Location = new System.Drawing.Point(6, 9);
            this.GVUsagers.MultiSelect = false;
            this.GVUsagers.Name = "GVUsagers";
            this.GVUsagers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GVUsagers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GVUsagers.RowTemplate.Height = 24;
            this.GVUsagers.Size = new System.Drawing.Size(889, 432);
            this.GVUsagers.TabIndex = 0;
            this.GVUsagers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPresence
            // 
            this.tabPresence.Controls.Add(this.GVPresences);
            this.tabPresence.Location = new System.Drawing.Point(4, 22);
            this.tabPresence.Name = "tabPresence";
            this.tabPresence.Size = new System.Drawing.Size(910, 444);
            this.tabPresence.TabIndex = 2;
            this.tabPresence.Text = "Présences";
            this.tabPresence.UseVisualStyleBackColor = true;
            // 
            // GVPresences
            // 
            this.GVPresences.AllowUserToAddRows = false;
            this.GVPresences.AllowUserToDeleteRows = false;
            this.GVPresences.AllowUserToResizeColumns = false;
            this.GVPresences.AllowUserToResizeRows = false;
            this.GVPresences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVPresences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrenomPresence,
            this.NomPresence,
            this.DatePresence,
            this.CAIPresence,
            this.DebutPresence,
            this.FinPresence,
            this.ValidationPresence});
            this.GVPresences.Location = new System.Drawing.Point(109, 3);
            this.GVPresences.MultiSelect = false;
            this.GVPresences.Name = "GVPresences";
            this.GVPresences.Size = new System.Drawing.Size(690, 432);
            this.GVPresences.TabIndex = 1;
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
            // DatePresence
            // 
            this.DatePresence.Frozen = true;
            this.DatePresence.HeaderText = "Date";
            this.DatePresence.Name = "DatePresence";
            this.DatePresence.ReadOnly = true;
            this.DatePresence.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DatePresence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CAIPresence
            // 
            this.CAIPresence.Frozen = true;
            this.CAIPresence.HeaderText = "CAI";
            this.CAIPresence.Name = "CAIPresence";
            this.CAIPresence.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CAIPresence.Width = 50;
            // 
            // DebutPresence
            // 
            this.DebutPresence.Frozen = true;
            this.DebutPresence.HeaderText = "Début";
            this.DebutPresence.Name = "DebutPresence";
            this.DebutPresence.ReadOnly = true;
            this.DebutPresence.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DebutPresence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DebutPresence.Width = 60;
            // 
            // FinPresence
            // 
            this.FinPresence.Frozen = true;
            this.FinPresence.HeaderText = "Fin";
            this.FinPresence.Name = "FinPresence";
            this.FinPresence.ReadOnly = true;
            this.FinPresence.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FinPresence.Width = 60;
            // 
            // ValidationPresence
            // 
            this.ValidationPresence.Frozen = true;
            this.ValidationPresence.HeaderText = "Validation";
            this.ValidationPresence.Name = "ValidationPresence";
            this.ValidationPresence.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ValidationPresence.Width = 110;
            // 
            // tabCumuls
            // 
            this.tabCumuls.Controls.Add(this.GVCumulHeures);
            this.tabCumuls.Location = new System.Drawing.Point(4, 22);
            this.tabCumuls.Name = "tabCumuls";
            this.tabCumuls.Size = new System.Drawing.Size(910, 444);
            this.tabCumuls.TabIndex = 3;
            this.tabCumuls.Text = "Cumul des heures";
            this.tabCumuls.UseVisualStyleBackColor = true;
            // 
            // GVCumulHeures
            // 
            this.GVCumulHeures.AllowUserToAddRows = false;
            this.GVCumulHeures.AllowUserToDeleteRows = false;
            this.GVCumulHeures.AllowUserToResizeColumns = false;
            this.GVCumulHeures.AllowUserToResizeRows = false;
            this.GVCumulHeures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCumulHeures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrenomCumul,
            this.NomCumul,
            this.TotalCumul});
            this.GVCumulHeures.Location = new System.Drawing.Point(110, 3);
            this.GVCumulHeures.MultiSelect = false;
            this.GVCumulHeures.Name = "GVCumulHeures";
            this.GVCumulHeures.Size = new System.Drawing.Size(690, 432);
            this.GVCumulHeures.TabIndex = 1;
            // 
            // PrenomCumul
            // 
            this.PrenomCumul.Frozen = true;
            this.PrenomCumul.HeaderText = "Prénom";
            this.PrenomCumul.Name = "PrenomCumul";
            this.PrenomCumul.ReadOnly = true;
            this.PrenomCumul.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrenomCumul.Width = 190;
            // 
            // NomCumul
            // 
            this.NomCumul.Frozen = true;
            this.NomCumul.HeaderText = "Nom";
            this.NomCumul.Name = "NomCumul";
            this.NomCumul.ReadOnly = true;
            this.NomCumul.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomCumul.Width = 190;
            // 
            // TotalCumul
            // 
            this.TotalCumul.Frozen = true;
            this.TotalCumul.HeaderText = "Total d\'heures";
            this.TotalCumul.Name = "TotalCumul";
            this.TotalCumul.ReadOnly = true;
            this.TotalCumul.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalCumul.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TotalCumul.Width = 250;
            // 
            // PrenomUsager
            // 
            this.PrenomUsager.Frozen = true;
            this.PrenomUsager.HeaderText = "Prénom";
            this.PrenomUsager.Name = "PrenomUsager";
            this.PrenomUsager.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrenomUsager.Width = 170;
            // 
            // NomUsager
            // 
            this.NomUsager.Frozen = true;
            this.NomUsager.HeaderText = "Nom";
            this.NomUsager.Name = "NomUsager";
            this.NomUsager.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomUsager.Width = 170;
            // 
            // CoordonnateurUsager
            // 
            this.CoordonnateurUsager.Frozen = true;
            this.CoordonnateurUsager.HeaderText = "Coordonnateur";
            this.CoordonnateurUsager.Name = "CoordonnateurUsager";
            this.CoordonnateurUsager.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // EleveUsager
            // 
            this.EleveUsager.Frozen = true;
            this.EleveUsager.HeaderText = "Élève";
            this.EleveUsager.Name = "EleveUsager";
            this.EleveUsager.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NonDetUsager
            // 
            this.NonDetUsager.Frozen = true;
            this.NonDetUsager.HeaderText = "Non déterminé";
            this.NonDetUsager.Name = "NonDetUsager";
            this.NonDetUsager.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HoraireSelect
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HoraireSelect.DefaultCellStyle = dataGridViewCellStyle2;
            this.HoraireSelect.HeaderText = "Sélectionner l\'horaire";
            this.HoraireSelect.Name = "HoraireSelect";
            this.HoraireSelect.ReadOnly = true;
            this.HoraireSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HoraireSelect.Text = "gfhfg";
            this.HoraireSelect.Width = 200;
            // 
            // btnPeriodes
            // 
            this.btnPeriodes.Location = new System.Drawing.Point(623, 5);
            this.btnPeriodes.Name = "btnPeriodes";
            this.btnPeriodes.Size = new System.Drawing.Size(138, 23);
            this.btnPeriodes.TabIndex = 1;
            this.btnPeriodes.Text = "Configurer les périodes";
            this.btnPeriodes.UseVisualStyleBackColor = true;
            this.btnPeriodes.Click += new System.EventHandler(this.btnPeriodes_Click);
            // 
            // frmCoordonnateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 494);
            this.Controls.Add(this.btnPeriodes);
            this.Controls.Add(this.tabCoordonnateur);
            this.Name = "frmCoordonnateur";
            this.Text = "Fenêtre du coordonnateur";
            this.tabCoordonnateur.ResumeLayout(false);
            this.tabConfirm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVUsagers)).EndInit();
            this.tabPresence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVPresences)).EndInit();
            this.tabCumuls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVCumulHeures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCoordonnateur;
        private System.Windows.Forms.TabPage tabConfirm;
        private System.Windows.Forms.DataGridView GVUsagers;
        private System.Windows.Forms.TabPage tabPresence;
        private System.Windows.Forms.TabPage tabCumuls;
        private System.Windows.Forms.DataGridView GVPresences;
        private System.Windows.Forms.DataGridView GVCumulHeures;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomPresence;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPresence;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePresence;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CAIPresence;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebutPresence;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinPresence;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ValidationPresence;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomCumul;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCumul;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCumul;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomUsager;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomUsager;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CoordonnateurUsager;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EleveUsager;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NonDetUsager;
        private System.Windows.Forms.DataGridViewButtonColumn HoraireSelect;
        private System.Windows.Forms.Button btnPeriodes;
    }
}