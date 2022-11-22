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
    public partial class FormListeMembre : Form
    {
        public FormListeMembre()
        {
            InitializeComponent();
            CBEquipe.ValueMember = "idequipe";//permet de stocker l'identifiant
            CBEquipe.DisplayMember = "nomequipe";
            bsEquipe.DataSource = Modele.listeEquipe();
            CBEquipe.DataSource = bsEquipe;
            CBEquipe.SelectedIndex = -1;
        }

        private void FormListeClient_Load(object sender, EventArgs e)
        {
            bsMembre.DataSource = Modele.listeMembres().Select(x => new { x.idmembre, x.idequipe, x.nom,x.prenom,x.email,x.telephone,x.datenaissance,x.lienportfolio, x.EstArchivéMembre })
                           .Where(x => x.EstArchivéMembre == false)
                            .OrderBy(x => x.idmembre);

            dgvlistemembre.DataSource = bsMembre;
            dgvlistemembre.Columns[0].HeaderText = "Identifiant";
            dgvlistemembre.Columns[1].HeaderText = "identifiant Equipe";
            dgvlistemembre.Columns[2].HeaderText = "Nom";
            dgvlistemembre.Columns[3].HeaderText = "Prénom";
            dgvlistemembre.Columns[4].HeaderText = "Email";
            dgvlistemembre.Columns[5].HeaderText = "Téléphone";
            dgvlistemembre.Columns[6].HeaderText = "DateNaissance";
            dgvlistemembre.Columns[7].HeaderText = "LienPortfolio";
            
        }

        public void rechardataMEMBRE(DataGridView dgv)
        {

            bsMembre.DataSource = Modele.listeMembres().Select(x => new { x.idmembre, x.idequipe, x.nom, x.prenom, x.email, x.telephone, x.datenaissance, x.lienportfolio, x.EstArchivéMembre })
                           .Where(x => x.EstArchivéMembre == false)
                            .OrderBy(x => x.idmembre);

            dgvlistemembre.DataSource = bsMembre;
            dgvlistemembre.Columns[0].HeaderText = "Identifiant";
            dgvlistemembre.Columns[1].HeaderText = "identifiant Equipe";
            dgvlistemembre.Columns[2].HeaderText = "Nom";
            dgvlistemembre.Columns[3].HeaderText = "Prénom";
            dgvlistemembre.Columns[4].HeaderText = "Email";
            dgvlistemembre.Columns[5].HeaderText = "Téléphone";
            dgvlistemembre.Columns[6].HeaderText = "DateNaissance";
            dgvlistemembre.Columns[7].HeaderText = "LienPortfolio";
        }


        /*quand tu vas changer le combo box equipe ça va mettre à jour le datagridview des membres*/
        private void BsEquipe_CurrentChanged(object sender, EventArgs e)
        {
            bsMembre.DataSource = ((EQUIPE)bsEquipe.Current).MEMBRE.Select(x => new
            {

                x.idmembre,
                x.EQUIPE.nomequipe,
                x.nom,
                x.prenom,
                x.email,

            }).OrderBy(x => x.idmembre);
            dgvlistemembre.DataSource = bsMembre;
        }

        private void Btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnsuppr_Click(object sender, EventArgs e)
        {
            System.Type type = bsMembre.Current.GetType();
            int idM = (int)type.GetProperty("idmembre").GetValue(bsMembre.Current, null);
            if (Modele.SuppMEMBRE(idM))
            {
                MessageBox.Show("Suppression Effectué !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Modele.listeHackathons();
                rechardataMEMBRE(dgvlistemembre);
            }
            else
            {
                MessageBox.Show("Suppression non réalisé !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnArchi_Click(object sender, EventArgs e)
        {
            System.Type type = bsMembre.Current.GetType();
            int idMe = (int)type.GetProperty("idmembre").GetValue(bsMembre.Current, null);
            if (Modele.ModifiArchivageMembre(idMe))
            {
                MessageBox.Show("Archivage Effectué !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rechardataMEMBRE(dgvlistemembre);
            }
            else
            {
                MessageBox.Show("Archivage non réalisé !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
