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
    public class AdherentDAO
    {
        private static AdherentDAO unAdherentDAO;
        private static AdherentDAO unDetailAdherentDAO;
        // Accesseur en lecture, renvoi une instance
        public static AdherentDAO GetUnAdherentDAO()
        {
            if (unAdherentDAO == null)
            {
                unAdherentDAO = new AdherentDAO();
            }
            return unAdherentDAO;
        }
        public static AdherentDAO GetUnDetailAdherentDAO()
        {
            if (unDetailAdherentDAO == null)
            {
                unDetailAdherentDAO = new AdherentDAO();
            }
            return unDetailAdherentDAO;
        }

        // Cette méthode retourne une List contenant les objets Adherentscontenus dans la table Identification
        public static List<Adherent> GetAdherents()
        {
            int id_adherent;
            string nom_adherent;
            string prenom_adherent;
            DateTime ddn_adherent;
            long numtel_adherent;
            string email_adherent;
            long numparent_adherent;
            string autoprelev_adherent;
            string sexe_adherent;
            DateTime datemaj_adherent;
            string archive_adherent;
            int id_classe;
            Adherent unAdherent;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Adherents
            List<Adherent> lesAdherents = new List<Adherent>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM gestionAS.dbo.adherent";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id_adherent = Int32.Parse(monReader["id_adherent"].ToString());
                ddn_adherent = DateTime.Parse(monReader["ddn_adherent"].ToString());
                numtel_adherent = long.Parse(monReader["numtel_adherent"].ToString());
                numparent_adherent = long.Parse(monReader["numparent_adherent"].ToString());
                datemaj_adherent = DateTime.Parse(monReader["datemaj_adherent"].ToString());
                id_classe = Int32.Parse(monReader["id_classe"].ToString());

                // Nom Adherent
                if (monReader["nom_adherent"] == DBNull.Value)
                {
                    nom_adherent = default(string);
                }
                else
                {
                    nom_adherent = monReader["nom_adherent"].ToString();
                }
                // Prénom Adherent
                if (monReader["prenom_adherent"] == DBNull.Value)
                {
                    prenom_adherent = default(string);
                }
                else
                {
                    prenom_adherent = monReader["prenom_adherent"].ToString();
                }
                // Mail Adherent
                if (monReader["email_adherent"] == DBNull.Value)
                {
                    email_adherent = default(string);
                }
                else
                {
                    email_adherent = monReader["email_adherent"].ToString();
                }
               
                // Sexe Adherent
                if (monReader["sexe_adherent"] == DBNull.Value)
                {
                    sexe_adherent = default(string);
                }
                else
                {
                    sexe_adherent = monReader["sexe_adherent"].ToString();
                }
                // Archive Adherent
                if (monReader["archive_adherent"] == DBNull.Value)
                {
                    archive_adherent = default(string);
                }
                else
                {
                    archive_adherent = monReader["archive_adherent"].ToString();
                }
                // Autoprelev
                if (monReader["autoprelev_adherent"] == DBNull.Value)
                {
                    autoprelev_adherent = default(string);
                }
                else
                {
                    autoprelev_adherent = monReader["autoprelev_adherent"].ToString();
                }

                unAdherent = new Adherent(id_adherent, nom_adherent, prenom_adherent, ddn_adherent, numtel_adherent, email_adherent, numparent_adherent, autoprelev_adherent, sexe_adherent, datemaj_adherent, archive_adherent, id_classe);
                lesAdherents.Add(unAdherent);
                

            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesAdherents;

        }

        //Modification d'un élève
        public static int ModificationAdherent(Adherent unAdherent)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "UPDATE dbo.adherent SET nom_adherent = '" + @unAdherent.Nom_adherent + "', prenom_adherent = '" + @unAdherent.Prenom_adherent + "', ddn_adherent = '" + @unAdherent.Ddn_adherent + "', numtel_adherent = '" + @unAdherent.Numtel_adherent + "', email_adherent = '" + @unAdherent.Email_adherent + "', numparent_adherent = '" + @unAdherent.Numparent_adherent + "', autoprelev_adherent = '" + @unAdherent.Autoprelev_adherent + "', sexe_adherent = '" + @unAdherent.Sexe_adherent + "', datemaj_adherent = '" + @unAdherent.Datemaj_adherent + "', archive_adherent = '" + @unAdherent.Archive_adherent + "' WHERE id_adherent = '" + @unAdherent.Id_adherent + "'";
            nbEnr = cmd.ExecuteNonQuery();
            //Requêtes paramétrées
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Id_adherent", SqlDbType.Int, 10));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Nom_adherent", SqlDbType.VarChar, 25));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Prenom_adherent", SqlDbType.VarChar, 25));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Ddn_adherent", SqlDbType.DateTime, 25));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Numtel_adherent", SqlDbType.Int, 64));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Email_adherent", SqlDbType.VarChar, 25));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Numparent_adherent", SqlDbType.Int, 64));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Autoprelev_adherent", SqlDbType.VarChar, 25));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Sexe_adherent", SqlDbType.VarChar, 25));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Id_classe", SqlDbType.Int, 10));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Datemaj_adherent", SqlDbType.DateTime, 25));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Archive_adherent", SqlDbType.VarChar, 25));

            //Attribution des valeurs
            cmd.Parameters["@unAdherent.Nom_adherent"].Value = unAdherent.Nom_adherent;
            cmd.Parameters["@unAdherent.Prenom_adherent"].Value = unAdherent.Prenom_adherent;
            cmd.Parameters["@unAdherent.Ddn_adherent"].Value = unAdherent.Ddn_adherent;
            cmd.Parameters["@unAdherent.NumTel_adherent"].Value = unAdherent.Numtel_adherent;
            cmd.Parameters["@unAdherent.Email_adherent"].Value = unAdherent.Email_adherent;
            cmd.Parameters["@unAdherent.Numparent_adherent"].Value = unAdherent.Numparent_adherent;
            cmd.Parameters["@unAdherent.Autoprelev_adherent"].Value = unAdherent.Autoprelev_adherent;
            cmd.Parameters["@unAdherent.Sexe_adherent"].Value = unAdherent.Sexe_adherent;
            cmd.Parameters["@unAdherent.Id_classe"].Value = unAdherent.Id_classe;
            cmd.Parameters["@unAdherent.Datemaj_adherent"].Value = unAdherent.Datemaj_adherent;
            cmd.Parameters["@unAdherent.Archive_adherent"].Value = unAdherent.Archive_adherent;
            cmd.Parameters["@unAdherent.Id_adherent"].Value = unAdherent.Id_adherent;
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode supprime de la BD un adherent dont l'id est passé en paramètre
        public static int DeleteAdherent(int id)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM GestionAS.dbo.adherent WHERE id_adherent = " + @id;
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 10));
            cmd.Parameters["@id"].Value = Convert.ToInt32(id);
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode insert un nouvel utilisateur passé en paramètre dans la BD
        public static int AjoutUtilisateur(Adherent unAdherent)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO  dbo.adherent (nom_adherent, prenom_adherent, ddn_adherent, numtel_adherent, email_adherent,numparent_adherent, autoprelev_adherent, sexe_adherent, id_classe, id_utilisateur, datemaj_adherent, login_adherent, mdp_adherent, archive_adherent) values ('"+ @unAdherent.Nom_adherent+"','"+@unAdherent.Prenom_adherent+"', '"+@unAdherent.Ddn_adherent+"','"+@unAdherent.Numtel_adherent+"', '"+@unAdherent.Email_adherent+
                "','"+ @unAdherent.Numparent_adherent+"', '"+@unAdherent.Autoprelev_adherent+"','"+@unAdherent.Sexe_adherent+ "', '" + @unAdherent.Id_classe + "', '" + 2 +"', '" +@unAdherent.Datemaj_adherent+"', '"+@unAdherent.Nom_adherent+"','"+@unAdherent.Nom_adherent+ "','Non')";
            nbEnr = cmd.ExecuteNonQuery();

            //Requêtes paramétrées
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Nom_adherent", SqlDbType.VarChar, 25));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Prenom_adherent", SqlDbType.VarChar, 25));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Ddn_adherent", SqlDbType.DateTime, 25));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Numtel_adherent", SqlDbType.Int, 64));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Email_adherent", SqlDbType.VarChar, 25));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Numparent_adherent", SqlDbType.Int, 64));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Autoprelev_adherent", SqlDbType.VarChar, 25));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Sexe_adherent", SqlDbType.VarChar, 25));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Id_classe", SqlDbType.Int, 10));
            cmd.Parameters.Add(new SqlParameter("@unAdherent.Datemaj_adherent", SqlDbType.DateTime, 25));

            //Attribution des valeurs
            cmd.Parameters["@unAdherent.Nom_adherent"].Value = unAdherent.Nom_adherent;
            cmd.Parameters["@unAdherent.Prenom_adherent"].Value = unAdherent.Prenom_adherent;
            cmd.Parameters["@unAdherent.Ddn_adherent"].Value = unAdherent.Ddn_adherent;
            cmd.Parameters["@unAdherent.NumTel_adherent"].Value = unAdherent.Numtel_adherent;
            cmd.Parameters["@unAdherent.Email_adherent"].Value = unAdherent.Email_adherent;
            cmd.Parameters["@unAdherent.Numparent_adherent"].Value = unAdherent.Numparent_adherent;
            cmd.Parameters["@unAdherent.Autoprelev_adherent"].Value = unAdherent.Autoprelev_adherent;
            cmd.Parameters["@unAdherent.Sexe_adherent"].Value = unAdherent.Sexe_adherent;
            cmd.Parameters["@unAdherent.Id_classe"].Value = unAdherent.Id_classe;
            cmd.Parameters["@unAdherent.Datemaj_adherent"].Value = unAdherent.Datemaj_adherent;

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode filtre les utilisateur
        public static List<Adherent> FiltreUtilisateur(string recherche)
        {
            int id_adherent;
            string nom_adherent;
            string prenom_adherent;
            DateTime ddn_adherent;
            long numtel_adherent;
            string email_adherent;
            long numparent_adherent;
            string autoprelev_adherent;
            string sexe_adherent;
            DateTime datemaj_adherent;
            string archive_adherent;
            string classe;
            int id_classe;
            Adherent unFiltre;

            // Connexion à la BD
            List<Adherent> lesFiltres = new List<Adherent>();
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            //SELECT id_adherent, nom_adherent, prenom_adherent, ddn_adherent, numtel_adherent, email_adherent, numparent_adherent, autoprelev_adherent, sexe_adherent, datemaj_adherent, archive_adherent, libelle_classe FROM dbo.adherent as adh, dbo.classe as c WHERE adh.id_classe = c.id_classe
            cmd.CommandText = "SELECT id_adherent, nom_adherent, prenom_adherent, ddn_adherent, numtel_adherent, email_adherent, numparent_adherent, autoprelev_adherent, sexe_adherent, datemaj_adherent, archive_adherent, libelle_classe, adh.id_classe FROM gestionAS.dbo.adherent as adh, dbo.classe as c where adh.id_classe = c.id_classe AND nom_adherent LIKE '" + @recherche +"%' OR prenom_adherent LIKE '"+@recherche+"%'";
            cmd.Parameters.Add(new SqlParameter("@recherche", SqlDbType.VarChar, 25));
            cmd.Parameters["@recherche"].Value = recherche;
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                id_adherent = Int32.Parse(monReader["id_adherent"].ToString());
                ddn_adherent = DateTime.Parse(monReader["ddn_adherent"].ToString());
                numtel_adherent = long.Parse(monReader["numtel_adherent"].ToString());
                numparent_adherent = long.Parse(monReader["numparent_adherent"].ToString());
                datemaj_adherent = DateTime.Parse(monReader["datemaj_adherent"].ToString());
                id_classe = Int32.Parse(monReader["id_classe"].ToString());

                // Nom Adherent
                if (monReader["nom_adherent"] == DBNull.Value)
                {
                    nom_adherent = default(string);
                }
                else
                {
                    nom_adherent = monReader["nom_adherent"].ToString();
                }
                // Prénom Adherent
                if (monReader["prenom_adherent"] == DBNull.Value)
                {
                    prenom_adherent = default(string);
                }
                else
                {
                    prenom_adherent = monReader["prenom_adherent"].ToString();
                }
                // Mail Adherent
                if (monReader["email_adherent"] == DBNull.Value)
                {
                    email_adherent = default(string);
                }
                else
                {
                    email_adherent = monReader["email_adherent"].ToString();
                }

                // Sexe Adherent
                if (monReader["sexe_adherent"] == DBNull.Value)
                {
                    sexe_adherent = default(string);
                }
                else
                {
                    sexe_adherent = monReader["sexe_adherent"].ToString();
                }
                // Archive Adherent
                if (monReader["archive_adherent"] == DBNull.Value)
                {
                    archive_adherent = default(string);
                }
                else
                {
                    archive_adherent = monReader["archive_adherent"].ToString();
                }
                // Autoprelev
                if (monReader["autoprelev_adherent"] == DBNull.Value)
                {
                    autoprelev_adherent = default(string);
                }
                else
                {
                    autoprelev_adherent = monReader["autoprelev_adherent"].ToString();
                }
                // classe
                if (monReader["libelle_classe"] == DBNull.Value)
                {
                    classe = default(string);
                }
                else
                {
                    classe = monReader["libelle_classe"].ToString();
                }

                unFiltre = new Adherent(id_adherent, nom_adherent, prenom_adherent, ddn_adherent, numtel_adherent, email_adherent, numparent_adherent, autoprelev_adherent, sexe_adherent, datemaj_adherent, archive_adherent, id_classe, classe);
                lesFiltres.Add(unFiltre);

            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesFiltres;
        }
        // Cette méthode retourne le nombre d'utilisateur selon leur genre
        public static DataSet StatsGenre()
        {
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            DataSet ds = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT sexe_adherent, count(*) as nb FROM gestionAS.dbo.adherent GROUP BY sexe_adherent", maConnexion);
            adapt.Fill(ds);
            // Fermeture de la connexion
            maConnexion.Close();
            return ds;
        }
        // Cette méthode retourne le nombre d'utilisateur selon leur date de naissance
        public static DataSet StatsDdn()
        {
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            DataSet ds = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT YEAR(ddn_adherent) as year, count(*) as nbParDdn FROM gestionAS.dbo.adherent GROUP BY YEAR(ddn_adherent)", maConnexion);
            adapt.Fill(ds);
            // Fermeture de la connexion
            maConnexion.Close();
            return ds;
        }
        // Cette méthode retourne le nombre d'évènement auquel à participé un élève
        public static DataSet StatsEvenementEleve()
        {
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            DataSet ds = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter("Select count(*) as nbEvenement, nom_adherent from dbo.flux as flux, dbo.adherent as adh where id_typeflux = ( select id_typeflux FROM dbo.type_flux WHERE libelle_typeflux like 'participation événement') and flux.id_adherent = adh.id_adherent GROUP BY nom_adherent", maConnexion);
            adapt.Fill(ds);
            // Fermeture de la connexion
            maConnexion.Close();
            return ds;
        }
        // Cette méthode calcule le nombre de licenciés
        public static int NbAdherent()
        {
            int nbAdherent;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select count(*) AS nbAdherent FROM GestionAS.dbo.adherent";
            SqlDataReader monReader = cmd.ExecuteReader();
            nbAdherent = 0;
            if (monReader.Read())
            {
                // Nom Adherent
                if (monReader["nbAdherent"] == DBNull.Value)
                {
                    nbAdherent = 0;
                }
                else
                {
                    nbAdherent = Int32.Parse(monReader["nbAdherent"].ToString());
                }

            }
            // Fermeture de la connexion
            maConnexion.Close();
            return nbAdherent;
        }
        // Cette méthode calcule le nombre d'élèves ayant participer à un évènement
        public static int NbAdherentEvenement()
        {
            int nbAdherent;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select count(*) as nbAdherentEvenement from dbo.flux where id_typeflux = ( select id_typeflux FROM dbo.type_flux WHERE libelle_typeflux like 'participation événement')";
            SqlDataReader monReader = cmd.ExecuteReader();
            nbAdherent = 0;
            if (monReader.Read())
            {
                // Nom Adherent
                if (monReader["nbAdherentEvenement"] == DBNull.Value)
                {
                    nbAdherent = 0;
                }
                else
                {
                    nbAdherent = Int32.Parse(monReader["nbAdherentEvenement"].ToString());
                }

            }
            // Fermeture de la connexion
            maConnexion.Close();
            return nbAdherent;
        }
        // Affichage détail élève
        public static List<Adherent> GetDetailAdherents()
        {
            int id_adherent;
            string nom_adherent;
            string prenom_adherent;
            DateTime ddn_adherent;
            long numtel_adherent;
            string email_adherent;
            long numparent_adherent;
            string autoprelev_adherent;
            string sexe_adherent;
            DateTime datemaj_adherent;
            string archive_adherent;
            int id_classe;
            string classe;
            Adherent unDetailAdherentDAO;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Adherents
            List<Adherent> lesAdherents = new List<Adherent>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT id_adherent, nom_adherent, prenom_adherent, ddn_adherent, numtel_adherent, email_adherent, numparent_adherent, autoprelev_adherent, sexe_adherent, datemaj_adherent, archive_adherent, libelle_classe, adh.id_classe FROM dbo.adherent as adh, dbo.classe as c WHERE adh.id_classe = c.id_classe";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id_adherent = Int32.Parse(monReader["id_adherent"].ToString());
                ddn_adherent = DateTime.Parse(monReader["ddn_adherent"].ToString());
                numtel_adherent = long.Parse(monReader["numtel_adherent"].ToString());
                numparent_adherent = long.Parse(monReader["numparent_adherent"].ToString());
                datemaj_adherent = DateTime.Parse(monReader["datemaj_adherent"].ToString());
                id_classe = Int32.Parse(monReader["id_classe"].ToString());

                // Nom Adherent
                if (monReader["nom_adherent"] == DBNull.Value)
                {
                    nom_adherent = default(string);
                }
                else
                {
                    nom_adherent = monReader["nom_adherent"].ToString();
                }
                // Prénom Adherent
                if (monReader["prenom_adherent"] == DBNull.Value)
                {
                    prenom_adherent = default(string);
                }
                else
                {
                    prenom_adherent = monReader["prenom_adherent"].ToString();
                }
                // Mail Adherent
                if (monReader["email_adherent"] == DBNull.Value)
                {
                    email_adherent = default(string);
                }
                else
                {
                    email_adherent = monReader["email_adherent"].ToString();
                }

                // Sexe Adherent
                if (monReader["sexe_adherent"] == DBNull.Value)
                {
                    sexe_adherent = default(string);
                }
                else
                {
                    sexe_adherent = monReader["sexe_adherent"].ToString();
                }
                // Archive Adherent
                if (monReader["archive_adherent"] == DBNull.Value)
                {
                    archive_adherent = default(string);
                }
                else
                {
                    archive_adherent = monReader["archive_adherent"].ToString();
                }
                //Classe
                if (monReader["libelle_classe"] == DBNull.Value)
                {
                    classe = default(string);
                }
                else
                {
                    classe = monReader["libelle_classe"].ToString();
                }
                // Autoprelev
                if (monReader["autoprelev_adherent"] == DBNull.Value)
                {
                    autoprelev_adherent = default(string);
                }
                else
                {
                    autoprelev_adherent = monReader["autoprelev_adherent"].ToString();
                }

                unDetailAdherentDAO = new Adherent(id_adherent, nom_adherent, prenom_adherent, ddn_adherent, numtel_adherent, email_adherent, numparent_adherent, autoprelev_adherent, sexe_adherent, datemaj_adherent, archive_adherent, id_classe, classe);
                lesAdherents.Add(unDetailAdherentDAO);


            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesAdherents;

        }
        // Cette méthode retourne une List contenant les objets Adherents contenus dans la table Identification
        public static List<Flux> GetAfficheFlux(int id_adherent)
        {
            int id_flux;
            string libelle_flux;
            DateTime date_flux;
            float montant_flux;
            string etat_prelevement;
            string budget;
            string typeFlux;
            Flux unFlux;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Adherents
            List<Flux> lesFlux = new List<Flux>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT DISTINCT id_flux,flux.libelle_flux,date_flux,montant_flux, etat_prelevement, typeFlux.libelle_typeflux, libelle_budget FROM dbo.flux as flux, dbo.type_flux as typeFlux, dbo.budget as budget WHERE flux.id_typeflux = typeFlux.id_typeflux AND flux.id_adherent = '" + @id_adherent + "' AND flux.id_budget = budget.id_budget";
            cmd.Parameters.Add(new SqlParameter("@id_adherent", SqlDbType.Int, 10));
            cmd.Parameters["@id_adherent"].Value = Convert.ToInt32(id_adherent);
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id_flux = Int32.Parse(monReader["id_flux"].ToString());
                date_flux = DateTime.Parse(monReader["date_flux"].ToString());
                montant_flux = float.Parse(monReader["montant_flux"].ToString());

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


                unFlux = new Flux(id_flux, libelle_flux, date_flux, montant_flux, etat_prelevement, budget, typeFlux);
                lesFlux.Add(unFlux);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesFlux;

        }
    }
}
