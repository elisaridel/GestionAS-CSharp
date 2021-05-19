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
using GestionAS; // Référence la couche BLL
using GestionASBO; // Référence la couche BO

namespace GestionASForm
{
    public partial class Statistiques : Form
    {
        public Statistiques()
        {
            InitializeComponent();

            //Remplissage graphique qui représente le nombre de licenciés par genre
            chart1.DataSource = GestionAdherents.StatsGenre();
            chart1.Series["Genre"].XValueMember = "sexe_adherent";
            chart1.Series["Genre"].YValueMembers = "nb";

            //Remplissage graphique qui représente le nombre de licenciés par date de naissance
            ddnChart.DataSource = GestionAdherents.StatsDdn();
            ddnChart.Series["Nombre d'adhérent par date de naissance"].XValueMember = "year";
            ddnChart.Series["Nombre d'adhérent par date de naissance"].YValueMembers = "nbParDdn";

            //Remplissage graphique qui représente le nombre de compétition par licencié
            chartEvenement.DataSource = GestionAdherents.StatsEvenementEleve();
            chartEvenement.Series["Eleve"].XValueMember = "nom_adherent";
            chartEvenement.Series["Eleve"].YValueMembers = "nbEvenement";

        }

        private void Statistiques_Load(object sender, EventArgs e)
        {
            int nbAdherent = GestionASDAL.AdherentDAO.NbAdherent();
            string adherent = Convert.ToString(nbAdherent);
            nombreAdherent.Text = adherent;

            int nbParticipation = GestionASDAL.AdherentDAO.NbAdherentEvenement();
            string participation = Convert.ToString(nbParticipation);
            nombreParticipation.Text = participation;
        }

    }
}
