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
    public partial class Form1 : Form
    {
        private Service metier = new Service();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReference.Text)
                || string.IsNullOrEmpty(txtLibelle.Text)
                || string .IsNullOrEmpty(txtStock.Text)
                || string .IsNullOrEmpty(txtPrix.Text)
                || string.IsNullOrEmpty(ComboCategorie.Text))
                
            {
                MessageBox.Show("tout les champs sont obligatoires",
                    "Message Erreur",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                Article article = new Article()
                {
                    Reference = txtLibelle.Text.Trim(),
                    Libelle = txtLibelle.Text.Trim(),
                    Stock = txtStock.Text.Trim(),
                    Prix= int.Parse(txtPrix.Text.Trim()),
                    Categorie= ComboCategorie.Text.Trim()
                };
                 if (metier.EnregistrerArticle(article))
                {
                    MessageBox.Show("Article enregistré avec succés",
                    "Message Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                    txtReference.Clear();
                    txtLibelle.Clear();
                    txtStock.Clear();
                    txtPrix.Clear();
                    //ComboCategorie.Clear();
                    LoadDataGriedView();
                }
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGriedView();
        }
        private void LoadDataGriedView()
        {
            dtgvArticle.DataSource = metier.ListerArticle();
        }
    }
}
