using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp3_Heritage
{
    public class Dictionnaire : Volume
    {
        /// <summary>
        /// constructeur paramétré
        /// </summary>
        /// <param name="titre">titre du dico</param>
        /// <param name="auteur">auteur du dico</param>
        public Dictionnaire(string titre, string auteur) : base(titre, auteur)
        {

        }
        public override string ToString()
        {
            return "\n" + base.ToString();
        }

        public override string Type()
        {
            return "Dictionnaire";
        }
    }
}
