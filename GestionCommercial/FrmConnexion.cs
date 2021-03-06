using GestionCommercial.models;
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
    public partial class FrmConnexion : Form
    {
        Service metier = new Service();
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtLogin.Text)
                || string.IsNullOrEmpty(txtPwd.Text))
            {
                lblError.Text = "Login ou Mot de Passe Obligatoire";
                lblError.Visible = true;
            }
            else
            {
                Personne pers = metier.SeConnecter(txtLogin.Text.Trim(), txtPwd.Text.Trim());
                if (pers == null)
                {
                    lblError.Text = "Login ou Mot de Passe incorrect";
                    lblError.Visible = true;
                }
                else
                {
                    FrmMenu frmMenu = new FrmMenu();
                    frmMenu.Show();
                    this.Hide();
                }

            }
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;

        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {

        }
    }
}
