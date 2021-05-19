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
    public class GestionAdherents
    {
        private static GestionAdherents uneGestionAdherent; // objet BLL

        // Accesseur en lecture
        public static GestionAdherents GetGestionAdherent()
        {
            if (uneGestionAdherent == null)
            {
                uneGestionAdherent = new GestionAdherents();
            }
            return uneGestionAdherent;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexionde la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Adherent> GetAdherents()
        {
            return AdherentDAO.GetAdherents();
        }
        public static int ModificationAdherent(Adherent unAdherent)
        {
            return AdherentDAO.ModificationAdherent(unAdherent);
        }
        // Méthode qui supprime un Adherent avec la méthode DeleteAdherent de la DAL
        public static int SupprimerAdherent(int id)
        {
            return AdherentDAO.DeleteAdherent(id);
        }
        public static int AjoutUtilisateur(Adherent unAdherent)
        {
            return AdherentDAO.AjoutUtilisateur(unAdherent);
        }
        public static List<Adherent> FiltreUtilisateur(string recherche)
        {
            return AdherentDAO.FiltreUtilisateur(recherche);
        }
        public static DataSet StatsGenre()
        {
            return AdherentDAO.StatsGenre();
        }
        public static DataSet StatsDdn()
        {
            return AdherentDAO.StatsDdn();
        }
        public static DataSet StatsEvenementEleve()
        {
            return AdherentDAO.StatsEvenementEleve();
        }
        public static int NbAdherent()
        {
            return AdherentDAO.NbAdherent();
        }
        public static int NbAdherentEvenement()
        {
            return AdherentDAO.NbAdherentEvenement();
        }
        public static List<Adherent> GetDetailAdherents()
        {
            return AdherentDAO.GetDetailAdherents();
        }
        public static List<Flux> GetAfficheFlux(int id_adherent)
        {
            return AdherentDAO.GetAfficheFlux(id_adherent);
        }
    }
}
