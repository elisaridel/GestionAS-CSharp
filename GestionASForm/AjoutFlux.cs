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
    public partial class AjoutFlux : Form
    {
        public AjoutFlux()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool ValidateFlux()
        {
            bool bStatus = true;
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Entrez un nom");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
            return bStatus;
        }
        private bool ValidateDate()
        {
            bool bStatus = true;
            if (dateTimePicker1.Text == "")
            {
                errorProvider2.SetError(dateTimePicker1, "Entrez un nom");
                bStatus = false;
            }
            else
            {
                errorProvider2.SetError(dateTimePicker1, "");
            }
            return bStatus;
        }
        private bool ValidateMontant()
        {
            bool bStatus = true;
            bool montant = textBox2.Text.All(char.IsDigit);
            if (textBox1.Text == "" || !montant)
            {
                errorProvider3.SetError(textBox2, "Entrez un montant");
                bStatus = false;
            }
            else
            {
                errorProvider3.SetError(textBox2, "");
            }
            return bStatus;
        }
        private bool ValidateAdherent()
        {
            bool bStatus = true;
            if (comboBox2.Text == "")
            {
                errorProvider4.SetError(comboBox2, "Selectionnez un adherent");
                bStatus = false;
            }
            else
            {
                errorProvider4.SetError(comboBox2, "");
            }
            return bStatus;
        }
        private bool ValidateTypeflux()
        {
            bool bStatus = true;
            if (comboBox1.Text == "")
            {
                errorProvider5.SetError(comboBox1, "Selectionnez un type de flux");
                bStatus = false;
            }
            else
            {
                errorProvider5.SetError(comboBox1, "");
            }
            return bStatus;
        }
        private bool ValidateBudget()
        {
            bool bStatus = true;
            if (comboBox3.Text == "")
            {
                errorProvider6.SetError(comboBox3, "Selectionnez un budget");
                bStatus = false;
            }
            else
            {
                errorProvider6.SetError(comboBox3, "");
            }
            return bStatus;
        }
        private bool ValidatePrelev()
        {
            bool bStatus = true;
            if (etatPrelev.Text == "")
            {
                errorProvider7.SetError(etatPrelev, "Selectionnez l'état du prélèvement");
                bStatus = false;
            }
            else
            {
                errorProvider7.SetError(etatPrelev, "");
            }
            return bStatus;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ValidateAdherent();
            ValidateBudget();
            ValidateDate();
            ValidateFlux();
            ValidateMontant();
            ValidatePrelev();
            ValidateTypeflux();

            bool montant = textBox2.Text.All(char.IsDigit);

            if (String.IsNullOrEmpty(dateTimePicker1.Text) == true || String.IsNullOrEmpty(textBox1.Text) == true || String.IsNullOrEmpty(textBox2.Text) == true
                || String.IsNullOrEmpty(comboBox1.Text) == true || String.IsNullOrEmpty(comboBox2.Text) == true ||
                String.IsNullOrEmpty(comboBox3.Text) == true || String.IsNullOrEmpty(etatPrelev.Text) == true || !montant)
            {
                MessageBox.Show("Veuillez remplir tous les champs");

            }
            else
            {
                string dateInput = dateTimePicker1.Text;
                string libelle = textBox1.Text;
                float montantFlux = float.Parse(textBox2.Text);
                var parsedDateNaissance = DateTime.Parse(dateInput);
                int idAdherent = (int)comboBox1.SelectedValue;
                int idTypeflux = (int)comboBox2.SelectedValue;
                int idBudget = (int)comboBox3.SelectedValue;
                string etatPrelevement = etatPrelev.Text;
                DateTime thisDay = DateTime.Today;
                Flux unFlux = new Flux(libelle, parsedDateNaissance, montantFlux, idAdherent, idTypeflux, idBudget, etatPrelevement);
                GestionFlux.AjoutFlux(unFlux);
                this.Close();
            }
        }

        private void AjoutFlux_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'adherent._adherent'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.adherentTableAdapter.Fill(this.adherent._adherent);
            // TODO: cette ligne de code charge les données dans la table 'budget._budget'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.budgetTableAdapter.Fill(this.budget._budget);
            // TODO: cette ligne de code charge les données dans la table 'gestionASDataSet1.type_flux'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.type_fluxTableAdapter.Fill(this.gestionASDataSet1.type_flux);

        }
    }
}
