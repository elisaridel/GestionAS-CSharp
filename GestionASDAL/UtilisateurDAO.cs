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
    public class UtilisateurDAO
    {
        private static UtilisateurDAO unUtilisateurDAO;
        // Accesseur en lecture, renvoi une instance
        public static UtilisateurDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDAO();
            }
            return unUtilisateurDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurscontenus dans la table Identification
        public static List<Utilisateur> GetUtilisateurs()
        {
            int idUtilisateur;
            string loginUtilisateur;
            string mdpUtilisateur;
            int droitUtilisateur;
            Utilisateur unUtilisateur;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Utilisateurs
            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM GestionAS.dbo.utilisateur";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                idUtilisateur = Int32.Parse(monReader["Id_Utilisateur"].ToString());
                droitUtilisateur = Int32.Parse(monReader["droit_utilisateur"].ToString());
                if (monReader["Nom_utilisateur"] == DBNull.Value)
                {
                    loginUtilisateur = default(string);
                }
                else
                {
                    loginUtilisateur = monReader["Nom_utilisateur"].ToString();
                }
                if (monReader["Mdp_Utilisateur"] == DBNull.Value)
                {
                    mdpUtilisateur = default(string);
                }
                else
                {
                    mdpUtilisateur = monReader["Mdp_utilisateur"].ToString();
                }
                unUtilisateur = new Utilisateur(idUtilisateur, loginUtilisateur, mdpUtilisateur, droitUtilisateur);
                lesUtilisateurs.Add(unUtilisateur);

                

            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesUtilisateurs;

        }
        //Gestion formulaire de connexion
        public static Boolean ConnexionUtilisateur(Utilisateur unUtilisateur)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand com = new SqlCommand();
            com.Connection = maConnexion;
            com.CommandText = ("select login_utilisateur,mdp_utilisateur from GestionAS.dbo.utilisateur where login_utilisateur='" + @unUtilisateur.LoginUtilisateur + "'and mdp_utilisateur='" + @unUtilisateur.MdpUtilisateur + "'");
            SqlDataReader monReader = com.ExecuteReader();
            //Requêtes paramétrées
            com.Parameters.Add(new SqlParameter("@unUtilisateur.LoginUtilisateur", SqlDbType.VarChar, 25));
            com.Parameters.Add(new SqlParameter("@unUtilisateur.MdpUtilisateur", SqlDbType.VarChar, 25));

            //Attribution des valeurs
            com.Parameters["@unUtilisateur.LoginUtilisateur"].Value = unUtilisateur.LoginUtilisateur;
            com.Parameters["@unUtilisateur.MdpUtilisateur"].Value = unUtilisateur.MdpUtilisateur;

            //Vérification
            if (monReader.Read())
            {
                maConnexion.Close();
                return true;
            }
            else
            {
                maConnexion.Close();
                return false;
            }
        }

        //Récupération du droit utilisateur
        public static Boolean DroitUtilisateur(Utilisateur unUtilisateur)
        {

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand com = new SqlCommand();
            com.Connection = maConnexion;
            //Connexion à la base de données
            com.CommandText = ("select droit_utilisateur from GestionAS.dbo.utilisateur where login_utilisateur='" + @unUtilisateur.LoginUtilisateur + "'and mdp_utilisateur='" + @unUtilisateur.MdpUtilisateur + "'");
            SqlDataReader monReader = com.ExecuteReader();
            //Requêtes paramétrées
            com.Parameters.Add(new SqlParameter("@unUtilisateur.LoginUtilisateur", SqlDbType.VarChar, 25));
            com.Parameters.Add(new SqlParameter("@unUtilisateur.MdpUtilisateur", SqlDbType.VarChar, 25));

            //Attribution des valeurs
            com.Parameters["@unUtilisateur.LoginUtilisateur"].Value = unUtilisateur.LoginUtilisateur;
            com.Parameters["@unUtilisateur.MdpUtilisateur"].Value = unUtilisateur.MdpUtilisateur;

            if (monReader.Read())
            {
                maConnexion.Close();
                return true;
            }
            else
            {
                maConnexion.Close();
                return false;
            }
        }
        //Transformation du droit utilisateur en string
        public static Boolean TransformationDroitUtilisateur(Utilisateur unUtilisateur)
        {
            
            // Connexion à la BD
            int code;
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand com = new SqlCommand();
            com.Connection = maConnexion;
            //Connexion à la base de données
            com.CommandText = ("select droit_utilisateur from GestionAS.dbo.utilisateur where login_utilisateur='" + @unUtilisateur.LoginUtilisateur + "'and mdp_utilisateur='" + @unUtilisateur.MdpUtilisateur + "'");
            SqlDataReader monReader = com.ExecuteReader();
            //Requêtes paramétrées
            com.Parameters.Add(new SqlParameter("@unUtilisateur.LoginUtilisateur", SqlDbType.VarChar, 25));
            com.Parameters.Add(new SqlParameter("@unUtilisateur.MdpUtilisateur", SqlDbType.VarChar, 25));
            //Attribution des valeurs
            com.Parameters["@unUtilisateur.LoginUtilisateur"].Value = unUtilisateur.LoginUtilisateur;
            com.Parameters["@unUtilisateur.MdpUtilisateur"].Value = unUtilisateur.MdpUtilisateur;

            // Insertion de droit_utilisateur dans variable code

            if (monReader.Read())
            {
                com.CommandText = ("select droit_utilisateur from GestionAS.dbo.utilisateur where login_utilisateur='" + @unUtilisateur.LoginUtilisateur + "'and mdp_utilisateur='" + @unUtilisateur.MdpUtilisateur + "'");
                code = Int32.Parse(monReader["droit_utilisateur"].ToString());
                //Requêtes paramétrées
                com.Parameters.Add(new SqlParameter("@unUtilisateur.LoginUtilisateur", SqlDbType.VarChar, 25));
                com.Parameters.Add(new SqlParameter("@unUtilisateur.MdpUtilisateur", SqlDbType.VarChar, 25));
                //Attribution des valeurs
                com.Parameters["@unUtilisateur.LoginUtilisateur"].Value = unUtilisateur.LoginUtilisateur;
                com.Parameters["@unUtilisateur.MdpUtilisateur"].Value = unUtilisateur.MdpUtilisateur;

                if (code != 1)
                {
                    // Fermeture de la connexion
                    maConnexion.Close();
                    return false;
                }
                else
                {
                    // Fermeture de la connexion
                    maConnexion.Close();
                    return true;
                }
            }
            else
            {
                maConnexion.Close();
                return false;
            }
            

        }
        


    }
}
