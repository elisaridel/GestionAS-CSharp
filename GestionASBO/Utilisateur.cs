using System;
using System.Collections.Generic;
using System.Text;

namespace GestionASBO
{
    public class Utilisateur
    {
        private int idUtilisateur;
        private string loginUtilisateur;
        private string mdpUtilisateur;
        private int droitUtilisateur;
        private int code;

        public int IdUtilisateur { get => idUtilisateur; set => idUtilisateur = value; }
        public string LoginUtilisateur { get => loginUtilisateur; set => loginUtilisateur = value; }
        public string MdpUtilisateur { get => mdpUtilisateur; set => mdpUtilisateur = value; }
        public int DroitUtilisateur { get => droitUtilisateur; set => droitUtilisateur = value; }
        public int Code { get => code; set => code = value; }

        public Utilisateur(int idUtilisateur, string loginUtilisateur, string mdpUtilisateur, int droitUtilisateur)
        {
            this.idUtilisateur = idUtilisateur;
            this.loginUtilisateur = loginUtilisateur;
            this.mdpUtilisateur = mdpUtilisateur;
            this.droitUtilisateur = droitUtilisateur;
        }
        public Utilisateur(string loginUtilisateur, string mdpUtilisateur)
        {

            this.loginUtilisateur = loginUtilisateur;
            this.mdpUtilisateur = mdpUtilisateur;
        }
        
    }
}
