using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp3_Heritage
{
    public class Bibliotheque
    {

        private List<Adherent> lesAdherents = new List<Adherent>();

        public List<Adherent> LesAdherents
        {
            get { return lesAdherents; }
            set { lesAdherents = value; }
        }

        private List<Document> lesDocuments = new List<Document>();

        public List<Document> LesDocuments
        {
            get { return lesDocuments; }
            set { lesDocuments = value; }
        }

        /// <summary>
        /// Ajoute un adhérent dans la collection
        /// </summary>
        /// <param name="a">adhérent à ajouter</param>
        public void AjouterAdherent(Adherent a)
        {
            lesAdherents.Add(a);
        }
        /// <summary>
        /// Ajoute un document dans la collection
        /// </summary>
        /// <param name="d">Document à ajouter</param>
        public void AjouterDocument(Document d)
        {
            lesDocuments.Add(d);
        }

        /// <summary>
        /// renvoie la collection de documents dont le titre contient la valeur passée en paramètre
        /// </summary>
        /// <param name="texteRecherche">texte à rechercher</param>
        /// <returns>collection de documents</returns>
        public List<Document> ChercherDocument(string texteRecherche)
        {
            List<Document> lesDocRecherches = new List<Document>();
            foreach (Document d in this.LesDocuments)
            {
                if (d.Titre.IndexOf(texteRecherche) != -1) // test si le texte recherché est dans le titre du document
                {
                    lesDocRecherches.Add(d); // ajoute le document à la collection
                }
            }
            return lesDocRecherches;
        }

        public void ListerDocuments()
        {
            foreach (Document d in lesDocuments)
            {
                Console.WriteLine(d);
                if (d.Type() == "Livre")
                {
                    Livre lelivre = (Livre)d; // on convertit le document en livre pour accéder aux méthodes de Livre
                    if (lelivre.Emprunte == true) // si le livre est emprunté
                    {
                        // il faut parcourir tout les adhérents pour savoir qui l'a emprunté
                        foreach (Adherent a in LesAdherents)
                        {
                            if (a.LesLivres.IndexOf(lelivre) != -1) // si on trouve le livre
                            {
                                Console.WriteLine("Emprunteur :" + a);
                                break;
                            }

                        }
                    }

                }
            }
        }
    }
}
