using System;

namespace GestionASBO
{
    public class Adherent
    {
        private int id_adherent;
        private string nom_adherent;
        private string prenom_adherent;
        private DateTime ddn_adherent;
        private long numtel_adherent;
        private string email_adherent;
        private long numparent_adherent;
        private string autoprelev_adherent;
        private string sexe_adherent;
        private string login_adherent;
        private string mdp_adherent;
        private DateTime datemaj_adherent;
        private string archive_adherent;
        private int id_classe;
        private int nbGenre;
        private string classe;


        public Adherent(int id_adherent, string nom_adherent, string prenom_adherent, DateTime ddn_adherent, long numtel_adherent, string email_adherent, long numparent_adherent, string autoprelev_adherent, string sexe_adherent, DateTime datemaj_adherent, string archive_adherent, int id_classe)
        {
            this.Id_adherent = id_adherent;
            this.Nom_adherent = nom_adherent;
            this.Prenom_adherent = prenom_adherent;
            this.Ddn_adherent = ddn_adherent;
            this.Numtel_adherent = numtel_adherent;
            this.Email_adherent = email_adherent;
            this.Numparent_adherent = numparent_adherent;
            this.Autoprelev_adherent = autoprelev_adherent;
            this.Sexe_adherent = sexe_adherent;
            this.Datemaj_adherent = datemaj_adherent;
            this.Archive_adherent = archive_adherent;
            this.Id_classe = id_classe;
        }
        public Adherent(int id_adherent, string nom_adherent, string prenom_adherent, DateTime ddn_adherent, long numtel_adherent, string email_adherent, long numparent_adherent, string autoprelev_adherent, string sexe_adherent, DateTime datemaj_adherent, string archive_adherent, int id_classe, string classe)
        {
            this.Id_adherent = id_adherent;
            this.Nom_adherent = nom_adherent;
            this.Prenom_adherent = prenom_adherent;
            this.Ddn_adherent = ddn_adherent;
            this.Numtel_adherent = numtel_adherent;
            this.Email_adherent = email_adherent;
            this.Numparent_adherent = numparent_adherent;
            this.Autoprelev_adherent = autoprelev_adherent;
            this.Sexe_adherent = sexe_adherent;
            this.Datemaj_adherent = datemaj_adherent;
            this.Archive_adherent = archive_adherent;
            this.Id_classe = id_classe;
            this.Classe = classe;
        }
        public Adherent(string nom_adherent, string prenom_adherent, DateTime ddn_adherent, int numtel_adherent, string email_adherent, int numparent_adherent, string autoprelev_adherent, string sexe_adherent, DateTime datemaj_adherent, int id_classe)
        {
            this.Nom_adherent = nom_adherent;
            this.Prenom_adherent = prenom_adherent;
            this.Ddn_adherent = ddn_adherent;
            this.Numtel_adherent = numtel_adherent;
            this.Email_adherent = email_adherent;
            this.Numparent_adherent = numparent_adherent;
            this.Autoprelev_adherent = autoprelev_adherent;
            this.Sexe_adherent = sexe_adherent;
            this.Datemaj_adherent = datemaj_adherent;
            this.Id_classe = id_classe;
        }
        public Adherent(string sexe_adherent, int nbGenre)
        {
            this.Sexe_adherent = sexe_adherent;
            this.NbGenre = nbGenre;
        }
        public int Id_adherent { get => id_adherent; set => id_adherent = value; }
        public string Nom_adherent { get => nom_adherent; set => nom_adherent = value; }
        public string Prenom_adherent { get => prenom_adherent; set => prenom_adherent = value; }
        public DateTime Ddn_adherent { get => ddn_adherent; set => ddn_adherent = value; }
        public long Numtel_adherent { get => numtel_adherent; set => numtel_adherent = value; }
        public string Email_adherent { get => email_adherent; set => email_adherent = value; }
        public long Numparent_adherent { get => numparent_adherent; set => numparent_adherent = value; }
        public string Autoprelev_adherent { get => autoprelev_adherent; set => autoprelev_adherent = value; }
        public string Sexe_adherent { get => sexe_adherent; set => sexe_adherent = value; }
        public string Login_adherent { get => login_adherent; set => login_adherent = value; }
        public string Mdp_adherent { get => mdp_adherent; set => mdp_adherent = value; }
        public DateTime Datemaj_adherent { get => datemaj_adherent; set => datemaj_adherent = value; }
        public string Archive_adherent { get => archive_adherent; set => archive_adherent = value; }
        public int Id_classe { get => id_classe; set => id_classe = value; }
        public string Classe { get => classe; set => classe = value; }
        public int NbGenre { get => nbGenre; set => nbGenre = value; }
    }
}