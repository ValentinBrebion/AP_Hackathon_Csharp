namespace AP3_GestionHackathon
{
    partial class FormGestionEquipe
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
            this.labelajmodequipe = new System.Windows.Forms.Label();
            this.cbModifEquipe = new System.Windows.Forms.ComboBox();
            this.gbequipe = new System.Windows.Forms.GroupBox();
            this.btnsupprimerMembreE = new System.Windows.Forms.Button();
            this.labelmembreasso = new System.Windows.Forms.Label();
            this.btnaddMembre = new System.Windows.Forms.Button();
            this.dvgMembre = new System.Windows.Forms.DataGridView();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtlienprot = new System.Windows.Forms.TextBox();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.txtnomequip = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lbllog = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbllienPrototype = new System.Windows.Forms.Label();
            this.lblnomequipe = new System.Windows.Forms.Label();
            this.btnajmodequip = new System.Windows.Forms.Button();
            this.btnfermer = new System.Windows.Forms.Button();
            this.bsEquipe = new System.Windows.Forms.BindingSource(this.components);
            this.bsMembre = new System.Windows.Forms.BindingSource(this.components);
            this.gbequipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMembre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEquipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMembre)).BeginInit();
            this.SuspendLayout();
            // 
            // labelajmodequipe
            // 
            this.labelajmodequipe.AutoSize = true;
            this.labelajmodequipe.Location = new System.Drawing.Point(50, 32);
            this.labelajmodequipe.Name = "labelajmodequipe";
            this.labelajmodequipe.Size = new System.Drawing.Size(35, 13);
            this.labelajmodequipe.TabIndex = 0;
            this.labelajmodequipe.Text = "label1";
            // 
            // cbModifEquipe
            // 
            this.cbModifEquipe.FormattingEnabled = true;
            this.cbModifEquipe.Location = new System.Drawing.Point(230, 29);
            this.cbModifEquipe.Name = "cbModifEquipe";
            this.cbModifEquipe.Size = new System.Drawing.Size(353, 21);
            this.cbModifEquipe.TabIndex = 1;
            this.cbModifEquipe.SelectedIndexChanged += new System.EventHandler(this.CbModifEquipe_SelectedIndexChanged);
            // 
            // gbequipe
            // 
            this.gbequipe.Controls.Add(this.btnsupprimerMembreE);
            this.gbequipe.Controls.Add(this.labelmembreasso);
            this.gbequipe.Controls.Add(this.btnaddMembre);
            this.gbequipe.Controls.Add(this.dvgMembre);
            this.gbequipe.Controls.Add(this.txtpass);
            this.gbequipe.Controls.Add(this.txtlienprot);
            this.gbequipe.Controls.Add(this.txtlog);
            this.gbequipe.Controls.Add(this.txtnomequip);
            this.gbequipe.Controls.Add(this.lblpassword);
            this.gbequipe.Controls.Add(this.lbllog);
            this.gbequipe.Controls.Add(this.label3);
            this.gbequipe.Controls.Add(this.lbllienPrototype);
            this.gbequipe.Controls.Add(this.lblnomequipe);
            this.gbequipe.Controls.Add(this.btnajmodequip);
            this.gbequipe.Location = new System.Drawing.Point(53, 78);
            this.gbequipe.Name = "gbequipe";
            this.gbequipe.Size = new System.Drawing.Size(696, 273);
            this.gbequipe.TabIndex = 2;
            this.gbequipe.TabStop = false;
            this.gbequipe.Text = "groupBox1";
            // 
            // btnsupprimerMembreE
            // 
            this.btnsupprimerMembreE.Location = new System.Drawing.Point(595, 101);
            this.btnsupprimerMembreE.Name = "btnsupprimerMembreE";
            this.btnsupprimerMembreE.Size = new System.Drawing.Size(75, 23);
            this.btnsupprimerMembreE.TabIndex = 15;
            this.btnsupprimerMembreE.Text = "Supprimer";
            this.btnsupprimerMembreE.UseVisualStyleBackColor = true;
            this.btnsupprimerMembreE.Click += new System.EventHandler(this.BtnsupprimerMembreE_Click);
            // 
            // labelmembreasso
            // 
            this.labelmembreasso.AutoSize = true;
            this.labelmembreasso.Location = new System.Drawing.Point(334, 15);
            this.labelmembreasso.Name = "labelmembreasso";
            this.labelmembreasso.Size = new System.Drawing.Size(84, 13);
            this.labelmembreasso.TabIndex = 13;
            this.labelmembreasso.Text = "Membre associé";
            // 
            // btnaddMembre
            // 
            this.btnaddMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddMembre.Location = new System.Drawing.Point(595, 61);
            this.btnaddMembre.Name = "btnaddMembre";
            this.btnaddMembre.Size = new System.Drawing.Size(28, 23);
            this.btnaddMembre.TabIndex = 12;
            this.btnaddMembre.Text = "+";
            this.btnaddMembre.UseVisualStyleBackColor = true;
            this.btnaddMembre.Click += new System.EventHandler(this.BtnaddMembre_Click);
            // 
            // dvgMembre
            // 
            this.dvgMembre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMembre.Location = new System.Drawing.Point(334, 34);
            this.dvgMembre.Name = "dvgMembre";
            this.dvgMembre.Size = new System.Drawing.Size(235, 180);
            this.dvgMembre.TabIndex = 11;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(190, 117);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 10;
            // 
            // txtlienprot
            // 
            this.txtlienprot.Location = new System.Drawing.Point(16, 117);
            this.txtlienprot.Name = "txtlienprot";
            this.txtlienprot.Size = new System.Drawing.Size(100, 20);
            this.txtlienprot.TabIndex = 9;
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(190, 61);
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(100, 20);
            this.txtlog.TabIndex = 7;
            // 
            // txtnomequip
            // 
            this.txtnomequip.Location = new System.Drawing.Point(16, 61);
            this.txtnomequip.Name = "txtnomequip";
            this.txtnomequip.Size = new System.Drawing.Size(100, 20);
            this.txtnomequip.TabIndex = 6;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(187, 101);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(71, 13);
            this.lblpassword.TabIndex = 5;
            this.lblpassword.Text = "Mot de passe";
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Location = new System.Drawing.Point(187, 45);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(33, 13);
            this.lbllog.TabIndex = 4;
            this.lbllog.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // lbllienPrototype
            // 
            this.lbllienPrototype.AutoSize = true;
            this.lbllienPrototype.Location = new System.Drawing.Point(13, 101);
            this.lbllienPrototype.Name = "lbllienPrototype";
            this.lbllienPrototype.Size = new System.Drawing.Size(68, 13);
            this.lbllienPrototype.TabIndex = 2;
            this.lbllienPrototype.Text = "lienPrototype";
            // 
            // lblnomequipe
            // 
            this.lblnomequipe.AutoSize = true;
            this.lblnomequipe.Location = new System.Drawing.Point(13, 45);
            this.lblnomequipe.Name = "lblnomequipe";
            this.lblnomequipe.Size = new System.Drawing.Size(62, 13);
            this.lblnomequipe.TabIndex = 1;
            this.lblnomequipe.Text = "NomEquipe";
            // 
            // btnajmodequip
            // 
            this.btnajmodequip.Location = new System.Drawing.Point(610, 235);
            this.btnajmodequip.Name = "btnajmodequip";
            this.btnajmodequip.Size = new System.Drawing.Size(75, 23);
            this.btnajmodequip.TabIndex = 0;
            this.btnajmodequip.Text = "button1";
            this.btnajmodequip.UseVisualStyleBackColor = true;
            this.btnajmodequip.Click += new System.EventHandler(this.Btnajmodequip_Click);
            // 
            // btnfermer
            // 
            this.btnfermer.Location = new System.Drawing.Point(663, 357);
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.Size = new System.Drawing.Size(75, 23);
            this.btnfermer.TabIndex = 3;
            this.btnfermer.Text = "FERMER";
            this.btnfermer.UseVisualStyleBackColor = true;
            this.btnfermer.Click += new System.EventHandler(this.Btnfermer_Click);
            // 
            // bsEquipe
            // 
            this.bsEquipe.CurrentChanged += new System.EventHandler(this.BsEquipe_CurrentChanged);
            // 
            // FormGestionEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(782, 407);
            this.Controls.Add(this.btnfermer);
            this.Controls.Add(this.gbequipe);
            this.Controls.Add(this.cbModifEquipe);
            this.Controls.Add(this.labelajmodequipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionEquipe";
            this.Text = "FormGestionEquipe";
            this.Load += new System.EventHandler(this.FormGestionEquipe_Load);
            this.gbequipe.ResumeLayout(false);
            this.gbequipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMembre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEquipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMembre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelajmodequipe;
        private System.Windows.Forms.ComboBox cbModifEquipe;
        private System.Windows.Forms.GroupBox gbequipe;
        private System.Windows.Forms.Button btnfermer;
        private System.Windows.Forms.Button btnajmodequip;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtlienprot;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.TextBox txtnomequip;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lbllog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbllienPrototype;
        private System.Windows.Forms.Label lblnomequipe;
        private System.Windows.Forms.BindingSource bsEquipe;
        private System.Windows.Forms.DataGridView dvgMembre;
        private System.Windows.Forms.BindingSource bsMembre;
        private System.Windows.Forms.Button btnsupprimerMembreE;
        private System.Windows.Forms.Label labelmembreasso;
        private System.Windows.Forms.Button btnaddMembre;
    }
}