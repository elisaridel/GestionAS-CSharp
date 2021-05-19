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
using GestionASBO;
using GestionAS;

namespace GestionASForm
{
    public partial class PageAccueilForm : Form
    {
        private string a;
        private string b;
        public PageAccueilForm(string a, string b)
        {
            this.a = a;
            this.b = b;
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionASForm"]);
        }

        private void dndjdjjToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PageAccueilForm_Load(object sender, EventArgs e)
        {
            Utilisateur uti = new Utilisateur(a, b);
            if (GestionUtilisateurs.TransformationDroitUtilisateur(uti) == false)
            {
                gestionÉlèvesToolStripMenuItem.Visible = false;
                ecranDeStatistiqueToolStripMenuItem.Visible = false;
            }
            
        }

        private void menuAS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comptabilitéToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bienvenueLabel_Click(object sender, EventArgs e)
        {

        }

        private void gestionÉlèvesToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            GestionEleveForm gestionEleve;
            gestionEleve = new GestionEleveForm();
            gestionEleve.Show();
            this.Close();
        }

        private void gestionBudgetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBudgetForm gestionBudget;
            gestionBudget = new GestionBudgetForm();
            gestionBudget.Show();
            this.Close();
        }

        private void ecranDeStatistiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistiques stat;
            stat = new Statistiques();
            stat.Show();
            this.Close();
        }
    }
}
