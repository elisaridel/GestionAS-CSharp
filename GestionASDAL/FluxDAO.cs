using System;
using System.Collections.Generic;
using GestionASBO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GestionASDAL
{
    public class FluxDAO
    {
        private static FluxDAO unFluxDAO;

        // Accesseur en lecture, renvoi une instance
        public static FluxDAO GetUnFluxDAO()
        {
            if (unFluxDAO == null)
            {
                unFluxDAO = new FluxDAO();
            }
            return unFluxDAO;
        }

        // Cette méthode retourne une List contenant les objets Adherentscontenus dans la table Identification
        public static List<Flux> GetFlux()
        {
            int id_flux;
            string libelle_flux;
            DateTime date_flux;
            float montant_flux;
            int id_adherent;
            int id_typeFlux;
            int id_budget;
            string etatPrelev;
            Flux unFlux;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Adherents
            List<Flux> lesFlux = new List<Flux>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM gestionAS.dbo.flux";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id_flux = Int32.Parse(monReader["id_flux"].ToString());
                date_flux = DateTime.Parse(monReader["date_flux"].ToString());
                montant_flux = float.Parse(monReader["montant_flux"].ToString());
                id_adherent = Int32.Parse(monReader["id_adherent"].ToString());
                id_budget = Int32.Parse(monReader["id_budget"].ToString());
                id_typeFlux = Int32.Parse(monReader["id_typeflux"].ToString());

                // Nom Adherent
                if (monReader["libelle_flux"] == DBNull.Value)
                {
                    libelle_flux = default(string);
                }
                else
                {
                    libelle_flux = monReader["libelle_flux"].ToString();
                }
                // Nom Adherent
                if (monReader["etat_prelevement"] == DBNull.Value)
                {
                    etatPrelev = default(string);
                }
                else
                {
                    etatPrelev = monReader["etat_prelevement"].ToString();
                }

                unFlux = new Flux(id_flux, libelle_flux, date_flux, montant_flux, id_adherent, id_typeFlux, id_budget, etatPrelev);
                lesFlux.Add(unFlux);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesFlux;

        }

        // Cette méthode retourne une List contenant les objets Adherents contenus dans la table Identification
        public static List<Flux> GetAfficheFlux()
        {
            int id_flux;
            string libelle_flux;
            DateTime date_flux;
            float montant_flux;
            string etat_prelevement;

            int id_adherent;
            int id_typeFlux;
            int id_budget;
            string adherent;
            string budget;
            string typeFlux;
            Flux unAfficheFlux;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Adherents
            List<Flux> lesFlux = new List<Flux>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT flux.id_flux,flux.libelle_flux,flux.date_flux, flux.montant_flux, flux.etat_prelevement, flux.id_adherent, flux.id_budget, flux.id_typeflux , adh.nom_adherent, typeFlux.libelle_typeflux, budget.libelle_budget FROM dbo.flux as flux, dbo.adherent as adh, dbo.type_flux as typeFlux, dbo.budget as budget WHERE flux.id_typeflux = typeFlux.id_typeflux AND flux.id_adherent = adh.id_adherent AND flux.id_budget = budget.id_budget";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id_flux = Int32.Parse(monReader["id_flux"].ToString());
                date_flux = DateTime.Parse(monReader["date_flux"].ToString());
                montant_flux = float.Parse(monReader["montant_flux"].ToString());
                id_adherent = Int32.Parse(monReader["id_adherent"].ToString());
                id_budget = Int32.Parse(monReader["id_budget"].ToString());
                id_typeFlux = Int32.Parse(monReader["id_typeflux"].ToString());

                // Nom Flux
                if (monReader["libelle_flux"] == DBNull.Value)
                {
                    libelle_flux = default(string);
                }
                else
                {
                    libelle_flux = monReader["libelle_flux"].ToString();
                }
                //Etat prélevement
                if (monReader["etat_prelevement"] == DBNull.Value)
                {
                    etat_prelevement = default(string);
                }
                else
                {
                    etat_prelevement = monReader["etat_prelevement"].ToString();
                }
                //Nom Adherent
                if (monReader["nom_adherent"] == DBNull.Value)
                {
                    adherent = default(string);
                }
                else
                {
                    adherent = monReader["nom_adherent"].ToString();
                }
                //Libelle budget
                if (monReader["libelle_budget"] == DBNull.Value)
                {
                    budget = default(string);
                }
                else
                {
                    budget = monReader["libelle_budget"].ToString();
                }
                //Libelle type flux
                if (monReader["libelle_typeflux"] == DBNull.Value)
                {
                    typeFlux = default(string);
                }
                else
                {
                    typeFlux = monReader["libelle_typeflux"].ToString();
                }


                unAfficheFlux = new Flux(id_flux, libelle_flux, date_flux, montant_flux, id_adherent, id_typeFlux, id_budget, etat_prelevement, adherent, budget, typeFlux);
                lesFlux.Add(unAfficheFlux);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesFlux;

        }
        //Modification d'un flux
        public static int ModificationFlux(Flux unFlux)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "UPDATE dbo.flux SET libelle_flux = '" + @unFlux.Libelle_flux + "', date_flux = '" + @unFlux.Date_flux + "', montant_flux ='" + @unFlux.Montant_flux + "', id_adherent = '" + @unFlux.Id_adherent + "', id_typeFlux = '" + @unFlux.Id_typeflux + "', id_budget ='" + @unFlux.Id_budget + "', etat_prelevement = '"+ @unFlux.Etat_prelevement +"' WHERE id_flux= '" + @unFlux.Id_flux + "'";

            nbEnr = cmd.ExecuteNonQuery();
            //Requêtes paramétrées
            cmd.Parameters.Add(new SqlParameter("@unFlux.Id_flux", SqlDbType.Int, 10));
            cmd.Parameters.Add(new SqlParameter("@unFlux.Libelle_flux", SqlDbType.VarChar, 25));
            cmd.Parameters.Add(new SqlParameter("@unFlux.Date_flux", SqlDbType.DateTime, 32));
            cmd.Parameters.Add(new SqlParameter("@unFlux.Montant_flux", SqlDbType.Int, 32));
            cmd.Parameters.Add(new SqlParameter("@unFlux.Id_adherent", SqlDbType.Int, 10));
            cmd.Parameters.Add(new SqlParameter("@unFlux.Id_budget", SqlDbType.Int, 10));
            cmd.Parameters.Add(new SqlParameter("@unFlux.Id_typeflux", SqlDbType.Int, 10));
            cmd.Parameters.Add(new SqlParameter("@unFlux.Id_flux", SqlDbType.Int, 10));
            cmd.Parameters.Add(new SqlParameter("@unFlux.Etat_prelevement", SqlDbType.VarChar, 25));
            //Attribution des valeurs
            cmd.Parameters["@unFlux.Libelle_flux"].Value = unFlux.Libelle_flux;
            cmd.Parameters["@unFlux.Date_flux"].Value = Convert.ToDateTime(unFlux.Date_flux);
            cmd.Parameters["@unFlux.Montant_flux"].Value = Convert.ToInt32(unFlux.Montant_flux);
            cmd.Parameters["@unFlux.Id_adherent"].Value = Convert.ToInt32(unFlux.Id_adherent);
            cmd.Parameters["@unFlux.Id_typeflux"].Value = Convert.ToInt32(unFlux.Id_typeflux);
            cmd.Parameters["@unFlux.Id_flux"].Value = Convert.ToInt32(unFlux.Id_flux);
            cmd.Parameters["@unFlux.Id_budget"].Value = Convert.ToInt32(unFlux.Id_budget);
            cmd.Parameters["@unFlux.Id_flux"].Value = Convert.ToInt32(unFlux.Id_flux);
            cmd.Parameters["@unFlux.Etat_prelevement"].Value = unFlux.Etat_prelevement;
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode supprime de la BD un flux dont l'id est passé en paramètre
        public static int DeleteFlux(int id)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM gestionAS.dbo.flux WHERE id_flux = " + @id;
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 10));
            cmd.Parameters["@id"].Value = Convert.ToInt32(id);
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode insert un nouveau flux passé en paramètre dans la BD
        public static int AjoutFlux(Flux unFlux)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO  dbo.flux (libelle_flux, date_flux, montant_flux, id_adherent, id_typeFlux, id_budget, etat_prelevement) values ('" + @unFlux.Libelle_flux + "','" + @unFlux.Date_flux + "', '" + @unFlux.Montant_flux + "','" + @unFlux.Id_adherent + "', '" + @unFlux.Id_typeflux +
                "','" + @unFlux.Id_budget + "', '" + @unFlux.Etat_prelevement + "')";
            nbEnr = cmd.ExecuteNonQuery();
            //Requêtes paramétrées
            cmd.Parameters.Add(new SqlParameter("@unFlux.Libelle_flux", SqlDbType.VarChar, 25));
            cmd.Parameters.Add(new SqlParameter("@unFlux.Date_flux", SqlDbType.DateTime, 32));
            cmd.Parameters.Add(new SqlParameter("@unFlux.Montant_flux", SqlDbType.Int, 32));
            cmd.Parameters.Add(new SqlParameter("@unFlux.Id_adherent", SqlDbType.Int, 10));
            cmd.Parameters.Add(new SqlParameter("@unFlux.Id_budget", SqlDbType.Int, 10));
            cmd.Parameters.Add(new SqlParameter("@unFlux.Id_typeflux", SqlDbType.Int, 10));
            cmd.Parameters.Add(new SqlParameter("@unFlux.Id_flux", SqlDbType.Int, 10));
            cmd.Parameters.Add(new SqlParameter("@unFlux.Etat_prelevement", SqlDbType.VarChar, 25));
            //Attribution des valeurs
            cmd.Parameters["@unFlux.Libelle_flux"].Value = unFlux.Libelle_flux;
            cmd.Parameters["@unFlux.Date_flux"].Value = Convert.ToDateTime(unFlux.Date_flux);
            cmd.Parameters["@unFlux.Montant_flux"].Value = Convert.ToInt32(unFlux.Montant_flux);
            cmd.Parameters["@unFlux.Id_adherent"].Value = Convert.ToInt32(unFlux.Id_adherent);
            cmd.Parameters["@unFlux.Id_typeflux"].Value = Convert.ToInt32(unFlux.Id_typeflux);
            cmd.Parameters["@unFlux.Id_flux"].Value = Convert.ToInt32(unFlux.Id_flux);
            cmd.Parameters["@unFlux.Id_budget"].Value = Convert.ToInt32(unFlux.Id_budget);
            cmd.Parameters["@unFlux.Etat_prelevement"].Value = unFlux.Etat_prelevement;
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}
