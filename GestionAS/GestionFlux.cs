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
    public class GestionFlux
    {
        private static GestionFlux uneGestionFlux; // objet BLL

        // Accesseur en lecture
        public static GestionFlux GetGestionFlux()
        {
            if (uneGestionFlux == null)
            {
                uneGestionFlux = new GestionFlux();
            }
            return uneGestionFlux;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexionde la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Flux> GetFlux()
        {
            return FluxDAO.GetFlux();
        }
        public static List<Flux> GetAfficheFlux()
        {
            return FluxDAO.GetAfficheFlux();
        }
        public static int ModificationFlux(Flux unFlux)
        {
            return FluxDAO.ModificationFlux(unFlux);
        }
        // Méthode qui supprime un flux avec la méthode DeleteFlux de la DAL
        public static int SupprimerFlux(int id)
        {
            return FluxDAO.DeleteFlux(id);
        }
        public static int AjoutFlux(Flux unFlux)
        {
            return FluxDAO.AjoutFlux(unFlux);
        }
    }
}
