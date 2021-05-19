using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using GestionASBO;
using GestionAS;

namespace GestionASForm
{
    public partial class PageAccueil : Form
    { 
        public PageAccueil()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionASForm"]);
        }

        private void PageAccueil_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Vérification si le formulaire est plein
            if (String.IsNullOrEmpty(textBoxIdentifiant.Text) == true && String.IsNullOrEmpty(textBoxMotDePasse.Text) == false)
            {
                MessageBox.Show("Veuillez rentrer un login");
            }
            if (String.IsNullOrEmpty(textBoxMotDePasse.Text) == true && String.IsNullOrEmpty(textBoxIdentifiant.Text) == false)
            {
                MessageBox.Show("Veuillez rentrer un mot de passe");
            }
            if (String.IsNullOrEmpty(textBoxMotDePasse.Text) == true && String.IsNullOrEmpty(textBoxIdentifiant.Text) == true)
            {
                MessageBox.Show("Veuillez remplir les champs");
            }
            // Création de l'objet Utilisateur avec le nom récupéré dans la GUI
            Utilisateur uti = new Utilisateur(textBoxIdentifiant.Text, textBoxMotDePasse.Text);
            if(GestionUtilisateurs.ConnexionUtilisateur(uti) == true)
            {
                
                PageAccueilForm pageAccueil;
                pageAccueil = new PageAccueilForm(textBoxIdentifiant.Text, textBoxMotDePasse.Text);
                pageAccueil.Show();
                PageAccueil pageConnexion;
                pageConnexion = new PageAccueil();
                pageConnexion.Close();

            }
            else if (GestionUtilisateurs.ConnexionUtilisateur(uti) == false && String.IsNullOrEmpty(textBoxIdentifiant.Text) == false && String.IsNullOrEmpty(textBoxMotDePasse.Text) == false)
            {
                MessageBox.Show("Vos identifiants ne sont pas bons.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void textBoxIdentifiant_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBoxMotDePasse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
