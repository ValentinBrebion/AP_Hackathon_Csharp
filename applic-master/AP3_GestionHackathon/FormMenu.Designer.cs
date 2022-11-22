namespace AP3_GestionHackathon
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.hACKATHONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesHackathonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesHackathonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eQUIPEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUneÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesMembresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dECONNEXIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUITTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelconnexion = new System.Windows.Forms.Panel();
            this.btnconn = new System.Windows.Forms.Button();
            this.txtmdp = new System.Windows.Forms.TextBox();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.lblmdp = new System.Windows.Forms.Label();
            this.lbllog = new System.Windows.Forms.Label();
            this.lblconnexion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBLBienvenue = new System.Windows.Forms.Label();
            this.menuStripPrincipal.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelconnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hACKATHONToolStripMenuItem,
            this.eQUIPEToolStripMenuItem,
            this.mEMBREToolStripMenuItem,
            this.dECONNEXIONToolStripMenuItem,
            this.qUITTERToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // hACKATHONToolStripMenuItem
            // 
            this.hACKATHONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesHackathonsToolStripMenuItem,
            this.gestionDesHackathonsToolStripMenuItem,
            this.modificationToolStripMenuItem});
            this.hACKATHONToolStripMenuItem.Name = "hACKATHONToolStripMenuItem";
            this.hACKATHONToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.hACKATHONToolStripMenuItem.Text = "HACKATHON";
            // 
            // listeDesHackathonsToolStripMenuItem
            // 
            this.listeDesHackathonsToolStripMenuItem.Name = "listeDesHackathonsToolStripMenuItem";
            this.listeDesHackathonsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.listeDesHackathonsToolStripMenuItem.Text = "Liste des hackathons";
            this.listeDesHackathonsToolStripMenuItem.Click += new System.EventHandler(this.ListeDesHackathonsToolStripMenuItem_Click);
            // 
            // gestionDesHackathonsToolStripMenuItem
            // 
            this.gestionDesHackathonsToolStripMenuItem.Name = "gestionDesHackathonsToolStripMenuItem";
            this.gestionDesHackathonsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionDesHackathonsToolStripMenuItem.Text = "Ajout d\'un hackathon";
            this.gestionDesHackathonsToolStripMenuItem.Click += new System.EventHandler(this.GestionDesHackathonsToolStripMenuItem_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.modificationToolStripMenuItem.Text = "Modification";
            this.modificationToolStripMenuItem.Click += new System.EventHandler(this.ModificationToolStripMenuItem_Click);
            // 
            // eQUIPEToolStripMenuItem
            // 
            this.eQUIPEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneÉquipeToolStripMenuItem,
            this.modifierUneÉquipeToolStripMenuItem});
            this.eQUIPEToolStripMenuItem.Name = "eQUIPEToolStripMenuItem";
            this.eQUIPEToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.eQUIPEToolStripMenuItem.Text = "EQUIPE";
            // 
            // ajouterUneÉquipeToolStripMenuItem
            // 
            this.ajouterUneÉquipeToolStripMenuItem.Name = "ajouterUneÉquipeToolStripMenuItem";
            this.ajouterUneÉquipeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ajouterUneÉquipeToolStripMenuItem.Text = "Ajouter une équipe";
            this.ajouterUneÉquipeToolStripMenuItem.Click += new System.EventHandler(this.AjouterUneÉquipeToolStripMenuItem_Click);
            // 
            // modifierUneÉquipeToolStripMenuItem
            // 
            this.modifierUneÉquipeToolStripMenuItem.Name = "modifierUneÉquipeToolStripMenuItem";
            this.modifierUneÉquipeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.modifierUneÉquipeToolStripMenuItem.Text = "Modifier une équipe";
            this.modifierUneÉquipeToolStripMenuItem.Click += new System.EventHandler(this.ModifierUneÉquipeToolStripMenuItem_Click);
            // 
            // mEMBREToolStripMenuItem
            // 
            this.mEMBREToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesMembresToolStripMenuItem,
            this.ajouterMembreToolStripMenuItem,
            this.modifierMembreToolStripMenuItem});
            this.mEMBREToolStripMenuItem.Name = "mEMBREToolStripMenuItem";
            this.mEMBREToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.mEMBREToolStripMenuItem.Text = "MEMBRE";
            // 
            // listeDesMembresToolStripMenuItem
            // 
            this.listeDesMembresToolStripMenuItem.Name = "listeDesMembresToolStripMenuItem";
            this.listeDesMembresToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listeDesMembresToolStripMenuItem.Text = "Liste des Membres";
            this.listeDesMembresToolStripMenuItem.Click += new System.EventHandler(this.ListeDesMembresToolStripMenuItem_Click);
            // 
            // ajouterMembreToolStripMenuItem
            // 
            this.ajouterMembreToolStripMenuItem.Name = "ajouterMembreToolStripMenuItem";
            this.ajouterMembreToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ajouterMembreToolStripMenuItem.Text = "Ajouter Membre";
            this.ajouterMembreToolStripMenuItem.Click += new System.EventHandler(this.AjouterMembreToolStripMenuItem_Click);
            // 
            // modifierMembreToolStripMenuItem
            // 
            this.modifierMembreToolStripMenuItem.Name = "modifierMembreToolStripMenuItem";
            this.modifierMembreToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modifierMembreToolStripMenuItem.Text = "Modifier Membre";
            this.modifierMembreToolStripMenuItem.Click += new System.EventHandler(this.ModifierMembreToolStripMenuItem_Click);
            // 
            // dECONNEXIONToolStripMenuItem
            // 
            this.dECONNEXIONToolStripMenuItem.Name = "dECONNEXIONToolStripMenuItem";
            this.dECONNEXIONToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.dECONNEXIONToolStripMenuItem.Text = "DECONNEXION";
            this.dECONNEXIONToolStripMenuItem.Click += new System.EventHandler(this.DECONNEXIONToolStripMenuItem_Click);
            // 
            // qUITTERToolStripMenuItem
            // 
            this.qUITTERToolStripMenuItem.Name = "qUITTERToolStripMenuItem";
            this.qUITTERToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.qUITTERToolStripMenuItem.Text = "QUITTER";
            this.qUITTERToolStripMenuItem.Click += new System.EventHandler(this.QUITTERToolStripMenuItem_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FloralWhite;
            this.panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPrincipal.Controls.Add(this.LBLBienvenue);
            this.panelPrincipal.Controls.Add(this.panelconnexion);
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 28);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(800, 423);
            this.panelPrincipal.TabIndex = 1;
            // 
            // panelconnexion
            // 
            this.panelconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelconnexion.Controls.Add(this.btnconn);
            this.panelconnexion.Controls.Add(this.txtmdp);
            this.panelconnexion.Controls.Add(this.txtlog);
            this.panelconnexion.Controls.Add(this.lblmdp);
            this.panelconnexion.Controls.Add(this.lbllog);
            this.panelconnexion.Controls.Add(this.lblconnexion);
            this.panelconnexion.Location = new System.Drawing.Point(228, 79);
            this.panelconnexion.Name = "panelconnexion";
            this.panelconnexion.Size = new System.Drawing.Size(291, 241);
            this.panelconnexion.TabIndex = 3;
            // 
            // btnconn
            // 
            this.btnconn.Location = new System.Drawing.Point(97, 202);
            this.btnconn.Name = "btnconn";
            this.btnconn.Size = new System.Drawing.Size(75, 23);
            this.btnconn.TabIndex = 6;
            this.btnconn.Text = "Connexion";
            this.btnconn.UseVisualStyleBackColor = true;
            this.btnconn.Click += new System.EventHandler(this.Btnconn_Click);
            // 
            // txtmdp
            // 
            this.txtmdp.Location = new System.Drawing.Point(76, 157);
            this.txtmdp.Name = "txtmdp";
            this.txtmdp.PasswordChar = '*';
            this.txtmdp.Size = new System.Drawing.Size(131, 20);
            this.txtmdp.TabIndex = 5;
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(97, 82);
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(100, 20);
            this.txtlog.TabIndex = 4;
            // 
            // lblmdp
            // 
            this.lblmdp.AutoSize = true;
            this.lblmdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmdp.Location = new System.Drawing.Point(72, 118);
            this.lblmdp.Name = "lblmdp";
            this.lblmdp.Size = new System.Drawing.Size(135, 24);
            this.lblmdp.TabIndex = 3;
            this.lblmdp.Text = "Mot de passe";
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog.Location = new System.Drawing.Point(109, 45);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(62, 24);
            this.lbllog.TabIndex = 2;
            this.lbllog.Text = "Login";
            // 
            // lblconnexion
            // 
            this.lblconnexion.AutoSize = true;
            this.lblconnexion.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconnexion.ForeColor = System.Drawing.Color.White;
            this.lblconnexion.Location = new System.Drawing.Point(83, 0);
            this.lblconnexion.Name = "lblconnexion";
            this.lblconnexion.Size = new System.Drawing.Size(124, 25);
            this.lblconnexion.TabIndex = 1;
            this.lblconnexion.Text = "Connexion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 420);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LBLBienvenue
            // 
            this.LBLBienvenue.AutoSize = true;
            this.LBLBienvenue.BackColor = System.Drawing.Color.Transparent;
            this.LBLBienvenue.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLBienvenue.Location = new System.Drawing.Point(200, 32);
            this.LBLBienvenue.Name = "LBLBienvenue";
            this.LBLBienvenue.Size = new System.Drawing.Size(354, 21);
            this.LBLBienvenue.TabIndex = 4;
            this.LBLBienvenue.Text = "BIENVENUE SUR HACKAT\' INNOV !";
            this.LBLBienvenue.Visible = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.menuStripPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "FormMenu";
            this.Text = "HACKAT\'INNOV";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelconnexion.ResumeLayout(false);
            this.panelconnexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem hACKATHONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesHackathonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesHackathonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUITTERToolStripMenuItem;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblconnexion;
        private System.Windows.Forms.Panel panelconnexion;
        private System.Windows.Forms.Button btnconn;
        private System.Windows.Forms.TextBox txtmdp;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.Label lblmdp;
        private System.Windows.Forms.Label lbllog;
        private System.Windows.Forms.ToolStripMenuItem dECONNEXIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eQUIPEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEMBREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesMembresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneÉquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUneÉquipeToolStripMenuItem;
        private System.Windows.Forms.Label LBLBienvenue;
    }
}