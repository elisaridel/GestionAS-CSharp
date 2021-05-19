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
    public partial class AffichageFlux : Form
    {
        public AffichageFlux()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionFlux.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionASForm"]);

            // Blocage de la génération automatique des colonnes
            dataGridView1.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "Id_flux";
            IdColumn.HeaderText = "Identifiant";

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn LibelleColumn = new DataGridViewTextBoxColumn();
            LibelleColumn.DataPropertyName = "Libelle_flux";
            LibelleColumn.HeaderText = "Libelle du flux";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn DateColumn = new DataGridViewTextBoxColumn();
            DateColumn.DataPropertyName = "Date_flux";
            DateColumn.HeaderText = "Date";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn MontantColumn = new DataGridViewTextBoxColumn();
            MontantColumn.DataPropertyName = "Montant_flux";
            MontantColumn.HeaderText = "Montant du flux";

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn IdAdherentColumn = new DataGridViewTextBoxColumn();
            IdAdherentColumn.DataPropertyName = "Adherent";
            IdAdherentColumn.HeaderText = "Nom adherent";

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn IdTypeFluxColumn = new DataGridViewTextBoxColumn();
            IdTypeFluxColumn.DataPropertyName = "TypeFlux";
            IdTypeFluxColumn.HeaderText = "Type de flux";

            // Création d'une en-tête de colonne pour la colonne 7
            DataGridViewTextBoxColumn IdBudgetColumn = new DataGridViewTextBoxColumn();
            IdBudgetColumn.DataPropertyName = "Budget";
            IdBudgetColumn.HeaderText = "Budget";

            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewTextBoxColumn EtatPrelevement = new DataGridViewTextBoxColumn();
            EtatPrelevement.DataPropertyName = "Etat_prelevement";
            EtatPrelevement.HeaderText = "Etat du prélevement";

            // Création d'une en-tête de colonne pour la colonne 9
            DataGridViewTextBoxColumn Id_Adherent = new DataGridViewTextBoxColumn();
            Id_Adherent.DataPropertyName = "Id_adherent";
            Id_Adherent.HeaderText = "Id de l'adherent";

            // Création d'une en-tête de colonne pour la colonne 10
            DataGridViewTextBoxColumn Id_budget = new DataGridViewTextBoxColumn();
            Id_budget.DataPropertyName = "Id_budget";
            Id_budget.HeaderText = "Id du budget";

            // Création d'une en-tête de colonne pour la colonne 11
            DataGridViewTextBoxColumn Id_typeFlux = new DataGridViewTextBoxColumn();
            Id_typeFlux.DataPropertyName = "Id_typeflux";
            Id_typeFlux.HeaderText = "Id du type de flux";

            // Ajout des 2 en-têtes de colonne au datagridview
            dataGridView1.Columns.Add(IdColumn);
            dataGridView1.Columns.Add(LibelleColumn);
            dataGridView1.Columns.Add(DateColumn);
            dataGridView1.Columns.Add(MontantColumn);
            dataGridView1.Columns.Add(IdAdherentColumn);
            dataGridView1.Columns.Add(IdTypeFluxColumn);
            dataGridView1.Columns.Add(IdBudgetColumn);
            dataGridView1.Columns.Add(EtatPrelevement);
            dataGridView1.Columns.Add(Id_Adherent);
            dataGridView1.Columns.Add(Id_budget);
            dataGridView1.Columns.Add(Id_typeFlux);

            // Définition du style apporté au datagridview
            dataGridView1.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            List<Flux> liste = new List<Flux>();
            liste = GestionASDAL.FluxDAO.GetAfficheFlux();

            // Rattachement de la List à la source de données du datagridview
            dataGridView1.DataSource = liste;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Récupération id_flux
                int id_flux = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[id_flux];
                string a = Convert.ToString(selectedRow.Cells[0].Value);
                int valueFlux;
                int.TryParse(a, out valueFlux);

                //Récupération libelle
                int libelleFlux = dataGridView1.SelectedCells[1].RowIndex;
                DataGridViewRow nomSelectedRow = dataGridView1.Rows[libelleFlux];
                string libelle = Convert.ToString(nomSelectedRow.Cells[1].Value);

                //Récupération date
                int dateFlux = dataGridView1.SelectedCells[2].RowIndex;
                DataGridViewRow prenomSelectedRow = dataGridView1.Rows[dateFlux];
                string date = Convert.ToString(nomSelectedRow.Cells[2].Value);
                //Récupération montant
                int montantFlux = dataGridView1.SelectedCells[3].RowIndex;
                DataGridViewRow montantSelectedRow = dataGridView1.Rows[montantFlux];
                string montant = Convert.ToString(montantSelectedRow.Cells[3].Value);
                //Récupération adherent
                int idAdherent = dataGridView1.SelectedCells[8].RowIndex;
                DataGridViewRow adherentSelectedRow = dataGridView1.Rows[idAdherent];
                string adherent = Convert.ToString(adherentSelectedRow.Cells[8].Value);
                //Récupération type
                int typeflux = dataGridView1.SelectedCells[10].RowIndex;
                DataGridViewRow typeSelectedRow = dataGridView1.Rows[typeflux];
                string type = Convert.ToString(typeSelectedRow.Cells[10].Value);
                //Récupération budget
                int budgetFlux = dataGridView1.SelectedCells[9].RowIndex;
                DataGridViewRow budgetSelectedRow = dataGridView1.Rows[budgetFlux];
                string budget = Convert.ToString(budgetSelectedRow.Cells[9].Value);
                //Récupération etat prélevement
                int etatPrelev = dataGridView1.SelectedCells[7].RowIndex;
                DataGridViewRow etatSelectedRow = dataGridView1.Rows[etatPrelev];
                string etatPrelevement = Convert.ToString(etatSelectedRow.Cells[7].Value);


                if (id_flux >= 0)
                {
                    ModificationFlux modificationFlux;
                    modificationFlux = new ModificationFlux(valueFlux, libelle, montant,adherent,type,budget, etatPrelevement);
                    modificationFlux.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne");
            }
        }

        private void AffichageFlux_Load(object sender, EventArgs e)
        {

        }

        private void deleteFlux_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Voulez vous vraiment supprimer ce flux ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int selectedDrowIndex = dataGridView1.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedDrowIndex];
                        string a = Convert.ToString(selectedRow.Cells[0].Value);
                        int value;
                        int.TryParse(a, out value);
                        GestionFlux.SupprimerFlux(value);
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
                MessageBox.Show("Il n'y a pas de flux.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Actualisation

            List<Flux> liste = new List<Flux>();
            liste = GestionASDAL.FluxDAO.GetAfficheFlux();
            dataGridView1.DataSource = liste;
        }

        private void gestionBudgetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBudgetForm budget;
            budget = new GestionBudgetForm();
            budget.Show();
            this.Close();
        }

        private void gestionÉlèvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionEleveForm eleve;
            eleve = new GestionEleveForm();
            eleve.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AjoutFlux ajoutflux;
            ajoutflux = new AjoutFlux();
            ajoutflux.Show();
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
