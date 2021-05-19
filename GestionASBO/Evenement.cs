using System;
using System.Collections.Generic;
using System.Text;

namespace GestionASBO
{
    public class Evenement
    {
        private int idEvenement;
        private string libelleEvenement;
        private DateTime dateEvenement;
        private string lieuEvenement;
        private float coutEvenement;

        public int GetIdEvenement()
        {
            return idEvenement;
        }

        public void SetIdEvenement(int unIdEvenement)
        {
            idEvenement = unIdEvenement;
        }

        public string GetLibelleEvenement()
        {
            return libelleEvenement;
        }

        public void SetLibelleEvenement(string unLibelleEvenement)
        {
            libelleEvenement = unLibelleEvenement;
        }

        public DateTime GetDateEvenement()
        {
            return dateEvenement;
        }

        public void SetDateEvenement(DateTime unDateEvenement)
        {
            dateEvenement = unDateEvenement;
        }

        public string GetLieuEvenement()
        {
            return lieuEvenement;
        }

        public void SetLieuEvenement(string unLieuEvenement)
        {
            lieuEvenement = unLieuEvenement;
        }

        public float GetCoutEvenement()
        {
            return coutEvenement;
        }

        public void SetCoutEvenement(float unCoutEvenement)
        {
            coutEvenement = unCoutEvenement;
        }
    }
}
