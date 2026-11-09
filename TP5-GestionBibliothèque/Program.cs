using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3_Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bibliotheque bibli = new Bibliotheque();
                //Ajout d'adhérents à la bibliothéque dans la collection d'adhérents 
                Adherent ad = new Adherent("Jean", "Dupond");
                bibli.AjouterAdherent(ad);
                Adherent ad2 = new Adherent("Marie", "Dubois");
                bibli.AjouterAdherent(ad2);
                // création de deux livres que l'on conservent dans des variables
                Livre livre1 = new Livre("Misérables", "Hugo V.");
                Livre livre2 = new Livre("Systèmes multi-agents", "Ferber J.");
                //ajout de documents dans la collection de bibliothéque
                bibli.AjouterDocument(livre1);
                bibli.AjouterDocument(livre2);
                bibli.AjouterDocument(new Journal("Dr Dobbs", Convert.ToDateTime("12/05/2017")));
                bibli.AjouterDocument(new BD("Thorgal: La galère noire", "Van Hamme", "Rosinsky"));
                bibli.AjouterDocument(new Dictionnaire("Petit Robert", "Robert !."));
                // affiche la liste des documents de la bibliothèque
                Console.WriteLine("------liste des documents---------------");
                foreach (Document d in bibli.LesDocuments)
                {
                    Console.WriteLine(d);
                }
                Console.ReadKey();
                // création de 2 emprunts pour le même adhérent
                ad.EmprunterLivre(livre1); // on note que l'adhérent ad emprunte le livre "Misérables"
                ad.EmprunterLivre(livre2); // on note que l'adhérent ad emprunte le livre "Systèmes multi-agents"

                Console.WriteLine("-------2/ affche les livres empruntés par l'adhérent------------------");
                // on affiche les livres emprunté par l'adhérent ad et on vérifie que la propriété 'emprunte' est à true
                foreach (Livre l in ad.LesLivres)
                {
                    Console.WriteLine(l);
                }
                Console.ReadKey();

                //l'adhérent ad rend le livre livre1
                ad.RendreLivre(livre1);
                //on affiche le livre1
                Console.WriteLine("--------3/ affiche du livre rendu-----------------");
                Console.WriteLine(livre1);
                Console.ReadKey();
                Console.WriteLine("-------4/ Livres empruntés par l'adhérent------------------");
                // on affiche les livres emprunté par l'adhérent ad
                foreach (Livre l in ad.LesLivres)
                {
                    Console.WriteLine(l);
                }
                Console.ReadKey();
                // recherche de documents contenant le texte
                List<Document> Docrecherche = bibli.ChercherDocument("ob");
                if (Docrecherche.Count == 0)
                {
                    Console.WriteLine("Aucun document trouvé");
                    Console.ReadKey();
                }
                else
                {
                    //affiche la liste des documents recherchés
                    Console.WriteLine("---les documents recherchés sont :");
                    foreach (Document d in Docrecherche)
                    {
                        Console.WriteLine(d);
                    }
                    Console.ReadKey();
                }

                // on va lister tous les documents de la bibliothèque et les éventuels emprunteurs des livres
                Console.WriteLine("-------liste des documents de la bibliothèque ---------------");
                bibli.ListerDocuments();
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur a été detectée :\n" + ex.Message);
            }
        }
    }
}
