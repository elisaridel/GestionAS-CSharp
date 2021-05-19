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
    public partial class ModificationFlux : Form
    {
        private int id_flux;
        private string libelle;
        private string montant;
        private string adherent;
        private string type;
        private string budget;
        private string etatPrelevement;
        public ModificationFlux(int id_flux, string libelle, string montant, string adherent, string type, string budget, string etatPrelevement)
        {
            this.id_flux = id_flux;
            this.libelle = libelle;
            this.montant = montant;
            this.adherent = adherent;
            this.type = type;
            this.budget = budget;
            this.etatPrelevement = etatPrelevement;
            InitializeComponent();
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionASForm"]);
        }

        private void ModificationFlux_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionASDataSet1.type_flux'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.type_fluxTableAdapter.Fill(this.gestionASDataSet1.type_flux);
            // TODO: cette ligne de code charge les données dans la table 'adherent1._adherent'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.adherentTableAdapter.Fill(this.adherent1._adherent);
            // TODO: cette ligne de code charge les données dans la table 'budget1._budget'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.budgetTableAdapter.Fill(this.budget1._budget);

            libelleTextBox.Text = libelle;
            montantTextBox.Text = montant;
            comboBox1.SelectedValue = budget;
            comboBox2.SelectedValue = adherent;
            comboBox3.SelectedValue = type;
            comboBox4.Text = etatPrelevement;
        }

        private bool ValidateFlux()
        {
            bool bStatus = true;
            if (libelleTextBox.Text == "")
            {
                errorProvider1.SetError(libelleTextBox, "Entrez un libelle");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(libelleTextBox, "");
            }
            return bStatus;
        }
        private bool ValidateMontant()
        {
            bool bStatus = true;
            bool montant = montantTextBox.Text.All(char.IsDigit);
            if (montantTextBox.Text == "" || !montant)
            {
                errorProvider2.SetError(montantTextBox, "Entrez un montant");
                bStatus = false;
            }
            else
            {
                errorProvider2.SetError(montantTextBox, "");
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
            if (comboBox3.Text == "")
            {
                errorProvider5.SetError(comboBox3, "Selectionnez un type de flux");
                bStatus = false;
            }
            else
            {
                errorProvider5.SetError(comboBox3, "");
            }
            return bStatus;
        }
        private bool ValidateBudget()
        {
            bool bStatus = true;
            if (comboBox1.Text == "")
            {
                errorProvider3.SetError(comboBox1, "Selectionnez un budget");
                bStatus = false;
            }
            else
            {
                errorProvider3.SetError(comboBox1, "");
            }
            return bStatus;
        }
        private bool ValidatePrelev()
        {
            bool bStatus = true;
            if (comboBox4.Text == "")
            {
                errorProvider6.SetError(comboBox4, "Selectionnez l'état du prélèvement");
                bStatus = false;
            }
            else
            {
                errorProvider6.SetError(comboBox4, "");
            }
            return bStatus;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidateAdherent();
            ValidateBudget();
            ValidateFlux();
            ValidateMontant();
            ValidatePrelev();
            ValidateTypeflux();

            //Vérification si le formulaire est plein
            if (String.IsNullOrEmpty(libelleTextBox.Text) == true ||
                String.IsNullOrEmpty(montantTextBox.Text) == true || String.IsNullOrEmpty(comboBox1.Text) == true || String.IsNullOrEmpty(comboBox2.Text) == true || String.IsNullOrEmpty(comboBox3.Text) == true || String.IsNullOrEmpty(comboBox4.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs");

            }
            else
            {
                string libelle = libelleTextBox.Text;
                string etatPrelev = comboBox4.Text;
                int montant = int.Parse(montantTextBox.Text);
                int budget = (int)comboBox1.SelectedValue;
                int adherent = (int)comboBox2.SelectedValue;
                int type = (int)comboBox3.SelectedValue;
                DateTime thisDay = DateTime.Today;
                /*id_flux, libelle_flux, date_flux, montant_flux, id_adherent, id_typeFlux, id_budget, etat_prelevement*/
                Flux unFlux = new Flux(id_flux, libelle, thisDay, montant, adherent, type, budget, etatPrelev);
                GestionFlux.ModificationFlux(unFlux);
                MessageBox.Show("Le flux a bien été modifié");
                AffichageFlux flux;
                flux = new AffichageFlux();
                flux.Show();
                this.Close();
            }
        }

        private void ecranDeStatistiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AffichageFlux flux;
            flux = new AffichageFlux();
            flux.Show();
            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
