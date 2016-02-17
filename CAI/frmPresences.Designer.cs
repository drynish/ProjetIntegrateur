namespace CAI
{
    partial class frmPresences
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
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GVPresences = new System.Windows.Forms.DataGridView();
            this.dateCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresseIpCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresseMacCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresseIpCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresseMacCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GVPresences)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total des heures :";
            // 
            // GVPresences
            // 
            this.GVPresences.AllowUserToAddRows = false;
            this.GVPresences.AllowUserToDeleteRows = false;
            this.GVPresences.AllowUserToResizeColumns = false;
            this.GVPresences.AllowUserToResizeRows = false;
            this.GVPresences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVPresences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateCheckIn,
            this.AdresseIpCheckIn,
            this.AdresseMacCheckIn,
            this.dateCheckOut,
            this.AdresseIpCheckOut,
            this.AdresseMacCheckOut});
            this.GVPresences.Location = new System.Drawing.Point(12, 43);
            this.GVPresences.Name = "GVPresences";
            this.GVPresences.RowHeadersVisible = false;
            this.GVPresences.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GVPresences.Size = new System.Drawing.Size(758, 442);
            this.GVPresences.TabIndex = 9;
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.HeaderText = "Date de check in";
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.ReadOnly = true;
            this.dateCheckIn.Width = 150;
            // 
            // AdresseIpCheckIn
            // 
            this.AdresseIpCheckIn.HeaderText = "Adresse IP du check in";
            this.AdresseIpCheckIn.Name = "AdresseIpCheckIn";
            this.AdresseIpCheckIn.ReadOnly = true;
            this.AdresseIpCheckIn.Width = 125;
            // 
            // AdresseMacCheckIn
            // 
            this.AdresseMacCheckIn.HeaderText = "Adresse MAC de check in";
            this.AdresseMacCheckIn.Name = "AdresseMacCheckIn";
            this.AdresseMacCheckIn.ReadOnly = true;
            // 
            // dateCheckOut
            // 
            this.dateCheckOut.HeaderText = "Date de check out";
            this.dateCheckOut.Name = "dateCheckOut";
            this.dateCheckOut.ReadOnly = true;
            this.dateCheckOut.Width = 150;
            // 
            // AdresseIpCheckOut
            // 
            this.AdresseIpCheckOut.HeaderText = "Adresse IP du check out";
            this.AdresseIpCheckOut.Name = "AdresseIpCheckOut";
            this.AdresseIpCheckOut.ReadOnly = true;
            this.AdresseIpCheckOut.Width = 125;
            // 
            // AdresseMacCheckOut
            // 
            this.AdresseMacCheckOut.HeaderText = "Adresse MAC de check out";
            this.AdresseMacCheckOut.Name = "AdresseMacCheckOut";
            this.AdresseMacCheckOut.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(110, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 10;
            // 
            // frmPresences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 497);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.GVPresences);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Name = "frmPresences";
            this.Text = "Présences de";
            this.Load += new System.EventHandler(this.frmPresences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVPresences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView GVPresences;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresseIpCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresseMacCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresseIpCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresseMacCheckOut;
        private System.Windows.Forms.Label lblTotal;
    }
}