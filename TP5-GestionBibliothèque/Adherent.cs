using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp3_Heritage
{
    public class Adherent
    {
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        private List<Livre> lesLivres = new List<Livre>();

        public List<Livre> LesLivres
        {
            get { return lesLivres; }
            set { lesLivres = value; }
        }
        public override string ToString()
        {
            return this.Nom + " " + this.Prenom + "\n";
        }

        public Adherent(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }
        /// <summary>
        /// permet de noter l'emprunt d'un livre par un adhérent s'il ne l'est pas encore
        /// </summary>
        /// <param name="l">livre à emprunter</param>
        public void EmprunterLivre(Livre l)
        {
            if (l.Emprunte == false)
            {
                l.Emprunte = true; // je note que le livre est emprunté
                lesLivres.Add(l);// j'ajoute le livre emprunté dans la collection
            }
            else
            {
                throw new Exception("Le livre est déja emprunté !");
            }
        }

        public void RendreLivre(Livre l)
        {
            // on test si le livre a bien été emprunté par cet adhérent
            // pour cela on doit parcourir la collection pour savoir si le livre en fait partie
            if (lesLivres.Remove(l) == true)
            {
                l.Emprunte = false;
                Console.WriteLine("Le Livre a bien été noté comme étant rendu");
                Console.ReadKey();
            }
            else
            {
                throw new Exception("Le livre ne fait pas partit des livres emprunté par cet adhérent.");
            }
        }
    }
}
