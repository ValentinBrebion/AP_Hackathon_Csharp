
namespace AP3_GestionHackathon
{
    partial class FormGestionMembre
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
            this.labelajoutmodif = new System.Windows.Forms.Label();
            this.cbmodifmembre = new System.Windows.Forms.ComboBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.gbmembre = new System.Windows.Forms.GroupBox();
            this.labelequipe = new System.Windows.Forms.Label();
            this.cbequipe = new System.Windows.Forms.ComboBox();
            this.dtnaiss = new System.Windows.Forms.DateTimePicker();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblnaissance = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblprenom = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.btnajoutmodif = new System.Windows.Forms.Button();
            this.bsMembre = new System.Windows.Forms.BindingSource(this.components);
            this.bsequipe = new System.Windows.Forms.BindingSource(this.components);
            this.gbmembre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMembre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsequipe)).BeginInit();
            this.SuspendLayout();
            // 
            // labelajoutmodif
            // 
            this.labelajoutmodif.AutoSize = true;
            this.labelajoutmodif.Location = new System.Drawing.Point(28, 33);
            this.labelajoutmodif.Name = "labelajoutmodif";
            this.labelajoutmodif.Size = new System.Drawing.Size(0, 13);
            this.labelajoutmodif.TabIndex = 0;
            // 
            // cbmodifmembre
            // 
            this.cbmodifmembre.FormattingEnabled = true;
            this.cbmodifmembre.Location = new System.Drawing.Point(288, 25);
            this.cbmodifmembre.Name = "cbmodifmembre";
            this.cbmodifmembre.Size = new System.Drawing.Size(422, 21);
            this.cbmodifmembre.TabIndex = 1;
            this.cbmodifmembre.SelectedIndexChanged += new System.EventHandler(this.cbmodifmembre_SelectedIndexChanged_1);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(651, 345);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Fermer";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // gbmembre
            // 
            this.gbmembre.BackColor = System.Drawing.Color.OliveDrab;
            this.gbmembre.Controls.Add(this.labelequipe);
            this.gbmembre.Controls.Add(this.cbequipe);
            this.gbmembre.Controls.Add(this.dtnaiss);
            this.gbmembre.Controls.Add(this.txtPort);
            this.gbmembre.Controls.Add(this.txttel);
            this.gbmembre.Controls.Add(this.TxtEmail);
            this.gbmembre.Controls.Add(this.TxtPrenom);
            this.gbmembre.Controls.Add(this.TxtNom);
            this.gbmembre.Controls.Add(this.lbltel);
            this.gbmembre.Controls.Add(this.label5);
            this.gbmembre.Controls.Add(this.lblnaissance);
            this.gbmembre.Controls.Add(this.lblemail);
            this.gbmembre.Controls.Add(this.lblprenom);
            this.gbmembre.Controls.Add(this.lblnom);
            this.gbmembre.Controls.Add(this.btnajoutmodif);
            this.gbmembre.Location = new System.Drawing.Point(43, 75);
            this.gbmembre.Name = "gbmembre";
            this.gbmembre.Size = new System.Drawing.Size(683, 264);
            this.gbmembre.TabIndex = 3;
            this.gbmembre.TabStop = false;
            this.gbmembre.Text = "AjoutMembre";
            // 
            // labelequipe
            // 
            this.labelequipe.AutoSize = true;
            this.labelequipe.Location = new System.Drawing.Point(543, 54);
            this.labelequipe.Name = "labelequipe";
            this.labelequipe.Size = new System.Drawing.Size(40, 13);
            this.labelequipe.TabIndex = 16;
            this.labelequipe.Text = "Equipe";
            // 
            // cbequipe
            // 
            this.cbequipe.FormattingEnabled = true;
            this.cbequipe.Location = new System.Drawing.Point(546, 70);
            this.cbequipe.Name = "cbequipe";
            this.cbequipe.Size = new System.Drawing.Size(121, 21);
            this.cbequipe.TabIndex = 15;
            // 
            // dtnaiss
            // 
            this.dtnaiss.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtnaiss.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtnaiss.Location = new System.Drawing.Point(362, 147);
            this.dtnaiss.Name = "dtnaiss";
            this.dtnaiss.Size = new System.Drawing.Size(180, 20);
            this.dtnaiss.TabIndex = 13;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(362, 222);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 12;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(362, 73);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(126, 20);
            this.txttel.TabIndex = 11;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(69, 219);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(129, 20);
            this.TxtEmail.TabIndex = 10;
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(69, 148);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(129, 20);
            this.TxtPrenom.TabIndex = 9;
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(69, 73);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(129, 20);
            this.TxtNom.TabIndex = 8;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(359, 56);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(58, 13);
            this.lbltel.TabIndex = 7;
            this.lbltel.Text = "Téléphone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lien Portfolio";
            // 
            // lblnaissance
            // 
            this.lblnaissance.AutoSize = true;
            this.lblnaissance.Location = new System.Drawing.Point(359, 121);
            this.lblnaissance.Name = "lblnaissance";
            this.lblnaissance.Size = new System.Drawing.Size(96, 13);
            this.lblnaissance.TabIndex = 4;
            this.lblnaissance.Text = "Date de naissance";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(66, 192);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "Email";
            // 
            // lblprenom
            // 
            this.lblprenom.AutoSize = true;
            this.lblprenom.Location = new System.Drawing.Point(66, 121);
            this.lblprenom.Name = "lblprenom";
            this.lblprenom.Size = new System.Drawing.Size(43, 13);
            this.lblprenom.TabIndex = 2;
            this.lblprenom.Text = "Prenom";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(66, 56);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(29, 13);
            this.lblnom.TabIndex = 1;
            this.lblnom.Text = "Nom";
            // 
            // btnajoutmodif
            // 
            this.btnajoutmodif.Location = new System.Drawing.Point(592, 222);
            this.btnajoutmodif.Name = "btnajoutmodif";
            this.btnajoutmodif.Size = new System.Drawing.Size(75, 23);
            this.btnajoutmodif.TabIndex = 0;
            this.btnajoutmodif.Text = "button1";
            this.btnajoutmodif.UseVisualStyleBackColor = true;
            this.btnajoutmodif.Click += new System.EventHandler(this.Btnajoutmodif_Click);
            // 
            // FormGestionMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(776, 392);
            this.Controls.Add(this.gbmembre);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.cbmodifmembre);
            this.Controls.Add(this.labelajoutmodif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionMembre";
            this.Text = "FormGestionMembre";
            this.Load += new System.EventHandler(this.FormGestionMembre_Load);
            this.gbmembre.ResumeLayout(false);
            this.gbmembre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMembre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsequipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelajoutmodif;
        private System.Windows.Forms.ComboBox cbmodifmembre;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.GroupBox gbmembre;
        private System.Windows.Forms.Button btnajoutmodif;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblnaissance;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblprenom;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.DateTimePicker dtnaiss;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.BindingSource bsMembre;
        private System.Windows.Forms.ComboBox cbequipe;
        private System.Windows.Forms.Label labelequipe;
        private System.Windows.Forms.BindingSource bsequipe;
    }
}