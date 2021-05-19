using System;
using System.Collections.Generic;
using System.Text;

namespace GestionASBO
{
    public class Budget
    {
        private int id_budget;
        private string libelle_budget;
        private float montantinitial_budget;

        public Budget(int id_budget, string libelle_budget, float montantinitial_budget)
        {
            this.Id_budget = id_budget;
            this.Libelle_budget = libelle_budget;
            this.Montantinitial_budget = montantinitial_budget;
        }
        public Budget(string libelle_budget, float montantinitial_budget)
        {
            this.Libelle_budget = libelle_budget;
            this.Montantinitial_budget = montantinitial_budget;
        }

        public int Id_budget { get => id_budget; set => id_budget = value; }
        public string Libelle_budget { get => libelle_budget; set => libelle_budget = value; }
        public float Montantinitial_budget { get => montantinitial_budget; set => montantinitial_budget = value; }
    }
}
