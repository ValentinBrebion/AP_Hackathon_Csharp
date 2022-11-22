using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_GestionHackathon
{
    public enum EtatGestionMembre
    {
        Create,
        Update
    }
    public partial class FormGestionMembre : Form
    {
        private EtatGestionMembre etat;
        public FormGestionMembre(EtatGestionMembre etat)
        {
            InitializeComponent();
            this.etat = etat;
        }
        public void RemplirListeMembre()
        {
            cbmodifmembre.ValueMember = "idmembre";//permet de stocker l'identifiant
            cbmodifmembre.DisplayMember = "nom";
            bsMembre.DataSource = Modele.listeMembres();
            cbmodifmembre.DataSource = bsMembre;
            cbmodifmembre.SelectedIndex = -1;
        }


        private void FormGestionMembre_Load(object sender, EventArgs e)
        {
            cbequipe.ValueMember = "idequipe";//permet de stocker l'identifiant
            cbequipe.DisplayMember = "nomequipe";
            bsequipe.DataSource = Modele.listeEquipe();
            cbequipe.DataSource = bsequipe;
            cbequipe.SelectedIndex = -1;

            if (etat == EtatGestionMembre.Create) // cas etat create
            {
                labelajoutmodif.Text = "Ajout d'un Membre";
                btnajoutmodif.Text = "AJOUTER";
                gbmembre.Visible = true;
                cbmodifmembre.Visible = false;

            }
            else // cas etat update
            {
                labelajoutmodif.Text = "Modification d'un Membre";
                btnajoutmodif.Text = "MODIFIER";
                gbmembre.Visible = false;
                cbmodifmembre.Visible = true;
                RemplirListeMembre();
            }
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Annuler()
        {
            cbequipe.SelectedIndex = -1;
            TxtNom.Clear();
            TxtPrenom.Clear();
            TxtEmail.Clear();
            txttel.Clear();
            txtPort.Clear();
            dtnaiss.Value = DateTime.Now;

          
        }

        private void Btnajoutmodif_Click(object sender, EventArgs e)
           {
            int idequipe;
            string nom, prenom, email, telephone, portfolio;
            DateTime datnaiss;

            /*Conditions si nom, prenom, email, telephone, portfolio et datenaiss ne sont pas renseignés*/

            if (TxtNom.Text != "" && TxtEmail.Text != "" && TxtPrenom.Text != "" && dtnaiss.Value < DateTime.Now)
            {
                idequipe = cbequipe.SelectedIndex; 
                nom = TxtNom.Text;
                prenom = TxtPrenom.Text;
                email = TxtEmail.Text;
                telephone = txttel.Text;
                portfolio = txtPort.Text;
                datnaiss = dtnaiss.Value;

              

                if (etat == EtatGestionMembre.Create) // cas de l'ajout
                {
                    if (Modele.AjoutMembre(idequipe, nom, prenom, email, telephone, portfolio, datnaiss))
                    {
                        MessageBox.Show("Membre ajouté " + Modele.RetourneDernierMembreSaisi());
                        Annuler();
                    }
                    else
                    {
                        MessageBox.Show("Erreur insertion : email existant ou champs non complet", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //mettre else si mail est faux
                }
                if (etat == EtatGestionMembre.Update) // cas de la mise à jour
                {
                    MEMBRE M = (MEMBRE)bsMembre.Current;
                    if (Modele.ModificationMembre(M.idmembre, nom, prenom, email, telephone, datnaiss, portfolio))
                    {
                        MessageBox.Show("Membre modifié");
                        gbmembre.Visible = false;
                        cbmodifmembre.SelectedIndex = -1;
                    }
                }




            }
            else
            {
                MessageBox.Show("Erreur ! un des champs est mal renseigné !", "Erreur ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BsMembre_CurrentChanged(object sender, EventArgs e)
        {
            if (cbmodifmembre.SelectedIndex != -1)
            {

                // récupération de l'hackathon sélectionné
                MEMBRE M = (MEMBRE)bsMembre.Current;

                // mise à jour des champs de l'hackathon sélectionné
                TxtNom.Text = M.nom;
                TxtPrenom.Text = M.prenom;
                TxtEmail.Text = M.email;
                txttel.Text = M.telephone;
                dtnaiss.Value = (DateTime)M.datenaissance;
                txtPort.Text = M.lienportfolio;





                gbmembre.Visible = true;
            }
            else
                gbmembre.Visible = false;
        }

       

        private void cbmodifmembre_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            BsMembre_CurrentChanged(sender, e);
        }
    }
}
