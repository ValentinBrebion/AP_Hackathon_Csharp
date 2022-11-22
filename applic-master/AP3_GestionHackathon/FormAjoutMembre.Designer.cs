namespace AP3_GestionHackathon
{
    partial class FormAjoutMembre
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjoutMembreEquipe = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.bsMembre = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMembrenoninscrit = new System.Windows.Forms.DataGridView();
            this.txtIndexEquipe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsMembre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembrenoninscrit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajout Membre non inscrit";
            // 
            // btnAjoutMembreEquipe
            // 
            this.btnAjoutMembreEquipe.BackColor = System.Drawing.Color.Black;
            this.btnAjoutMembreEquipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjoutMembreEquipe.ForeColor = System.Drawing.Color.White;
            this.btnAjoutMembreEquipe.Location = new System.Drawing.Point(49, 293);
            this.btnAjoutMembreEquipe.Name = "btnAjoutMembreEquipe";
            this.btnAjoutMembreEquipe.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutMembreEquipe.TabIndex = 2;
            this.btnAjoutMembreEquipe.Text = "AJOUTER";
            this.btnAjoutMembreEquipe.UseVisualStyleBackColor = false;
            this.btnAjoutMembreEquipe.Click += new System.EventHandler(this.btnAjoutMembreEquipe_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Black;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(274, 293);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "FERMER";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // dgvMembrenoninscrit
            // 
            this.dgvMembrenoninscrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembrenoninscrit.Location = new System.Drawing.Point(12, 72);
            this.dgvMembrenoninscrit.Name = "dgvMembrenoninscrit";
            this.dgvMembrenoninscrit.Size = new System.Drawing.Size(403, 177);
            this.dgvMembrenoninscrit.TabIndex = 4;
            // 
            // txtIndexEquipe
            // 
            this.txtIndexEquipe.Location = new System.Drawing.Point(30, 37);
            this.txtIndexEquipe.Name = "txtIndexEquipe";
            this.txtIndexEquipe.Size = new System.Drawing.Size(47, 20);
            this.txtIndexEquipe.TabIndex = 5;
            // 
            // FormAjoutMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(427, 393);
            this.Controls.Add(this.txtIndexEquipe);
            this.Controls.Add(this.dgvMembrenoninscrit);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnAjoutMembreEquipe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormAjoutMembre";
            this.Text = "FormAjoutMembre";
            this.Load += new System.EventHandler(this.FormAjoutMembre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMembre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembrenoninscrit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjoutMembreEquipe;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.BindingSource bsMembre;
        private System.Windows.Forms.DataGridView dgvMembrenoninscrit;
        private System.Windows.Forms.TextBox txtIndexEquipe;
    }
}