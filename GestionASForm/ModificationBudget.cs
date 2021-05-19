using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using GestionAS;
using GestionASBO; // Référence la couche BO

namespace GestionASForm
{
    public partial class ModificationBudget : Form
    {
        private int value;
        private string libelle;
        private string montant;
        public ModificationBudget(int value, string libelle, string montant)
        {
            this.value = value;
            this.libelle = libelle;
            this.montant = montant;
            InitializeComponent();
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionASForm"]);
        }

        private void ModificationBudget_Load(object sender, EventArgs e)
        {
            textBox1.Text = libelle;
            textBox2.Text = montant;
        }

        private bool ValidateMontant()
        {
            bool bStatus = true;
            bool montant = textBox2.Text.All(char.IsDigit);
            if (textBox2.Text == "" || !montant)
            {
                errorProvider2.SetError(textBox2, "Entrez un montant");
                bStatus = false;
            }
            else
            {
                errorProvider2.SetError(textBox2, "");
            }
            return bStatus;
        }
        private bool ValidateLibelle()
        {
            bool bStatus = true;
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Entrez un libelle");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
            return bStatus;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidateMontant();
            ValidateLibelle();

            bool montant1 = textBox2.Text.All(char.IsDigit);

            //Vérification si le formulaire est plein
            if (String.IsNullOrEmpty(textBox1.Text) == true ||
                String.IsNullOrEmpty(textBox2.Text) == true || !montant1)
            {
                MessageBox.Show("Veuillez remplir tous les champs");

            }
            else
            {
                string libelle = textBox1.Text;
                int montant = int.Parse(textBox2.Text);
                Budget unBudget = new Budget(value, libelle, montant);
                GestionBudget.ModificationBudget(unBudget);
                MessageBox.Show("Le budget a bien été modifié");
                this.Close();
            }
        }

        private void ecranDeStatistiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBudgetForm budget;
            budget = new GestionBudgetForm();
            budget.Show();
            this.Close();
        }
    }
}
