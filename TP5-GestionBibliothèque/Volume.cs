using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp3_Heritage
{
    public abstract class Volume : Document
    {
        private string auteur;

        public string Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }
        public override string ToString()
        {
            return base.ToString() + "Auteur : " + this.Auteur + "\n";
        }
        /// <summary>
        /// constructeur paramétré
        /// </summary>
        /// <param name="titre">titre du volume</param>
        /// <param name="auteur">auteur du volume</param>
        public Volume(string titre, string auteur) : base(titre)
        {
            this.Auteur = auteur;
        }
    }
}
