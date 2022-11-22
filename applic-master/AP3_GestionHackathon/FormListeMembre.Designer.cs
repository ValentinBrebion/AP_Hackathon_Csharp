namespace AP3_GestionHackathon
{
    partial class FormListeMembre
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
            this.dgvlistemembre = new System.Windows.Forms.DataGridView();
            this.lbllisteclient = new System.Windows.Forms.Label();
            this.CBEquipe = new System.Windows.Forms.ComboBox();
            this.bsMembre = new System.Windows.Forms.BindingSource(this.components);
            this.bsEquipe = new System.Windows.Forms.BindingSource(this.components);
            this.btnfermer = new System.Windows.Forms.Button();
            this.btnsuppr = new System.Windows.Forms.Button();
            this.btnArchi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistemembre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMembre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEquipe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistemembre
            // 
            this.dgvlistemembre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistemembre.Location = new System.Drawing.Point(12, 70);
            this.dgvlistemembre.Name = "dgvlistemembre";
            this.dgvlistemembre.Size = new System.Drawing.Size(776, 250);
            this.dgvlistemembre.TabIndex = 0;
            // 
            // lbllisteclient
            // 
            this.lbllisteclient.AutoSize = true;
            this.lbllisteclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllisteclient.Location = new System.Drawing.Point(57, 23);
            this.lbllisteclient.Name = "lbllisteclient";
            this.lbllisteclient.Size = new System.Drawing.Size(186, 24);
            this.lbllisteclient.TabIndex = 1;
            this.lbllisteclient.Text = "Liste des membres";
            // 
            // CBEquipe
            // 
            this.CBEquipe.FormattingEnabled = true;
            this.CBEquipe.Location = new System.Drawing.Point(348, 28);
            this.CBEquipe.Name = "CBEquipe";
            this.CBEquipe.Size = new System.Drawing.Size(182, 21);
            this.CBEquipe.TabIndex = 2;
            // 
            // bsEquipe
            // 
            this.bsEquipe.CurrentChanged += new System.EventHandler(this.BsEquipe_CurrentChanged);
            // 
            // btnfermer
            // 
            this.btnfermer.Location = new System.Drawing.Point(675, 400);
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.Size = new System.Drawing.Size(75, 23);
            this.btnfermer.TabIndex = 3;
            this.btnfermer.Text = "FERMER";
            this.btnfermer.UseVisualStyleBackColor = true;
            this.btnfermer.Click += new System.EventHandler(this.Btnfermer_Click);
            // 
            // btnsuppr
            // 
            this.btnsuppr.Location = new System.Drawing.Point(472, 338);
            this.btnsuppr.Name = "btnsuppr";
            this.btnsuppr.Size = new System.Drawing.Size(85, 23);
            this.btnsuppr.TabIndex = 4;
            this.btnsuppr.Text = "SUPPRIMER";
            this.btnsuppr.UseVisualStyleBackColor = true;
            this.btnsuppr.Click += new System.EventHandler(this.Btnsuppr_Click);
            // 
            // btnArchi
            // 
            this.btnArchi.Location = new System.Drawing.Point(574, 338);
            this.btnArchi.Name = "btnArchi";
            this.btnArchi.Size = new System.Drawing.Size(75, 23);
            this.btnArchi.TabIndex = 5;
            this.btnArchi.Text = "ARCHIVER";
            this.btnArchi.UseVisualStyleBackColor = true;
            this.btnArchi.Click += new System.EventHandler(this.BtnArchi_Click);
            // 
            // FormListeMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArchi);
            this.Controls.Add(this.btnsuppr);
            this.Controls.Add(this.btnfermer);
            this.Controls.Add(this.CBEquipe);
            this.Controls.Add(this.lbllisteclient);
            this.Controls.Add(this.dgvlistemembre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListeMembre";
            this.Text = "FormListeClient";
            this.Load += new System.EventHandler(this.FormListeClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistemembre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMembre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEquipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistemembre;
        private System.Windows.Forms.Label lbllisteclient;
        private System.Windows.Forms.BindingSource bsMembre;
        private System.Windows.Forms.ComboBox CBEquipe;
        private System.Windows.Forms.BindingSource bsEquipe;
        private System.Windows.Forms.Button btnfermer;
        private System.Windows.Forms.Button btnsuppr;
        private System.Windows.Forms.Button btnArchi;
    }
}