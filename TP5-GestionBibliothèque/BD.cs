using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp3_Heritage
{
    public class BD : Volume
    {
        private string dessinateur;

        public string Dessinateur
        {
            get { return dessinateur; }
            set { dessinateur = value; }
        }
        public override string ToString()
        {
            return "\n" + base.ToString() + "Dessinateur :" + this.Dessinateur + "\n";
        }
        /// <summary>
        /// constructeur paramétré
        /// </summary>
        /// <param name="titre">titre de la BD</param>
        /// <param name="auteur">Auteur de la BD</param>
        /// <param name="dessinateur">Dessinateur de la BD</param>
        public BD(string titre, string auteur, string dessinateur) : base(titre, auteur)
        {
            this.Dessinateur = dessinateur;
        }
        public override string Type()
        {
            return "BD";
        }
    }
}
