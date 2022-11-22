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
    public enum EtatGestionEquipe
    {
        Create,
        Update
    }
    public partial class FormGestionEquipe : Form
    {
        private EtatGestionEquipe etat;
        public FormGestionEquipe(EtatGestionEquipe etat)
        {
            InitializeComponent();
            this.etat = etat;
        }

        private void Btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //******************ComboBox Equipe ********************************//
        public void RemplirListeEquipe()
        {
            cbModifEquipe.ValueMember = "idequipe";//permet de stocker l'identifiant
            cbModifEquipe.DisplayMember = "nomequipe";
            bsEquipe.DataSource = Modele.listeEquipe();
            /*Partie Membre*/
            bsMembre.DataSource = Modele.listeMembres();
            dvgMembre.DataSource = bsMembre;
            cbModifEquipe.DataSource = bsEquipe;
            cbModifEquipe.SelectedIndex = -1;
        }

       

        private void FormGestionEquipe_Load(object sender, EventArgs e)
        {
            if (etat == EtatGestionEquipe.Create) // cas etat create
            {
                labelajmodequipe.Text = "Ajout d'une Equipe";
                btnajmodequip.Text = "AJOUTER";
                gbequipe.Visible = true;
                cbModifEquipe.Visible = false;

            }
            else // cas etat update
            {
                labelajmodequipe.Text = "Modification d'une Equipe";
                btnajmodequip.Text = "MODIFIER";
                gbequipe.Visible = false;
                cbModifEquipe.Visible = true;
                RemplirListeEquipe();
            }
        }

        public void rechardata(DataGridView dgv)
        {
            bsMembre.DataSource = ((EQUIPE)bsEquipe.Current).MEMBRE.Select(x => new {  x.idmembre,x.idequipe, x.nom, x.prenom });
            dvgMembre.DataSource = bsMembre;

            dvgMembre.Columns[0].HeaderText = "idmembre";
            dvgMembre.Columns[1].HeaderText = "idequipe";
            dvgMembre.Columns[2].HeaderText = "nom";
            dvgMembre.Columns[3].HeaderText = "prenom";


            /*dvgMembre.Columns[1].Visible = false;*/

        }

        private void Btnajmodequip_Click(object sender, EventArgs e)
        {
            string nomEquipe, lienprot, Login, Password;
            int nbpart;

            if (txtlienprot.Text != "" && txtlog.Text != "" && txtpass.Text != "" && txtnomequip.Text != "")
            {
                nomEquipe = txtnomequip.Text;
                lienprot = txtlienprot.Text;
                Login = txtlog.Text;
                Password = txtpass.Text;
                nbpart = 0;
                

                if (etat == EtatGestionEquipe.Create) // cas de l'ajout
                {

                    if (Modele.AjoutEquipe(nomEquipe, lienprot, nbpart ,Login, Password))
                    {
                        MessageBox.Show("Equipe ajouté " + Modele.RetourneDerniereEquipeSaisi());

                    }
                }
                if (etat == EtatGestionEquipe.Update)
                {
                    EQUIPE E = (EQUIPE)bsEquipe.Current;
                    if (Modele.ModificationEquipe(E.idequipe, nomEquipe, lienprot, nbpart,Login, Password))
                    {
                        MessageBox.Show("Equipe modifié");
                        gbequipe.Visible = false;
                        cbModifEquipe.SelectedIndex = -1;
                        // Annuler();
                    }
                }
            }
            else
            {
                MessageBox.Show("Erreur ! Champs non renseigné(s) !","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void BsEquipe_CurrentChanged(object sender, EventArgs e)
        {
            if (cbModifEquipe.SelectedIndex != -1)
            {
                // récupération de l'hackathon sélectionné
                EQUIPE E = (EQUIPE)bsEquipe.Current;

                // mise à jour des champs de l'hackathon sélectionné
                txtnomequip.Text = E.nomequipe;
                txtlog.Text = E.login;
                txtlienprot.Text = E.lienprototype;
                txtpass.Text = E.password;

                bsMembre.DataSource = ((EQUIPE)bsEquipe.Current).MEMBRE.Select(x => new { x.idmembre, x.nom,x.prenom });
                dvgMembre.DataSource = bsMembre;
                gbequipe.Visible = true;
            }
            else
                gbequipe.Visible = false;
        }

        private void CbModifEquipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            BsEquipe_CurrentChanged(sender, e);
        }

        private void BtnaddMembre_Click(object sender, EventArgs e)
        {
            System.Type type = bsEquipe.Current.GetType();
            int indexEquipe = (int)type.GetProperty("idequipe").GetValue(bsEquipe.Current, null);

            
                FormAjoutMembre FAM = new FormAjoutMembre(indexEquipe);
                FAM.Show();
            rechardata(dvgMembre);




        }

        private void BtnsupprimerMembreE_Click(object sender, EventArgs e)
        {
            System.Type type = bsMembre.Current.GetType();
            int idEMem = (int)type.GetProperty("idmembre").GetValue(bsMembre.Current, null);
            if (Modele.SupprEquipeMembre(idEMem))
            {
                MessageBox.Show("Suppression Effectué ce membre ne fait plus partie de cette equipe !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                rechardata(dvgMembre);
            }
            else
            {
                MessageBox.Show("Suppression non réalisé !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
