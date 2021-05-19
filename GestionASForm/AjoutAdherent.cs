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
    public partial class AjoutAdherent : Form
    {
        public AjoutAdherent()
        {
            InitializeComponent();
        }

        private bool ValidateName()
        {
            bool bStatus = true;
            if (textBoxPrenom.Text == "")
            {
                errorProvider1.SetError(textBoxPrenom, "Entrez un prénom");
                bStatus = false;
            }
            else
                errorProvider1.SetError(textBoxPrenom, "");
            return bStatus;
        }
        private bool ValidateSurname()
        {
            bool bStatus = true;
            if (textBoxNom.Text == "")
            {
                errorProvider2.SetError(textBoxNom, "Entrez un nom");
                bStatus = false;
            }
            else
                errorProvider2.SetError(textBoxNom, "");
            return bStatus;
        }
        private bool ValidateEmail()
        {
            bool bStatus = true;
            if (textBoxEmail.Text == "")
            {
                errorProvider5.SetError(textBoxEmail, "Entrez un email");
                bStatus = false;
            }
            else
            {
                errorProvider5.SetError(textBoxEmail, "");
            }
            return bStatus;
        }
        private bool ValidateSexe()
        {
            bool bStatus = true;
            if (comboBoxSexe.Text == "")
            {
                errorProvider10.SetError(comboBoxSexe, "Selectionnez un sexe");
                bStatus = false;
            }
            else
            {
                errorProvider10.SetError(comboBoxSexe, "");
            }
            return bStatus;
        }
        private bool ValidateBirth()
        {
            bool bStatus = true;
            if (dateTimePicker1.Text == "")
            {
                errorProvider7.SetError(dateTimePicker1, "Selectionnez une date de naissance");
                bStatus = false;
            }
            else
            {
                errorProvider7.SetError(dateTimePicker1, "");
            }
            return bStatus;
        }
        private bool ValidateAutoPrelev()
        {
            bool bStatus = true;
            if (comboBoxAutoPrelev.Text == "")
            {
                errorProvider7.SetError(comboBoxAutoPrelev, "Sellectionner un statut de prélévement");
                bStatus = false;
            }
            else
            {
                errorProvider7.SetError(comboBoxAutoPrelev, "");
            }
            return bStatus;
        }
        private bool ValidateNumber()
        {
            bool bStatus = true;
            bool num1 = textBoxNumAdherent.Text.All(char.IsDigit);
            if (textBoxNumAdherent.Text == "" || !num1)
            {
                errorProvider4.SetError(textBoxNumAdherent, "Veuillez rentrer un numéro");
                bStatus = false;
            }
            else
            {
                errorProvider4.SetError(textBoxNumAdherent, "");
            }


            return bStatus;
        }
        private bool ValidateNumber2()
        {
            bool bStatus = true;
            bool num2 = textBoxNumParent.Text.All(char.IsDigit);

            if (textBoxNumParent.Text == "" || !num2)
            {
                errorProvider6.SetError(textBoxNumParent, "Veuillez rentrer un numéro");
                bStatus = false;
            }
            else
            {
                errorProvider6.SetError(textBoxNumParent, "");
            }
            return bStatus;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            ValidateName();
            ValidateSurname();
            ValidateNumber();
            ValidateNumber2();
            ValidateEmail();
            ValidateSexe();
            ValidateAutoPrelev();
            ValidateBirth();

            bool num1 = textBoxNumAdherent.Text.All(char.IsDigit);
            bool num2 = textBoxNumParent.Text.All(char.IsDigit);

            if (String.IsNullOrEmpty(dateTimePicker1.Text) == true || String.IsNullOrEmpty(textBoxNumAdherent.Text) == true || String.IsNullOrEmpty(textBoxNumParent.Text) == true
                || String.IsNullOrEmpty(comboBoxAutoPrelev.Text) == true || String.IsNullOrEmpty(textBoxNom.Text) == true ||
                String.IsNullOrEmpty(textBoxPrenom.Text) == true || String.IsNullOrEmpty(textBoxEmail.Text) == true || String.IsNullOrEmpty(comboBoxSexe.Text) == true || !num1 || !num2)
            {
                MessageBox.Show("Veuillez remplir tous les champs");

            }
            else
            {
                string dateInput = dateTimePicker1.Text;
                var parsedDateNaissance = DateTime.Parse(dateInput);
                int numAdherent = int.Parse(textBoxNumAdherent.Text);
                int numParent = int.Parse(textBoxNumParent.Text);
                int libelle_classe = (int)comboBox1.SelectedValue;
                DateTime thisDay = DateTime.Today;
                string autoprelev = comboBoxAutoPrelev.Text;
                Adherent unAdherent = new Adherent(textBoxNom.Text, textBoxPrenom.Text, parsedDateNaissance, numAdherent, textBoxEmail.Text, numParent, autoprelev, comboBoxSexe.Text, thisDay, libelle_classe);
                GestionAdherents.AjoutUtilisateur(unAdherent);
                MessageBox.Show("L'adhérent a bien été modifié");
                this.Close();
            }
        }

        private void AjoutAdherent_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionASDataSet.classe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.classeTableAdapter.Fill(this.gestionASDataSet.classe);

        }


        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.classeTableAdapter.FillBy(this.gestionASDataSet.classe);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxSexe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
