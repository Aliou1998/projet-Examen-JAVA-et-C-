using GestionCommercial.entityframework;
using GestionCommercial.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommercial
{
    public partial class FrmInscription : Form
    {
        private ServiceEF metierEF = new ServiceEF();

        public FrmInscription()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmInscription_Load(object sender, EventArgs e)
        {
           //cboProfil.DataSource = metierEF.ListerUser();
            //cboProfil.DisplayMember = "user";
            //cboProfil.ValueMember = "id";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtNomComplet.Text))   
            {
                MessageBox.Show(
                    " chanps Obligatoire",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                personne pers = new personne()
                {
                    nom_complet = txtNomComplet.Text.Trim(),
                    login = txtLogin.Text.Trim(),
                    type="User",


                };

                if (metierEF.EnregistrerUser(pers))
                {
                    MessageBox.Show(
                   " User inscrit avec succes",
                   "Information",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
                }
                else
                {
                     MessageBox.Show(
                    " Erruer d'inscription",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}
