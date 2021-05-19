using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAS;
using GestionASBO; // Référence la couche BO

namespace GestionASForm
{
    public partial class AjoutBudget : Form
    {
        public AjoutBudget()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuAS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ecranDeStatistiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBudgetForm gestionBudget;
            gestionBudget = new GestionBudgetForm();
            gestionBudget.Show();
            this.Close();
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

            bool montant = textBox2.Text.All(char.IsDigit);
            if (String.IsNullOrEmpty(textBox1.Text) == true || String.IsNullOrEmpty(textBox2.Text) == true || !montant)
            {
                MessageBox.Show("Veuillez remplir tous les champs");

            }
            else
            {
                string libelleBudget = textBox1.Text;
                int montantInitial = int.Parse(textBox2.Text);
                MessageBox.Show("Le nouveau budget a bien été ajouté");
                Budget unBudget = new Budget(libelleBudget, montantInitial);
                GestionBudget.AjoutBudget(unBudget);
                this.Close();
                GestionBudgetForm gestionBudget;
                gestionBudget = new GestionBudgetForm();
                gestionBudget.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AjoutBudget_Load(object sender, EventArgs e)
        {

        }

    }
}
