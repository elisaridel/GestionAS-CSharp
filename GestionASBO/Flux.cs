using System;
using System.Collections.Generic;
using System.Text;

namespace GestionASBO
{
    public class Flux
    {
        private int id_flux;
        private string libelle_flux;
        private DateTime date_flux;
        private float montant_flux;
        private int id_adherent;
        private int id_typeflux;
        private int id_budget;
        string etat_prelevement;
        string adherent;
        string typeflux;
        string budget;

        public Flux(int id_flux, string libelle_flux, DateTime date_flux, float montant_flux, int id_adherent, int id_typeflux, int id_budget, string etat_prelevement)
        {
            this.Id_flux = id_flux;
            this.Libelle_flux = libelle_flux;
            this.Date_flux = date_flux;
            this.Montant_flux = montant_flux;
            this.Id_adherent = id_adherent;
            this.Id_typeflux = id_typeflux;
            this.Id_budget = id_budget;
            this.Etat_prelevement = etat_prelevement;
        }
        public Flux(int id_flux, string libelle_flux, DateTime date_flux, float montant_flux, int id_adherent, int id_typeflux, int id_budget, string etat_prelevement, string adherent, string typeflux, string budget)
        {
            this.Id_flux = id_flux;
            this.Libelle_flux = libelle_flux;
            this.Date_flux = date_flux;
            this.Montant_flux = montant_flux;
            this.Id_adherent = id_adherent;
            this.Id_typeflux = id_typeflux;
            this.Id_budget = id_budget;
            this.Etat_prelevement = etat_prelevement;
            this.Adherent = adherent;
            this.Typeflux = typeflux;
            this.Budget = budget;
        }
        public Flux(string libelle_flux, DateTime date_flux, float montant_flux, int id_adherent, int id_typeflux, int id_budget, string etat_prelevement)
        {
            this.Libelle_flux = libelle_flux;
            this.Date_flux = date_flux;
            this.Montant_flux = montant_flux;
            this.Id_adherent = id_adherent;
            this.Id_typeflux = id_typeflux;
            this.Id_budget = id_budget;
            this.Etat_prelevement = etat_prelevement;
        }

        public Flux(int id_flux, string libelle_flux, DateTime date_flux, float montant_flux, string etat_prelevement, string typeflux, string budget)
        {
            this.Id_flux = id_flux;
            this.Libelle_flux = libelle_flux;
            this.Date_flux = date_flux;
            this.Montant_flux = montant_flux;
            this.Etat_prelevement = etat_prelevement;
            this.Typeflux = typeflux;
            this.Budget = budget;
        }
        public int Id_flux { get => id_flux; set => id_flux = value; }
        public string Libelle_flux { get => libelle_flux; set => libelle_flux = value; }
        public DateTime Date_flux { get => date_flux; set => date_flux = value; }
        public float Montant_flux { get => montant_flux; set => montant_flux = value; }
        public int Id_adherent { get => id_adherent; set => id_adherent = value; }
        public int Id_typeflux { get => id_typeflux; set => id_typeflux = value; }
        public int Id_budget { get => id_budget; set => id_budget = value; }
        public string Etat_prelevement { get => etat_prelevement; set => etat_prelevement = value; }
        public string Adherent { get => adherent; set => adherent = value; }
        public string Typeflux { get => typeflux; set => typeflux = value; }
        public string Budget { get => budget; set => budget = value; }
    }
}
