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
    public partial class ModificationEleve : Form
    {
        private int value;
        private string nomAdherent;
        private string prenomAdherent;
        private string ddn;
        private string numAdherent;
        private string mail;
        private string numparentAdherent;
        private string autoprelev;
        private string sexe;
        private string datemaj;
        private string archive;
        public ModificationEleve(int value, string nomAdherent, string prenomAdherent, string ddn, string numAdherent, string mail, string numparentAdherent, string autoprelev, string sexe, string datemaj, string archive)
        {
            this.value = value;
            this.nomAdherent = nomAdherent;
            this.prenomAdherent = prenomAdherent;
            this.ddn = ddn;
            this.numAdherent = numAdherent;
            this.mail = mail;
            this.numparentAdherent = numparentAdherent;
            this.autoprelev = autoprelev;
            this.sexe = sexe;
            this.datemaj = datemaj;
            this.archive = archive;

            InitializeComponent();
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionASForm"]);
        }

        private void ModificationEleve_Load(object sender, EventArgs e)
        {
            textBoxNom.Text = nomAdherent;
            textBoxPrenom.Text = prenomAdherent;
            dateTimePicker1.Text = ddn;
            textBoxNumAdherent.Text = numAdherent;
            textBoxEmail.Text = mail;
            textBoxNumParent.Text = numparentAdherent;
            comboBox2.Text = autoprelev;
            comboBox1.Text = sexe;
            comboBox3.Text = archive;
        }
        private void gestionBudgetsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionÉlèvesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBoxNom_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
        private bool ValidateName()
        {
            bool bStatus = true;
            if (textBoxPrenom.Text == "")
            {
                errorProvider2.SetError(textBoxPrenom, "Entrez un prénom");
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
                errorProvider2.SetError(textBoxEmail, "Entrez un email");
                bStatus = false;
            }
            else
                errorProvider2.SetError(textBoxEmail, "");
            return bStatus;
        }
        private bool ValidateSexe()
        {
            bool bStatus = true;
            if (comboBox1.Text == "")
            {
                errorProvider3.SetError(comboBox1, "Selectionnez un sexe");
                bStatus = false;
            }
            else
                errorProvider3.SetError(comboBox1, "");
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
                errorProvider7.SetError(dateTimePicker1, "");
            return bStatus;
        }
        private bool ValidateAutoPrelev()
        {
            bool bStatus = true;
            if (comboBox2.Text == "")
            {
                errorProvider8.SetError(comboBox2, "Sellectionner un statut de prélévement");
                bStatus = false;
            }
            else
                errorProvider8.SetError(comboBox2, "");
            return bStatus;
        }
        private bool ValidateArchive()
        {
            bool bStatus = true;
            if (comboBox3.Text == "")
            {
                errorProvider9.SetError(comboBox3, "Voulez vous archiver l'élève ?");
                bStatus = false;
            }
            else
                errorProvider9.SetError(comboBox3, "");
            return bStatus;
        }
        private bool ValidateSurname()
        {
            bool bStatus = true;
            if (textBoxNom.Text == "")
            {
                errorProvider1.SetError(textBoxNom, "Entrez un nom");
                bStatus = false;
            }
            else
                errorProvider1.SetError(textBoxNom, "");
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
                errorProvider4.SetError(textBoxNumAdherent, "");

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
                try
                {
                    float temp = float.Parse(textBoxNumParent.Text);
                    errorProvider6.SetError(textBoxNumParent, "");
                   
                    


                }
                catch
                {
                    errorProvider6.SetError(textBoxNumParent, "Veuillez rentrer un numéro de téléphone valide");
                    bStatus = false;
                }
                return bStatus;
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
            ValidateArchive();
            ValidateAutoPrelev();
            ValidateBirth();

            bool num1 = textBoxNumAdherent.Text.All(char.IsDigit);
            bool num2 = textBoxNumParent.Text.All(char.IsDigit);


            //Vérification si le formulaire est plein
            if (String.IsNullOrEmpty(dateTimePicker1.Text) == true || String.IsNullOrEmpty(textBoxNumAdherent.Text) == true || String.IsNullOrEmpty(textBoxNumParent.Text) == true
                 || String.IsNullOrEmpty(comboBox2.Text) == true || String.IsNullOrEmpty(textBoxNom.Text) == true ||
                String.IsNullOrEmpty(textBoxPrenom.Text) == true || String.IsNullOrEmpty(textBoxEmail.Text) == true || String.IsNullOrEmpty(comboBox3.Text) == true || !num1 || !num2)
            {
                MessageBox.Show("Veuillez remplir tous les champs correctement");

            }
            else
            {
                string dateInput = dateTimePicker1.Text;
                var parsedDateNaissance = DateTime.Parse(dateInput);
                long numAdherent = long.Parse(textBoxNumAdherent.Text);
                long numParent = long.Parse(textBoxNumParent.Text);
                string archive_adherent = comboBox3.Text;
                DateTime thisDay = DateTime.Today;
                string autoprelev = comboBox2.Text;
                /*Adherent unAdherent = new Adherent(value, textBoxNom.Text, textBoxPrenom.Text, parsedDateNaissance, numAdherent, textBoxEmail.Text, numParent, autoprelev, textBoxSexe.Text, dateMaj, textBoxArchive.Text);*/
                Adherent unAdherent = new Adherent(value, textBoxNom.Text, textBoxPrenom.Text, parsedDateNaissance, numAdherent, textBoxEmail.Text, numParent, autoprelev,comboBox1.Text, thisDay, archive_adherent, 1);
                GestionAdherents.ModificationAdherent(unAdherent);
                MessageBox.Show("L'adhérent a bien été modifié");
                this.Close();
            }
            
                
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void ecranDeStatistiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuAS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
