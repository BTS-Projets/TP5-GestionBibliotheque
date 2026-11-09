using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp3_Heritage
{
    public class Livre : Volume
    {
        private bool emprunte;

        public bool Emprunte
        {
            get { return emprunte; }
            set { emprunte = value; }
        }
        /// <summary>
        /// constructeur paramétré
        /// </summary>
        /// <param name="titre">titre du livre</param>
        /// <param name="auteur">auteur du livre</param>
        public Livre(string titre, string auteur) : base(titre, auteur)
        {
            this.emprunte = false;
        }
        public override string ToString()
        {
            return "\n" + base.ToString() + "emprunté : " + this.Emprunte;
        }
        public override string Type()
        {
            return "Livre";
        }
    }
}
