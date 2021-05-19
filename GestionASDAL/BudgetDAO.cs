using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GestionASBO;
using GestionASDAL;
using System.Data;

namespace GestionASDAL
{
    public class BudgetDAO
    {
        private static BudgetDAO unBudgetDAO;
        // Accesseur en lecture, renvoi une instance
        public static BudgetDAO GetUnBudgetDAO()
        {
            if (unBudgetDAO == null)
            {
                unBudgetDAO = new BudgetDAO();
            }
            return unBudgetDAO;
        }

        // Cette méthode retourne une List contenant les objets Adherentscontenus dans la table Identification
        public static List<Budget> GetBudgets()
        {
            int id_budget;
            string libelle_budget;
            float montantinitial_budget;
            Budget unBudget;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Adherents
            List<Budget> lesBudgets = new List<Budget>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM gestionAS.dbo.budget";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id_budget = Int32.Parse(monReader["id_budget"].ToString());
                montantinitial_budget = float.Parse(monReader["montantinitial_budget"].ToString());

                // Nom Adherent
                if (monReader["libelle_budget"] == DBNull.Value)
                {
                    libelle_budget = default(string);
                }
                else
                {
                    libelle_budget = monReader["libelle_budget"].ToString();
                }

                unBudget = new Budget(id_budget, libelle_budget, montantinitial_budget);
                lesBudgets.Add(unBudget);


            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesBudgets;

        }
        // Cette méthode insert un nouvel utilisateur passé en paramètre dans la BD
        public static int AjoutBudget(Budget unBudget)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO  dbo.budget (libelle_budget, montantinitial_budget) values ('" + @unBudget.Libelle_budget + "','" + @unBudget.Montantinitial_budget + "')";
            nbEnr = cmd.ExecuteNonQuery();
            //Requêtes paramétrées
            cmd.Parameters.Add(new SqlParameter("@unBudget.Montantinitial_budget", SqlDbType.Int, 64));
            cmd.Parameters.Add(new SqlParameter("@unBudget.Libelle_budget", SqlDbType.VarChar, 25));

            //Attribution des valeurs
            cmd.Parameters["@unBudget.Libelle_budget"].Value = unBudget.Libelle_budget;
            cmd.Parameters["@unBudget.Montantinitial_budget"].Value = Convert.ToInt32(unBudget.Montantinitial_budget);
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        //Modification d'un budget
        public static int ModificationBudget(Budget unBudget)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "UPDATE dbo.budget SET libelle_budget = '" + @unBudget.Libelle_budget + "', montantinitial_budget = '" + @unBudget.Montantinitial_budget + "'WHERE id_budget = '" + @unBudget.Id_budget + "'";

            nbEnr = cmd.ExecuteNonQuery();
            //Requêtes paramétrées
            cmd.Parameters.Add(new SqlParameter("@unBudget.Id_budget", SqlDbType.Int, 10));
            cmd.Parameters.Add(new SqlParameter("@unBudget.Montantinitial_budget", SqlDbType.Int, 32));
            cmd.Parameters.Add(new SqlParameter("@unBudget.Libelle_budget", SqlDbType.VarChar, 25));

