using System;
using System.Collections.Generic;
using System.Text;

namespace GestionASBO
{
    public class TypeFlux
    {
        private int idTypeFlux;
        private string libelleTypeFlux;

        public TypeFlux(int idTypeFlux, string libelleTypeFlux)
        {
            this.IdTypeFlux = idTypeFlux;
            this.LibelleTypeFlux = libelleTypeFlux;
        }

        public int IdTypeFlux { get => idTypeFlux; set => idTypeFlux = value; }
        public string LibelleTypeFlux { get => libelleTypeFlux; set => libelleTypeFlux = value; }
    }
}
