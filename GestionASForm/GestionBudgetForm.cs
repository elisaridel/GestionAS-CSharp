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
    public partial class GestionBudgetForm : Form
    {
        public GestionBudgetForm()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionBudget.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionASForm"]);

            // Blocage de la génération automatique des colonnes
            dataGridView1.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "Id_budget";
            IdColumn.HeaderText = "Identifiant";

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();
            NomColumn.DataPropertyName = "Libelle_budget";
            NomColumn.HeaderText = "Libelle du budget";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn PrenomColumn = new DataGridViewTextBoxColumn();
            PrenomColumn.DataPropertyName = "Montantinitial_budget";
            PrenomColumn.HeaderText = "Montant initial";

            // Ajout des 2 en-têtes de colonne au datagridview
            dataGridView1.Columns.Add(IdColumn);
            dataGridView1.Columns.Add(NomColumn);
            dataGridView1.Columns.Add(PrenomColumn);

            // Définition du style apporté au datagridview
            dataGridView1.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Création d'un objet List d'adherents à afficher dans le datagridview
            List<Budget> liste = new List<Budget>();
            liste = GestionASDAL.BudgetDAO.GetBudgets();


            // Rattachement de la List à la source de données du datagridview
            dataGridView1.DataSource = liste;
        }

        private void addBudget_Click(object sender, EventArgs e)
        {
            AjoutBudget ajout;
            ajout = new AjoutBudget();
            ajout.Show();
            this.Close();
        }

        private void affichageFlux_Click(object sender, EventArgs e)
        {

            AffichageFlux affichage;
            affichage = new AffichageFlux();
            affichage.Show();
            this.Close();
        }

        private void GestionBudgetForm_Load(object sender, EventArgs e)
        {
            float montantTotalAS = GestionASDAL.BudgetDAO.MontantTotalAS();
            string montantAS = Convert.ToString(montantTotalAS);
            label3.Text = montantAS;
            float montantTotalEPS = GestionASDAL.BudgetDAO.MontantTotalEPS();
            string montantEPS = Convert.ToString(montantTotalEPS);
            label4.Text = montantEPS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Récupération id_adhérent
                int id_budget = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[id_budget];
                string a = Convert.ToString(selectedRow.Cells[0].Value);
                int valueBudget;
                int.TryParse(a, out valueBudget);

                //Récupération nom adhérent
                int libelleBudget = dataGridView1.SelectedCells[1].RowIndex;
                DataGridViewRow nomSelectedRow = dataGridView1.Rows[libelleBudget];
                string libelle = Convert.ToString(nomSelectedRow.Cells[1].Value);

                //Récupération prenom adhérent
                int montantBudget = dataGridView1.SelectedCells[2].RowIndex;
                DataGridViewRow prenomSelectedRow = dataGridView1.Rows[montantBudget];
                string montant = Convert.ToString(nomSelectedRow.Cells[2].Value);


                if (valueBudget > 0)
                {
                    ModificationBudget modificationBudget;
                    modificationBudget = new ModificationBudget(valueBudget, libelle, montant);
                    modificationBudget.Show();
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Voulez vous vraiment supprimer ce budget ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int selectedDrowIndex = dataGridView1.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedDrowIndex];
                        string a = Convert.ToString(selectedRow.Cells[0].Value);
                        int value;
                        int.TryParse(a, out value);
                        GestionBudget.SupprimerBudget(value);
                        MessageBox.Show("Suppression réussie.");
                    }


                }
                else
                {
                    MessageBox.Show("Suppression avortée.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Il n'y a pas de budget.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Actualisation

            List<Budget> liste = new List<Budget>();
            liste = GestionBudget.GetBudgets();
            // Rattachement de la List à la source de données du datagridview

            dataGridView1.DataSource = liste;
            float montantTotalAS = GestionASDAL.BudgetDAO.MontantTotalAS();
            string montantAS = Convert.ToString(montantTotalAS);
            label3.Text = montantAS;
            float montantTotalEPS = GestionASDAL.BudgetDAO.MontantTotalEPS();
            string montantEPS = Convert.ToString(montantTotalEPS);
            label4.Text = montantEPS;
        }

        private void gestionÉlèvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionEleveForm gestionEleve;
            gestionEleve = new GestionEleveForm();
            gestionEleve.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ecranDeStatistiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistiques stats;
            stats = new Statistiques();
            stats.Show();
            this.Close();
        }
    }
}
