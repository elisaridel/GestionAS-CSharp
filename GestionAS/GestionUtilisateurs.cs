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
    public class GestionUtilisateurs
    {
        private static GestionUtilisateurs uneGestionUtilisateurs; // objet BLL
        // Accesseur en lecture
        public static GestionUtilisateurs GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new GestionUtilisateurs();
            }
            return uneGestionUtilisateurs;
        }
        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Utilisateur> GetUtilisateurs()
        {
            return UtilisateurDAO.GetUtilisateurs();
        }
        // Méthode qui renvoi l’objet Utilisateur en l'ajoutant à la
        // BD avec la méthode AjoutUtilisateur de la DAL
        public static Boolean ConnexionUtilisateur(Utilisateur uti)
        {

            return UtilisateurDAO.ConnexionUtilisateur(uti);
        }

        //Méthode qui récuère le droit utilisateur
        public static Boolean DroitUtilisateur(Utilisateur unUtilisateur)
        {

            return UtilisateurDAO.DroitUtilisateur(unUtilisateur);
        }
        //Méthode qui insère droit utilisateur dans variable code
        public static Boolean TransformationDroitUtilisateur(Utilisateur unUtilisateur)
        {

            return UtilisateurDAO.TransformationDroitUtilisateur(unUtilisateur);
        }



    }
}