            //Attribution des valeurs
            cmd.Parameters["@unBudget.Libelle_budget"].Value = unBudget.Libelle_budget;
            cmd.Parameters["@unBudget.Montantinitial_budget"].Value = Convert.ToInt32(unBudget.Montantinitial_budget);
            cmd.Parameters["@unBudget.Id_budget"].Value = Convert.ToInt32(unBudget.Id_budget);
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode supprime de la BD un budget dont l'id est passé en paramètre
        public static int DeleteBudget(int id)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM GestionAS.dbo.budget WHERE id_budget = " + @id;
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 10));
            cmd.Parameters["@id"].Value = Convert.ToInt32(id);
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Ces 3 méthodes calculent le budget AS
        public static float TotalCreditAS()
        {
            float totalCredit;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select SUM(montant_flux) AS credit FROM GestionAS.dbo.flux WHERE id_typeflux = 2 AND id_budget = 2";
            SqlDataReader monReader = cmd.ExecuteReader();
            totalCredit = 0;
            if (monReader.Read())
            {
                // Nom Adherent
                if (monReader["credit"] == DBNull.Value)
                {
                    totalCredit = 0;
                }
                else
                {
                    totalCredit = float.Parse(monReader["credit"].ToString());
                }

            }
            // Fermeture de la connexion
            maConnexion.Close();
            return totalCredit;
        }
        public static float TotalDebitAS()
        {
            float totalDebit;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select SUM(montant_flux) AS debit FROM GestionAS.dbo.flux WHERE id_typeflux = 1 AND id_budget = 2";
            SqlDataReader monReader = cmd.ExecuteReader();

            totalDebit = 0;
            while (monReader.Read())
            {
                // Nom Adherent
                if (monReader["debit"] == DBNull.Value)
                {
                    totalDebit = 0;
                }
                else
                {
                    totalDebit = float.Parse(monReader["debit"].ToString());
                }
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return totalDebit;
        }
        public static float MontantTotalAS()
        {
            float montantInitialAS;
            float montantTotal;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select montantinitial_budget FROM GestionAS.dbo.budget WHERE id_budget = 2";
            SqlDataReader monReader = cmd.ExecuteReader();

            montantInitialAS = 0;
            while (monReader.Read())
            {
                // Nom Adherent
                if (monReader["montantinitial_budget"] == DBNull.Value)
                {
                    montantInitialAS = 0;
                }
                else
                {
                    montantInitialAS = float.Parse(monReader["montantinitial_budget"].ToString());
                }

            }
                
            // Fermeture de la connexion
            maConnexion.Close();

            montantTotal = montantInitialAS + (TotalCreditAS() - TotalDebitAS());

            return montantTotal;
        }
        // Ces 3 méthodes calculent le budget EPS
        public static float TotalCreditEPS()
        {
            float totalCredit;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select SUM(montant_flux) AS credit FROM GestionAS.dbo.flux WHERE id_typeflux = 2 AND id_budget = 4";
            SqlDataReader monReader = cmd.ExecuteReader();
            totalCredit = 1;
            if (monReader.Read())
            {
                // Nom Adherent
                if (monReader["credit"] == DBNull.Value)
                {
                    totalCredit = 0;
                }
                else
                {
                    totalCredit = float.Parse(monReader["credit"].ToString());
                }
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return totalCredit;
        }
        public static float TotalDebitEPS()
        {
            float totalDebit;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select SUM(montant_flux) AS debit FROM GestionAS.dbo.flux WHERE id_typeflux = 1 AND id_budget = 4";
            SqlDataReader monReader = cmd.ExecuteReader();

            totalDebit = 2;
            if (monReader.Read())
            {
                // Nom Adherent
                if (monReader["debit"] == DBNull.Value)
                {
                    totalDebit = 0;
                }
                else
                {
                    totalDebit = float.Parse(monReader["debit"].ToString());
                }

                // Fermeture de la connexion
                maConnexion.Close();

            }

            return totalDebit;
        }
        public static float MontantTotalEPS()
        {
            float montantInitialEPS;
            float montantTotal;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select montantinitial_budget FROM GestionAS.dbo.budget WHERE id_budget = 4";
            SqlDataReader monReader = cmd.ExecuteReader();

            montantInitialEPS = 0;
            if (monReader.Read())
            {
                // Nom Adherent
                if (monReader["montantinitial_budget"] == DBNull.Value)
                {
                    montantInitialEPS = 0;
                }
                else
                {
                    montantInitialEPS = float.Parse(monReader["montantinitial_budget"].ToString());
                }

                // Fermeture de la connexion
                maConnexion.Close();

            }

            montantTotal = montantInitialEPS + (TotalCreditEPS() - TotalDebitEPS());

            return montantTotal;
        }

    }
}
