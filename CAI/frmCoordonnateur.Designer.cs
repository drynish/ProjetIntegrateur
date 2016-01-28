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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabCumuls = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.PrenomUsager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomUsager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoordonnateurUsager = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EleveUsager = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NonDetUsager = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PrenomPresence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPresence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePresence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAIPresence = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DebutPresence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinPresence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidationPresence = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PrenomCumul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCumul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCumul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCoordonnateur.SuspendLayout();
            this.tabConfirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPresence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabCumuls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.PrenomUsager,
            this.NomUsager,
            this.CoordonnateurUsager,
            this.EleveUsager,
            this.NonDetUsager});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 432);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPresence
            // 
            this.tabPresence.Controls.Add(this.dataGridView2);
            this.tabPresence.Location = new System.Drawing.Point(4, 22);
            this.tabPresence.Name = "tabPresence";
            this.tabPresence.Size = new System.Drawing.Size(702, 444);
            this.tabPresence.TabIndex = 2;
            this.tabPresence.Text = "Présences";
            this.tabPresence.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrenomPresence,
            this.NomPresence,
            this.DatePresence,
            this.CAIPresence,
            this.DebutPresence,
            this.FinPresence,
            this.ValidationPresence});
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(690, 432);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabCumuls
            // 
            this.tabCumuls.Controls.Add(this.dataGridView3);
            this.tabCumuls.Location = new System.Drawing.Point(4, 22);
            this.tabCumuls.Name = "tabCumuls";
            this.tabCumuls.Size = new System.Drawing.Size(702, 444);
            this.tabCumuls.TabIndex = 3;
            this.tabCumuls.Text = "Cumul des heures";
            this.tabCumuls.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrenomCumul,
            this.NomCumul,
            this.TotalCumul});
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(690, 432);
            this.dataGridView3.TabIndex = 1;
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
            this.tabPresence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabCumuls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCoordonnateur;
        private System.Windows.Forms.TabPage tabConfirm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPresence;
        private System.Windows.Forms.TabPage tabCumuls;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomUsager;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomUsager;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CoordonnateurUsager;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EleveUsager;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NonDetUsager;
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
    }
}