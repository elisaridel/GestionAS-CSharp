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
using System.Configuration;
using GestionASBO; // Référence la couche BO

namespace GestionASForm
{
    public partial class DetailEleve : Form
    {
        private int value_adherent;
        private string name;
        private string surname;
        private string autoprelevement;
        private string libelle_classe;

        public DetailEleve(int value_adherent, string prenom, string nom, string autoprelev, string classe)
        {
            this.value_adherent = value_adherent;
            this.name = prenom;
            this.surname = nom;
            this.autoprelevement = autoprelev;
            this.libelle_classe = classe;

            InitializeComponent();
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionASForm"]);

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

            // Ajout des 2 en-têtes de colonne au datagridview
            dataGridView1.Columns.Add(IdColumn);
            dataGridView1.Columns.Add(LibelleColumn);
            dataGridView1.Columns.Add(DateColumn);
            dataGridView1.Columns.Add(MontantColumn);
            dataGridView1.Columns.Add(IdTypeFluxColumn);
            dataGridView1.Columns.Add(IdBudgetColumn);
            dataGridView1.Columns.Add(EtatPrelevement);

            // Définition du style apporté au datagridview
            dataGridView1.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            List<Flux> liste = new List<Flux>();
            liste = GestionASDAL.AdherentDAO.GetAfficheFlux(value_adherent);

            // Rattachement de la List à la source de données du datagridview
            dataGridView1.DataSource = liste;
        }

        private void DetailEleve_Load(object sender, EventArgs e)
        {
            nom.Text = surname;
            prenom.Text = name;
            classe.Text = libelle_classe;
            prelev.Text = autoprelevement;

            
        }
    }
}
