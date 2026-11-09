using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp3_Heritage
{
    public abstract class Document
    {
        private string titre;

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        public override string ToString()
        {
            return Type() + " : titre : " + this.Titre + "\n";
        }
        /// <summary>
        /// constructeur paramétré
        /// </summary>
        /// <param name="titre">titre du document</param>
        public Document(string titre)
        {
            this.Titre = titre;
        }

        public virtual string Type()
        {
            return "";
        }
    }

}
