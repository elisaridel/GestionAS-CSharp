using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionASBO;
using System.Configuration;
using GestionASDAL;
using System.Data;
namespace GestionAS
{
    public class GestionBudget
    {
        private static GestionBudget uneGestionBudget; // objet BLL

        // Accesseur en lecture
        public static GestionBudget GetGestionAdherent()
        {
            if (uneGestionBudget == null)
            {
                uneGestionBudget = new GestionBudget();
            }
            return uneGestionBudget;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexionde la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Budget> GetBudgets()
        {
            return BudgetDAO.GetBudgets();
        }
        public static int AjoutBudget(Budget unBudget)
        {
            return BudgetDAO.AjoutBudget(unBudget);
        }
        public static int ModificationBudget(Budget unBudget)
        {
            return BudgetDAO.ModificationBudget(unBudget);
        }
        // Méthode qui supprime un Budget avec la méthode DeleteAdherent de la DAL
        public static int SupprimerBudget(int id)
        {
            return BudgetDAO.DeleteBudget(id);
        }
        // Méthode qui calcule budget AS
        public static float MontantTotalAS()
        {
            return BudgetDAO.MontantTotalAS();
        }
        public static float MontantTotalEPS()
        {
            return BudgetDAO.MontantTotalEPS();
        }
    }
}
