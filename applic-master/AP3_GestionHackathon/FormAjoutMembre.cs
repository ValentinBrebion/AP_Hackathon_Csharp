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
    public partial class FormAjoutMembre : Form
    {
        public FormAjoutMembre(int indexEquipe)
        {
            InitializeComponent();
            txtIndexEquipe.Text = Convert.ToString(indexEquipe);
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void FormAjoutMembre_Load(object sender, EventArgs e)
        {
            bsMembre.DataSource = Modele.listeMembres().Select(x => new { x.idmembre,x.idequipe,x.nom,x.prenom })
                            .Where(x => x.idequipe == null)
                            .OrderBy(x => x.idmembre);

            dgvMembrenoninscrit.DataSource = bsMembre;
            dgvMembrenoninscrit.Columns[0].HeaderText = "idmembre";
            dgvMembrenoninscrit.Columns[1].HeaderText = "idequipe";
            dgvMembrenoninscrit.Columns[2].HeaderText = "nom";
            dgvMembrenoninscrit.Columns[3].HeaderText = "prenom";


            dgvMembrenoninscrit.Columns[1].Visible = false;
        }

        private void btnAjoutMembreEquipe_Click(object sender, EventArgs e)
        {
            int indexEquipe = Convert.ToInt32(txtIndexEquipe.Text);
            System.Type type = bsMembre.Current.GetType();
            int idMembre = (int)type.GetProperty("idmembre").GetValue(bsMembre.Current, null);
            if (Modele.AjoutEquipeMembre(idMembre, indexEquipe))
            {
                MessageBox.Show("Ajout Effectué ce membre fait partie de cette equipe !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

               
            }
            else
            {
                MessageBox.Show("Ajout non réalisé !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
