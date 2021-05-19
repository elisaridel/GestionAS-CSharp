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
    public partial class GestionEleveForm : Form
    {
        public GestionEleveForm()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionASForm"]);

            // Blocage de la génération automatique des colonnes
            dataGridView1.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "Id_adherent";
            IdColumn.HeaderText = "Identifiant";

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();
            NomColumn.DataPropertyName = "Nom_adherent";
            NomColumn.HeaderText = "Nom de l'élève";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn PrenomColumn = new DataGridViewTextBoxColumn();
            PrenomColumn.DataPropertyName = "Prenom_adherent";
            PrenomColumn.HeaderText = "Prénom";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn DateNaissanceColumn = new DataGridViewTextBoxColumn();
            DateNaissanceColumn.DataPropertyName = "Ddn_adherent";
            DateNaissanceColumn.HeaderText = "Date de naissance";

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn NumTelColumn = new DataGridViewTextBoxColumn();
            NumTelColumn.DataPropertyName = "Numtel_adherent";
            NumTelColumn.HeaderText = "Numéro de téléphone";

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn EmailColumn = new DataGridViewTextBoxColumn();
            EmailColumn.DataPropertyName = "Email_adherent";
            EmailColumn.HeaderText = "Email";

            // Création d'une en-tête de colonne pour la colonne 7
            DataGridViewTextBoxColumn NumParentColumn = new DataGridViewTextBoxColumn();
            NumParentColumn.DataPropertyName = "Numparent_adherent";
            NumParentColumn.HeaderText = "Numéro des parents";

            // Création d'une en-tête de colonne pour la colonne 9
            DataGridViewTextBoxColumn SexeColumn = new DataGridViewTextBoxColumn();
            SexeColumn.DataPropertyName = "Sexe_adherent";
            SexeColumn.HeaderText = "Sexe";

            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewTextBoxColumn AutoPrelevColumn = new DataGridViewTextBoxColumn();
            AutoPrelevColumn.DataPropertyName = "Autoprelev_adherent";
            AutoPrelevColumn.HeaderText = "Auto prélèvement";


            // Création d'une en-tête de colonne pour la colonne 10
            DataGridViewTextBoxColumn DateMajColumn = new DataGridViewTextBoxColumn();
            DateMajColumn.DataPropertyName = "Datemaj_adherent";
            DateMajColumn.HeaderText = "Date mise à jour";

            // Création d'une en-tête de colonne pour la colonne 11
            DataGridViewTextBoxColumn ArchiveColumn = new DataGridViewTextBoxColumn();
            ArchiveColumn.DataPropertyName = "Archive_adherent";
            ArchiveColumn.HeaderText = "Archive";

            // Création d'une en-tête de colonne pour la colonne 11
            DataGridViewTextBoxColumn ClasseColumn = new DataGridViewTextBoxColumn();
            ClasseColumn.DataPropertyName = "Classe";
            ClasseColumn.HeaderText = "Classe";

            // Ajout des 2 en-têtes de colonne au datagridview
            dataGridView1.Columns.Add(IdColumn);
            dataGridView1.Columns.Add(NomColumn);
            dataGridView1.Columns.Add(PrenomColumn);
            dataGridView1.Columns.Add(DateNaissanceColumn);
            dataGridView1.Columns.Add(NumTelColumn);
            dataGridView1.Columns.Add(EmailColumn);
            dataGridView1.Columns.Add(NumParentColumn);
            dataGridView1.Columns.Add(AutoPrelevColumn);
            dataGridView1.Columns.Add(SexeColumn);
            dataGridView1.Columns.Add(DateMajColumn);
            dataGridView1.Columns.Add(ArchiveColumn);
            dataGridView1.Columns.Add(ClasseColumn);

            // Définition du style apporté au datagridview
            dataGridView1.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            

            // Création d'un objet List d'adherents à afficher dans le datagridview
            List<Adherent> liste = new List<Adherent>();
            liste = GestionASDAL.AdherentDAO.GetDetailAdherents();
            
            
            // Rattachement de la List à la source de données du datagridview
            dataGridView1.DataSource = liste;
        }

        private void modifEleve_Click(object sender, EventArgs e)
        {
            
            dataGridView1.MultiSelect = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Récupération id_adhérent
                int id_adherent = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[id_adherent];
                string a = Convert.ToString(selectedRow.Cells[0].Value);
                int valueAdherent;
                int.TryParse(a, out valueAdherent);

                //Récupération nom adhérent
                int nomAdherent = dataGridView1.SelectedCells[1].RowIndex;
                DataGridViewRow nomSelectedRow = dataGridView1.Rows[nomAdherent];
                string nom = Convert.ToString(nomSelectedRow.Cells[1].Value);

                //Récupération prenom adhérent
                int prenomAdherent = dataGridView1.SelectedCells[2].RowIndex;
                DataGridViewRow prenomSelectedRow = dataGridView1.Rows[prenomAdherent];
                string prenom = Convert.ToString(nomSelectedRow.Cells[2].Value);
                //Récupération ddn
                int ddn_adherent = dataGridView1.SelectedCells[3].RowIndex;
                DataGridViewRow ddnSelectedRow = dataGridView1.Rows[ddn_adherent];
                string ddn = Convert.ToString(selectedRow.Cells[3].Value);
                
                //Récupération num tel
                int num_adherent = dataGridView1.SelectedCells[4].RowIndex;
                DataGridViewRow numSelectedRow = dataGridView1.Rows[num_adherent];
                string numAdherent = Convert.ToString(selectedRow.Cells[4].Value);
                
                //Récupération mail adhérent
                int mailAdherent = dataGridView1.SelectedCells[5].RowIndex;
                DataGridViewRow mailSelectedRow = dataGridView1.Rows[mailAdherent];
                string mail = Convert.ToString(nomSelectedRow.Cells[5].Value);
                //Récupération num parents tel
                int numparent_adherent = dataGridView1.SelectedCells[6].RowIndex;
                DataGridViewRow numparentSelectedRow = dataGridView1.Rows[numparent_adherent];
                string numparentAdherent = Convert.ToString(numparentSelectedRow.Cells[6].Value);
                
                //Récupération autoprelev
                int autoprelev_adherent = dataGridView1.SelectedCells[7].RowIndex;
                DataGridViewRow autoprelevSelectedRow = dataGridView1.Rows[autoprelev_adherent];
                string autoprelev = Convert.ToString(autoprelevSelectedRow.Cells[7].Value);
                
                //Récupération sexe adhérent
                int sexeAdherent = dataGridView1.SelectedCells[8].RowIndex;
                DataGridViewRow sexeSelectedRow = dataGridView1.Rows[sexeAdherent];
                string sexe = Convert.ToString(sexeSelectedRow.Cells[8].Value);
                //Récupération ddn
                int datemaj_adherent = dataGridView1.SelectedCells[9].RowIndex;
                DataGridViewRow datemajSelectedRow = dataGridView1.Rows[datemaj_adherent];
                string datemaj = Convert.ToString(datemajSelectedRow.Cells[9].Value);
                
                //Récupération archive adhérent
                int archiveAdherent = dataGridView1.SelectedCells[10].RowIndex;
                DataGridViewRow archiveSelectedRow = dataGridView1.Rows[archiveAdherent];
                string archive = Convert.ToString(archiveSelectedRow.Cells[10].Value);
                
                if (valueAdherent > 0)
                {
                    ModificationEleve modificationEleve;
                    modificationEleve = new ModificationEleve(valueAdherent, prenom, nom, ddn, numAdherent, mail, numparentAdherent, autoprelev, sexe, datemaj, archive);
                    modificationEleve.Show();
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne");
            }
            
            
        }

        private void supp_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Voulez vous vraiment supprimer cet élève ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int selectedDrowIndex = dataGridView1.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedDrowIndex];
                        string a = Convert.ToString(selectedRow.Cells[0].Value);
                        int value;
                        int.TryParse(a, out value);
                        GestionAdherents.SupprimerAdherent(value);
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
                MessageBox.Show("Il n'y a pas d'élèves.");
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            AjoutAdherent ajoutEleve;
            ajoutEleve = new AjoutAdherent();
            ajoutEleve.Show();
        }

        private void GestionEleveForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Création d'un objet List d'Utilisateur à afficher dans le datagridview

            List<Adherent> liste = new List<Adherent>();
            liste = GestionAdherents.GetDetailAdherents();
            // Rattachement de la List à la source de données du datagridview

            dataGridView1.DataSource = liste;
        }

        private void gestionBudgetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBudgetForm budget;
            budget = new GestionBudgetForm();
            budget.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Création d'un objet List d'adherents à afficher dans le datagridview
            string nom = textBoxRechercher.Text;
            List<Adherent> liste = new List<Adherent>();
            liste = GestionAdherents.FiltreUtilisateur(nom);


            // Rattachement de la List à la source de données du datagridview
            dataGridView1.DataSource = liste;
        }

        private void detailEleve_Click(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Récupération id_adhérent
                int id_adherent = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[id_adherent];
                string a = Convert.ToString(selectedRow.Cells[0].Value);
                int valueAdherent;
                int.TryParse(a, out valueAdherent);

                //Récupération nom adhérent
                int nomAdherent = dataGridView1.SelectedCells[1].RowIndex;
                DataGridViewRow nomSelectedRow = dataGridView1.Rows[nomAdherent];
                string nom = Convert.ToString(nomSelectedRow.Cells[1].Value);

                //Récupération prenom adhérent
                int prenomAdherent = dataGridView1.SelectedCells[2].RowIndex;
                DataGridViewRow prenomSelectedRow = dataGridView1.Rows[prenomAdherent];
                string prenom = Convert.ToString(nomSelectedRow.Cells[2].Value);

                //Récupération autoprelev
                int autoprelev_adherent = dataGridView1.SelectedCells[7].RowIndex;
                DataGridViewRow autoprelevSelectedRow = dataGridView1.Rows[autoprelev_adherent];
                string autoprelev = Convert.ToString(autoprelevSelectedRow.Cells[7].Value);

                //Récupération autoprelev
                int classe = dataGridView1.SelectedCells[11].RowIndex;
                DataGridViewRow classeSelectedRow = dataGridView1.Rows[classe];
                string libelle_classe = Convert.ToString(classeSelectedRow.Cells[11].Value);

                if (valueAdherent > 0)
                {
                    DetailEleve detail;
                    detail = new DetailEleve(valueAdherent, prenom, nom, autoprelev, libelle_classe);
                    detail.Show();
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une ligne");
            }
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
