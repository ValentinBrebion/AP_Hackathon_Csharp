using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace AP3_GestionHackathon
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            dECONNEXIONToolStripMenuItem.Visible = false;
            hACKATHONToolStripMenuItem.Visible = false;
            eQUIPEToolStripMenuItem.Visible = false;
            mEMBREToolStripMenuItem.Visible = false;


        }

       

        private void QUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListeDesHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHackathon());
        }

     

        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formEnfant);
            panelPrincipal.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }


        private void GestionDesHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionHackathon(EtatGestion.Create)); // Form de Gestion en ajout (create)
        }

        private void ModificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionHackathon(EtatGestion.Update)); // Form de Gestion en modification (update)
        }

        private void Btnconn_Click(object sender, EventArgs e)
        {
            if (txtlog.Text == "" || txtmdp.Text == "")
            {
                if (txtmdp.Text == "")
                {
                    MessageBox.Show("aucun mot de passe n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txtlog.Text == "")
                {
                    MessageBox.Show("aucun login n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if( Modele.ConnexionAdministrateur(txtlog.Text, txtmdp.Text))
                {
                     
                    panelconnexion.Visible = false;
                    

                    dECONNEXIONToolStripMenuItem.Visible = true;
                    eQUIPEToolStripMenuItem.Visible = true;
                    hACKATHONToolStripMenuItem.Visible = true;
                    mEMBREToolStripMenuItem.Visible = true;
                    qUITTERToolStripMenuItem.Visible = false;
                    LBLBienvenue.Visible = true;

                }
                else
                {
                    MessageBox.Show("Connexion refusé, MAUVAIS identifiants");
                }
               
            }
        }

        private void DECONNEXIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mEMBREToolStripMenuItem.Visible = false;
            panelconnexion.Visible = true;
            dECONNEXIONToolStripMenuItem.Visible = false;
            hACKATHONToolStripMenuItem.Visible = false;
            eQUIPEToolStripMenuItem.Visible = false;
            qUITTERToolStripMenuItem.Visible = true;
            txtlog.Text = "";
            txtmdp.Text = "";

        }

        

       


      

        private void AjouterMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionMembre(EtatGestionMembre.Create));
        }

        private void ModifierMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionMembre(EtatGestionMembre.Update));
        }

        private void ListeDesMembresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormListeMembre());
        }

        private void AjouterUneÉquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionEquipe(EtatGestionEquipe.Create));
        }

        private void ModifierUneÉquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionEquipe(EtatGestionEquipe.Update));
        }
    }
}
